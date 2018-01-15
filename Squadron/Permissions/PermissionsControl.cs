using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Permissions.Entity;
using Microsoft.SharePoint.Utilities;
using Squadron;
using System.IO;
using System.Web;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using Microsoft.SharePoint.Administration;
using SquadronAddIns.Default.Permissions.Wizards;
using System.Collections;
using SquadronAddIns.Default.Permissions.Dialogs;
using System.Diagnostics;
using Squadron.Components;
using SquadronAddIns.Default.Utility;
using SquadronAddIns.Default.Utility.Entity;
using SquadronAddIns.Default.Exceptions;

namespace SquadronAddIns.Default.Permission
{
    public partial class PermissionsControl : UserControl
    {
        public PermissionsControl()
        {
            InitializeComponent();

            Url = FilterText.Text = GetUrl();
            Scope = ScopeEnum.WebApplication;

            grid.SelectionChanged += grid_SelectionChanged;

            if (Debugger.IsAttached)
            {
            }
        }

        public bool UrlStaticMode;

        public string Url
        {
            get;
            set;
        }

        public IList<object> SelectedObjects
        {
            get;
            set;
        }

        public bool SelectedObjectsMode;

        public ScopeEnum Scope
        {
            get;
            set;
        }

        public void HideControls()
        {
            TopPanel.Visible = false;

            split.SplitterDistance = split.Width;
            split.Panel2.Hide();
        }

        public IList<PermissionInfo> Result = new List<PermissionInfo>();
        private int _discardedCount;

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private bool _errorsOccurred;

        public void Execute()
        {
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grid.DataSource = null;
            _errorsOccurred = false;

            SquadronHelper.Instance.StartAnimation();
            InitConstants();

            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    Result.Clear();
                    _discardedCount = 0;

                    if (SelectedObjectsMode)
                    {
                        IterateSelectedObjects();
                    }
                    else
                    {
                        if (Scope == ScopeEnum.WebApplication)
                            WebApplicationScope();

                        else if (Scope == ScopeEnum.SiteCollection)
                            SiteCollectionScope();

                        else if (Scope == ScopeEnum.Site)
                            SiteScope();
                    }

                    ShowResultToGrid();
                });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void IterateSelectedObjects()
        {
            foreach (object o in SelectedObjects)
            {
                if (o is SPWeb)
                    ProcessWebSite(o as SPWeb);

                if (o is SPList)
                    if (!IsListDiscarded(o as SPList))
                        ProcessList(o as SPList);

                if (o is SPListItem)
                    if (!IsListDiscarded((o as SPListItem).ParentList))
                        ProcessListItem(o as SPListItem, "Item");

                if (o is SPFolder)
                    if ((o as SPFolder).Item != null)
                        if (!IsListDiscarded((o as SPFolder).Item.ParentList))
                            ProcessListItem((o as SPFolder).Item, "Folder");
            }
        }

        private void SiteScope()
        {
            SquadronContext.WriteDebugMessage("Entering SiteScope()");

            using (SPSite site = new SPSite(GetUrl()))
            {
                foreach (SPWeb web in site.AllWebs)
                    if (Helper.Instance.AreUrlsEqual(web.Url, GetUrl()))
                    {
                        // Site
                        if (SiteCheck.Checked)
                        {
                            ProcessWebSite(web);
                        }

                        // List
                        if (ListCheck.Checked)
                        {
                            foreach (SPList list in web.Lists)
                                if (!IsListDiscarded(list))
                                    ProcessList(list);
                        }

                        // List Item
                        if (ItemCheck.Checked)
                        {
                            foreach (SPList list in web.Lists)
                                if (!IsListDiscarded(list))
                                {
                                    try
                                    {
                                        foreach (SPListItem folder in list.Folders)
                                            ProcessListItem(folder, "Folder");
                                    }
                                    catch (Exception ex)
                                    {
                                        SquadronContext.HandleException(ex);
                                    }

                                    try
                                    {
                                        foreach (SPListItem item in list.Items)
                                            ProcessListItem(item, "Item");
                                    }
                                    catch (Exception ex)
                                    {
                                        SquadronContext.HandleException(ex);
                                    }
                                }
                        }
                    }
            }
        }

        private string GetUrl()
        {
            if (UrlStaticMode)
                return Url;

            return SquadronContext.Url;
        }

