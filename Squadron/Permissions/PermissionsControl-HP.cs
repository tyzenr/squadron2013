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

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            _result.Clear();

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
        }

        private void ShowResultToGrid()
        {
            grid.DataSource = null;
            grid.DataSource = _result;

            grid.Columns["UsersInGroup"].Visible = ShowUsersInGroup.Checked;
        }

        private void ProcessWebSite(SPWeb web)
        {
            if (UniquePermissionsCheck.Checked)
                if (!web.HasUniqueRoleAssignments)
                    return;

            _result.Add(
                new PermissionInfo()
                {
                    Type = "Site",
                    Title = web.Title,
                    Url = web.Url,
                    PermissionType = GetPermissionType(web)
                });

            string roleAssignment = string.Empty;
            int count = 0;

            foreach (SPRoleAssignment rolea in web.RoleAssignments)
            {
                roleAssignment = rolea.Member.ToString();

                string permissionLevels = string.Empty;
                foreach (SPRoleDefinition roledef in rolea.RoleDefinitionBindings)
                    permissionLevels += roledef.Name + "; ";

                _result.Add(new PermissionInfo() { RoleAssignments = roleAssignment, PermissionLevels = permissionLevels, UsersInGroup = GetUsersInGroup(roleAssignment, web) });
                count++;
            }

            if (count == 0)
                _result.Add(new PermissionInfo() { RoleAssignments = "(no assignments)" });
        }

        private void ProcessList(SPList list)
        {
            if (UniquePermissionsCheck.Checked)
                if (!list.HasUniqueRoleAssignments)
                    return;

            if (list.Hidden)
                if (!IncludeHiddenCheck.Checked)
                    return;

            string type = "List";
            if (list is SPDocumentLibrary)
                type = "Library";

            var pinfo = new PermissionInfo()
                {
                    Type = type,
                    Title = list.Title,
                    Url = SPUtility.GetFullUrl(list.ParentWeb.Site, list.DefaultViewUrl),
                    PermissionType = GetPermissionType(list)
                };

            _result.Add(pinfo);

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
                result += user.LoginName + ",";

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
            ListCheck.Checked = true;
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _result.Clear();

                string[] urls = File.ReadAllLines(openFileDialog1.FileName);

                foreach (string url in urls)
                {
                    if (!string.IsNullOrEmpty(url.Trim()))
                    {
                        SPList list = GetSPList(url);

                        ProcessList(list);
                    }
                }

                ShowResultToGrid();
            }
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

                CONTINUE HERE
                //result = result.Substring(0, result.Reverse(.IndexOf("/Forms/"));
            }

            return result;
        }
    }
}
