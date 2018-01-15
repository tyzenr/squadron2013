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

namespace SquadronAddIns.Default.Permission
{
    public partial class PermissionsControl : UserControl
    {
        public PermissionsControl()
        {
            InitializeComponent();
        }

        private IList<PermissionInfo> _result = new List<PermissionInfo>();
        private int _discardedCount;

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                _result.Clear();
                _discardedCount = 0;

                using (SPSite site = new SPSite(SquadronContext.Url, SquadronContext.GetUserToken()))
                {
                    // Site
                    if (SiteCheck.Checked)
                    {
                        if (AllWebsChecked.Checked)
                            foreach (SPWeb web in site.AllWebs)
                                ProcessWebSite(web);
                        else
                            using (SPWeb web = site.OpenWeb())
                                ProcessWebSite(web);
                    }

                    // List
                    if (ListCheck.Checked)
                    {
                        if (AllWebsChecked.Checked)
                            foreach (SPWeb web in site.AllWebs)
                                foreach (SPList list in web.Lists)
                                    ProcessList(list);
                        else
                            using (SPWeb web = site.OpenWeb())
                                foreach (SPList list in web.Lists)
                                    ProcessList(list);
                    }

                    // List Items
                    if (ItemCheck.Checked)
                    {
                        if (AllWebsChecked.Checked)
                            foreach (SPWeb web in site.AllWebs)
                                ProcessWebSite(web);
                        else
                            using (SPWeb web = site.OpenWeb())
                                ProcessWebSite(web);
                    }
                }

                ShowResultToGrid();
            });
        }

        private void ShowResultToGrid()
        {
            grid.DataSource = null;
            grid.DataSource = _result;

            grid.Columns["UsersInGroup"].Visible = ShowUsersInGroup.Checked;

            if (_discardedCount > 0)
                SquadronContext.WriteMessage("Discarded " + _discardedCount.ToString() + " based on condition specified!");
        }

        private void ProcessWebSite(SPWeb web)
        {
            if (FilterCheck.Checked)
                if (!Helper.Instance.IsUrlStartingWith(web.Url, SquadronContext.Url))
                    return;

            if (UniquePermissionsCheck.Checked)
                if (!web.HasUniqueRoleAssignments)
                {
                    _discardedCount++;
                    return;
                }

            string permissionType = GetPermissionType(web);
            _result.Add(
                new PermissionInfo()
                {
                    Type = "Site",
                    Title = web.Title,
                    Url = web.Url,
                    PermissionType = permissionType
                });

            if (!permissionType.Equals("UNIQUE"))
                if (!ExpandInheritedCheck.Checked)
                {
                    _result[_result.Count - 1].RoleAssignments = GetPermissionParentUrl(web);
                    return;
                }

            string roleAssignment = string.Empty;
            int count = 0;

            foreach (SPRoleAssignment rolea in web.RoleAssignments)
            {
                if (ShowUserName.Checked)
                    roleAssignment = rolea.Member.Name.ToString();
                else
                    roleAssignment = rolea.Member.LoginName.ToString();

                string permissionLevels = string.Empty;
                foreach (SPRoleDefinition roledef in rolea.RoleDefinitionBindings)
                    permissionLevels += roledef.Name + "; ";

                _result.Add(new PermissionInfo() { RoleAssignments = roleAssignment, PermissionLevels = permissionLevels, UsersInGroup = GetUsersInGroup(roleAssignment, web) });
                count++;
            }

            if (count == 0)
                _result.Add(new PermissionInfo() { RoleAssignments = "(no assignments)" });
        }

        private string GetPermissionParentUrl(SPWeb web)
        {
            SPWeb currentWeb = web;

            while (!currentWeb.HasUniqueRoleAssignments)
            {
                currentWeb = currentWeb.ParentWeb;
            }

            return currentWeb.Url;
        }

        private void ProcessList(SPList list)
        {
            if (FilterCheck.Checked)
                if (!Helper.Instance.IsUrlStartingWith(list.ParentWeb.Url, SquadronContext.Url))
                    return;

            if (UniquePermissionsCheck.Checked)
                if (!list.HasUniqueRoleAssignments)
                {
                    _discardedCount++;
                    return;
                }

            if (list.Hidden)
                if (!IncludeHiddenCheck.Checked)
                {
                    _discardedCount++;
                    return;
                }

            string type = "List";
            if (list is SPDocumentLibrary)
                type = "Library";

            string permissionType = GetPermissionType(list);

            var pinfo = new PermissionInfo()
                {
                    Type = type,
                    Title = list.Title,
                    Url = SPUtility.GetFullUrl(list.ParentWeb.Site, list.DefaultViewUrl),
                    PermissionType = permissionType
                };

            _result.Add(pinfo);

            if (!permissionType.Equals("UNIQUE"))
                if (!ExpandInheritedCheck.Checked)
                {
                    _result[_result.Count - 1].RoleAssignments = GetPermissionParentUrl(list.ParentWeb);
                    return;
                }


            string roleAssignment = string.Empty;
            int count = 0;

            foreach (SPRoleAssignment rolea in list.RoleAssignments)
            {
                roleAssignment = rolea.Member.ToString();

                string permissionLevels = string.Empty;
                foreach (SPRoleDefinition roledef in rolea.RoleDefinitionBindings)
                    permissionLevels += roledef.Name + "; ";

                _result.Add(new PermissionInfo() { RoleAssignments = roleAssignment, PermissionLevels = permissionLevels, UsersInGroup = GetUsersInGroup(roleAssignment, list.ParentWeb) });
                count++;
            }

            if (count == 0)
                _result.Add(new PermissionInfo() { RoleAssignments = "(no assignments)" });
        }

        private string GetUsersInGroup(string groupName, SPWeb web)
        {
            if (ShowUsersInGroup.Checked)
            {
                if (web.Groups.Cast<SPGroup>().Any(g => g.Name == groupName))
                    return GetGroupUsers(web.Groups.Cast<SPGroup>().First(g => g.Name == groupName));
            }

            return string.Empty;
        }

        private string GetGroupUsers(SPGroup group)
        {
            string result = string.Empty;

            foreach (SPUser user in group.Users)
            {
                if (ShowUserName.Checked)
                    result += user.Name;
                else
                    result += user.LoginName;

                result += ";";
            }

            if (result != string.Empty)
                result = result.Remove(result.Length - 1, 1);

            return result;
        }

        private string GetPermissionType(object o)
        {
            if (o is SPSecurableObject)
                if ((o as SPSecurableObject).HasUniqueRoleAssignments)
                    return "UNIQUE";

            return "Inherit";
        }

        private void inputURLsFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProcessListURLs(string[] urls)
        {
            _result.Clear();

            foreach (string url in urls)
            {
                SPList list = GetSPList(url);

                ProcessList(list);
            }

            ShowResultToGrid();
        }

        private SPList GetSPList(string url)
        {
            url = HttpUtility.UrlDecode(url);

            string siteUrl = ExtractSiteUrl(url);

            using (SPSite site = new SPSite(siteUrl, SquadronContext.GetUserToken()))
            {
                using (SPWeb web = site.OpenWeb())
                {
                    foreach (SPList list in web.Lists)
                        if (url.EndsWith(list.DefaultViewUrl))
                        {
                            return list;
                        }
                }
            }

            return null;
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

        }

        private void ExecuteButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