        public void WebApplicationScope()
        {
            SquadronContext.WriteDebugMessage("Entering WebApplicationScope()");

            SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(GetUrl()));

            foreach (SPSite site in webApplication.Sites)
            {
                // Site
                if (SiteCheck.Checked)
                {
                    foreach (SPWeb web in site.AllWebs)
                        ProcessWebSite(web);
                }

                // List
                if (ListCheck.Checked)
                {
                    foreach (SPWeb web in site.AllWebs)
                        foreach (SPList list in web.Lists)
                            if (!IsListDiscarded(list))
                                ProcessList(list);
                }

                // List Item
                if (ItemCheck.Checked)
                {
                    foreach (SPWeb web in site.AllWebs)
                        foreach (SPList list in web.Lists)
                            if (!IsListDiscarded(list))
                            {
                                try
                                {
                                    foreach (SPListItem folder in list.Folders)
                                        ProcessListItem(folder, "Folder");
                                }
                                catch (Exception ex)
                                {
                                    SquadronContext.HandleException(ex);
                                }

                                try
                                {
                                    foreach (SPListItem item in list.Items)
                                        ProcessListItem(item, "Item");
                                }
                                catch (Exception ex)
                                {
                                    SquadronContext.HandleException(ex);
                                }
                            }
                }
            }
        }

        private void SiteCollectionScope()
        {
            SquadronContext.WriteDebugMessage("Entering SiteCollectionScope()");

            using (SPSite site = new SPSite(GetUrl()))
            {
                // Site
                if (SiteCheck.Checked)
                {
                    foreach (SPWeb web in site.AllWebs)
                        ProcessWebSite(web);
                }

                // List
                if (ListCheck.Checked)
                {
                    foreach (SPWeb web in site.AllWebs)
                        foreach (SPList list in web.Lists)
                            if (!IsListDiscarded(list))
                                ProcessList(list);
                }

                // List Item
                if (ItemCheck.Checked)
                {
                    foreach (SPWeb web in site.AllWebs)
                        foreach (SPList list in web.Lists)
                            if (!IsListDiscarded(list))
                            {
                                try
                                {
                                    foreach (SPListItem folder in list.Folders)
                                        ProcessListItem(folder, "Folder");
                                }
                                catch (Exception ex)
                                {
                                    SquadronContext.HandleException(ex);
                                }

                                try
                                {
                                    foreach (SPListItem item in list.Items)
                                        ProcessListItem(item, "Item");
                                }
                                catch (Exception ex)
                                {
                                    SquadronContext.HandleException(ex);
                                }
                            }
                }
            }
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.SelectedCells.Count > 0)
                if (grid.Rows[grid.SelectedCells[0].RowIndex].DataBoundItem != null)
                    propertyGrid.SelectedObject = (grid.Rows[grid.SelectedCells[0].RowIndex].DataBoundItem as PermissionInfo).InternalObject;
        }

        private void ProcessListItem(SPListItem item, string type)
        {
            SquadronContext.WriteDebugMessage("Entering ProcessListItem() " + _utility.GetDisplayName(item, true));

            try
            {
                if (UniquePermissionsCheck.Checked)
                    if (!item.HasUniqueRoleAssignments)
                    {
                        _discardedCount++;
                        return;
                    }

                string permissionType = GetPermissionType(item);

                var pinfo = new PermissionInfo()
                {
                    Type = type,
                    Title = item.DisplayName,
                    Url = item["EncodedAbsUrl"].ToString(),
                    PermissionType = permissionType,
                    InternalObject = item,
                    InheritUrl = GetInheritedUrl(item)
                };

                if (IsFilterDiscard(pinfo.Url))
                    return;

                Result.Add(pinfo);

                if (permissionType.StartsWith("Inherit"))
                    if (!ExpandInheritedCheck.Checked)
                        return;

                string roleAssignment = string.Empty;
                int count = 0;

                foreach (SPRoleAssignment rolea in item.RoleAssignments)
                {
                    roleAssignment = rolea.Member.ToString();

                    string permissionLevels = string.Empty;
                    foreach (SPRoleDefinition roledef in rolea.RoleDefinitionBindings)
                        permissionLevels += roledef.Name + "; ";

                    Result.Add(
                        new PermissionInfo()
                        {
                            RoleAssignments = roleAssignment,
                            RoleType = GetRoleType(rolea.Member),
                            Owner = GetOwner(rolea.Member),
                            PermissionLevels = permissionLevels,
                            UsersInGroup = GetUsersInGroup(roleAssignment, item.ParentList.ParentWeb),
                            InternalObject = item
                        }
                        );
                    count++;
                }

                if (count == 0)
                    Result.Add(new PermissionInfo() { RoleAssignments = "(no assignments)" });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(new ObjectException(item, ex));
                _errorsOccurred = true;
            }
        }

        private SharePointUtility _utility = new SharePointUtility();

        private string GetInheritedUrl(SPSecurableObject so)
        {
            if (!so.HasUniqueRoleAssignments)
            {
                return _utility.GetUrl(so.FirstUniqueAncestorSecurableObject);
            }

            return "n.a";
        }

        private bool IsFilterDiscard(string url)
        {
            url = url.ToLower().Replace("%20", " ");
            string userUrl = FilterText.Text.ToLower().Replace("%20", " ");

            if (FilterCheck.Checked)
                if (!url.StartsWith(userUrl))
                {
                    _discardedCount++;

                    return true;
                }

            return false;
        }

        private void InitConstants()
        {
            _domainName = _adHelper.GetDomainName();
            _adHelper.ClearCache();
        }

        private void ShowResultToGrid()
        {
            grid.DataSource = null;
            grid.DataSource = Result;

            grid.Columns["UsersInGroup"].Visible = ShowUsersInGroup.Checked;
            grid.Columns["InheritUrl"].Visible = IncludeInheritUrlChecked.Checked;

            if (grid.Columns.Contains("InternalObject"))
                grid.Columns["InternalObject"].Visible = false;

            if (_discardedCount > 0)
                SquadronContext.WriteMessage("Discarded " + _discardedCount.ToString() + " result(s) based on condition specified!");

            if (_errorsOccurred)
                SquadronContext.Errr("Some of the permission items thrown exeptions.  Please check the log for details!");

            Helper.Instance.DisableSort(grid);
        }

        private void ProcessWebSite(SPWeb web)
        {
            SquadronContext.WriteDebugMessage("Entering ProcessWebSite() " + _utility.GetDisplayName(web, true));

            try
            {
                if (IsFilterDiscard(web.Url))
                    return;

                if (UniquePermissionsCheck.Checked)
                    if (!web.HasUniqueRoleAssignments)
                    {
                        _discardedCount++;
                        return;
                    }

                string permissionType = GetPermissionType(web);
                Result.Add(
                    new PermissionInfo()
                    {
                        Type = "Site",
                        Title = web.Title,
                        Url = web.Url,
                        PermissionType = permissionType,
                        InternalObject = web,
                        InheritUrl = GetInheritedUrl(web)
                    });

                if (permissionType.StartsWith("Inherit"))
                    if (!ExpandInheritedCheck.Checked)
                        return;

                string roleAssignment = string.Empty;

                int count = 0;

                foreach (SPRoleAssignment rolea in web.RoleAssignments)
                {
                    roleAssignment = rolea.Member.ToString();

                    string permissionLevels = string.Empty;
                    foreach (SPRoleDefinition roledef in rolea.RoleDefinitionBindings)
                        permissionLevels += roledef.Name + "; ";

                    Result.Add(
                            new PermissionInfo()
                            {
                                RoleAssignments = roleAssignment,
                                RoleType = GetRoleType(rolea.Member),
                                Owner = GetOwner(rolea.Member),
                                PermissionLevels = permissionLevels,
                                UsersInGroup = GetUsersInGroup(roleAssignment, web),
                                InternalObject = web
                            }
                            );
                    count++;
                }

                if (count == 0)
                    Result.Add(new PermissionInfo() { RoleAssignments = "(no assignments)" });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(new ObjectException(web, ex));
                _errorsOccurred = true;
            }
        }

        private string GetOwner(SPPrincipal p)
        {
            if (p is SPGroup)
                return (p as SPGroup).Owner.ToString();

            return string.Empty;
        }

        private string GetRoleType(SPPrincipal principal)
        {
            if (principal is SPGroup)
                return "SharePoint Group";

            else if (principal is SPUser)
            {
                string loginName = (principal as SPUser).LoginName;

                if (_adHelper.IsWindowsUser(loginName))
                    return "User";

                if (_adHelper.IsUser(SquadronContext.DomainName, loginName))
                    return "User";

                else if (_adHelper.IsGroup(SquadronContext.DomainName, loginName))
                    return "Domain Group";
            }

            return "System Account";
        }

        private bool IsListDiscarded(SPList list)
        {
            bool result = false;

            if (UniquePermissionsCheck.Checked)
                if (!list.HasUniqueRoleAssignments)
                    result = true;

            if (list.Hidden)
                if (!IncludeHiddenCheck.Checked)
                    result = true;

            if (result)
                _discardedCount++;

            return result;
        }

        private void ProcessList(SPList list)
        {
            SquadronContext.WriteDebugMessage("Entering ProcessList() " + _utility.GetDisplayName(list, true));

            try
            {
                string type = "List";
                if (list is SPDocumentLibrary)
                    type = "Library";

                string url = SPUtility.GetFullUrl(list.ParentWeb.Site, list.DefaultViewUrl);

                if (IsFilterDiscard(url))
                    return;

                string permissionType = GetPermissionType(list);
                var pinfo = new PermissionInfo()
                    {
                        Type = type,
                        Title = list.Title,
                        Url = url,
                        PermissionType = permissionType,
                        InternalObject = list,
                        InheritUrl = GetInheritedUrl(list)
                    };

                Result.Add(pinfo);

                if (permissionType.StartsWith("Inherit"))
                    if (!ExpandInheritedCheck.Checked)
                        return;

                string roleAssignment = string.Empty;
                int count = 0;

                foreach (SPRoleAssignment rolea in list.RoleAssignments)
                {
                    roleAssignment = rolea.Member.ToString();

                    string permissionLevels = string.Empty;
                    foreach (SPRoleDefinition roledef in rolea.RoleDefinitionBindings)
                        permissionLevels += roledef.Name + "; ";

                    Result.Add(
                            new PermissionInfo()
                            {
                                RoleAssignments = roleAssignment,
                                RoleType = GetRoleType(rolea.Member),
                                Owner = GetOwner(rolea.Member),
                                PermissionLevels = permissionLevels,
                                UsersInGroup = GetUsersInGroup(roleAssignment, list.ParentWeb),
                                InternalObject = list.ParentWeb
                            }
                            );

                    count++;
                }

                if (count == 0)
                    Result.Add(new PermissionInfo() { RoleAssignments = "(no assignments)" });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(new ObjectException(list, ex));
                _errorsOccurred = true;
            }
        }

        private IList<ADEntity> _adGroups = new List<ADEntity>();
        private ActiveDirectoryUtility _adHelper = new ActiveDirectoryUtility();
        private string _domainName;

        private string GetUsersInGroup(string groupName, SPWeb web)
        {
            if (ShowUsersInGroup.Checked)
            {
                if (web.Groups.Cast<SPGroup>().Any(g => g.Name == groupName))
                    return GetGroupUsers(web.Groups.Cast<SPGroup>().First(g => g.Name == groupName));

                else // Active Directory Group / User
                {
                    if (!string.IsNullOrEmpty(groupName))
                        return GetADUsers(groupName);
                }
            }

            return string.Empty;
        }

        private string GetADUsers(string groupName)
        {
            string result = string.Empty;

            if (_adGroups.Count == 0)
                _adGroups = _adHelper.GetAll(SquadronContext.DomainName, true, false, false).ToList();

            string trimmedName = GetTrimmedName(groupName);
            if (_adGroups.Any(g => g.LoginName.ToLower() == trimmedName.ToLower()))
            {
                var list = _adHelper.GetGroupMembers(SquadronContext.DomainName, trimmedName);

                foreach (Principal user in list)
                {
                    if (ShowUserName.Checked)
                        result += _domainName + "\\" + user.SamAccountName + " (" + user.Name + ")";
                    else
                        result += _domainName + "\\" + user.SamAccountName;

                    result += "; ";
                }

                if (result != string.Empty)
                    result = result.Remove(result.Length - 2, 2).Trim();
            }

            return result;
        }

        private string GetTrimmedName(string name)
        {
            if (name.Contains("\\"))
            {
                string result = name.Substring(name.IndexOf("\\") + 1, name.Length - name.IndexOf("\\") - 1);
                return result;
            }

            return name;
        }

        private string GetGroupUsers(SPGroup group)
        {
            string result = string.Empty;

            foreach (SPUser user in group.Users)
            {
                if (ShowUserName.Checked)
                    result += user.LoginName + " (" + user.Name + ")";
                else
                    result += user.Name;

                result += "; ";
            }

            if (result != string.Empty)
                result = result.Remove(result.Length - 2, 2).Trim();

            return result;
        }

        private string GetPermissionType(object o)
        {
            if (o is SPSecurableObject)
                if ((o as SPSecurableObject).HasUniqueRoleAssignments)
                    return "Unique";

            return "Inherit";
        }

        private void ProcessListURLs(string[] urls)
        {
            Result.Clear();

            foreach (string url in urls)
            {
                SPList list = GetSPList(url);

                ProcessList(list);
            }

            ShowResultToGrid();
        }

        private SPList GetSPList(string url)
        {
            SPList result = null;

            url = HttpUtility.UrlDecode(url);

            string siteUrl = ExtractSiteUrl(url);

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (SPSite site = new SPSite(siteUrl))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        foreach (SPList list in web.Lists)
                            if (url.EndsWith(list.DefaultViewUrl))
                            {
                                result = list;
                            }
                    }
                }
            });

            return result;
        }

        private string ExtractSiteUrl(string url)
        {
            string result = string.Empty;

            if (url.Contains("/Lists/"))
                result = url.Substring(0, url.IndexOf("/Lists/"));

            else if (url.Contains("/Forms/"))
            {
                result = url.Substring(0, url.IndexOf("/Forms/"));
                result = url.Substring(0, result.LastIndexOf('/'));
            }

            return result;
        }

        private void fromTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool oldValue = ListCheck.Checked;

            ListCheck.Checked = true;
            OpenDialog.Filter = "Text Files (*.txt)|*.txt";

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                ProcessListURLs(File.ReadAllLines(OpenDialog.FileName));
            }

            ListCheck.Checked = oldValue;
        }

        private void fromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool oldValue = ListCheck.Checked;

            ListCheck.Checked = true;
            OpenDialog.Filter = "Text Files (*.txt)|*.txt";

            if (Clipboard.GetText().Length > 0)
            {
                string[] urls = Clipboard.GetText().Split(new[] { '\r', '\n' });
                ProcessListURLs(urls);
            }

            ListCheck.Checked = oldValue;
        }

        private void ShowUsersInGroup_CheckedChanged(object sender, EventArgs e)
        {
            ShowUserName.Enabled = ShowUsersInGroup.Checked;
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            FilterText.Visible = FilterCheck.Checked;
        }

        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (HighlightUniqueCheck.Checked)
                    if (e.RowIndex > -1)
                        if (e.ColumnIndex > -1)
                            if (grid.Columns[e.ColumnIndex].HeaderText == "PermissionType")
                                if (grid.Rows[e.RowIndex] != null)
                                    if (grid.Rows[e.RowIndex].DataBoundItem != null)
                                        if (grid.Rows[e.RowIndex].DataBoundItem is PermissionInfo)
                                            if ((grid.Rows[e.RowIndex].DataBoundItem as PermissionInfo).PermissionType == "Unique")
                                                e.CellStyle.BackColor = Color.Yellow;
                                            else if ((grid.Rows[e.RowIndex].DataBoundItem as PermissionInfo).PermissionType == "Inherit")
                                                e.CellStyle.BackColor = Color.LightGreen;
            }
            catch
            {
            }
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            new BackupWizard().ExecuteDialog();
        }

        public IList<PermissionInfo> GetList()
        {
            return grid.DataSource as IList<PermissionInfo>;
        }

        public DataTable GetDataTable(bool excludeColumns)
        {
            DataTable table = null;

            if (grid.DataSource != null)
                if (grid.DataSource is DataSet)
                    if ((grid.DataSource as DataSet).Tables.Count > 0)
                        table = (grid.DataSource as DataSet).Tables[0];

            if (grid.DataSource != null)
                if (grid.DataSource.GetType().ToString().StartsWith("System.Collections.Generic.List"))
                    table = Helper.Instance.ConvertToDataTable(grid.DataSource as IList);

            if (excludeColumns)
                table.Columns.Remove("InternalObject");

            return table;
        }

        private void RestorButton_Click(object sender, EventArgs e)
        {
            new RestoreWizard().ExecuteDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            new DeleteDialog().ExecuteDialog();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            new CopyDialog().ExecuteDialog();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            new ResetDialog().ExecuteDialog();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            new FindDialog().ExecuteDialog();
        }
    }
}
