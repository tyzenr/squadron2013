using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Squadron;

namespace SquadronAddIns.Default.PermissionGroups
{
    public partial class PermissionGroupsControl : UserControl
    {
        public PermissionGroupsControl()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (SPSite site = new SPSite(SquadronContext.Url, SquadronContext.GetUserToken()))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        grid.DataSource = null;

                        grid.DataSource = web.Groups.Cast<SPGroup>().ToList();

                        if (CrossSiteCheck.Checked)
                            grid.DataSource = web.SiteGroups.Cast<SPGroup>().ToList();

                        ResetGridColumns();
                    }
                }

                if (IncludeUsersCheck.Checked)
                    IncludeUsers();
            });
        }

        private void ResetGridColumns()
        {
            if (grid.Columns.Contains("UsersInGroup"))
                grid.Columns["UsersInGroup"].Visible = false;

            grid.Columns["Users"].Visible = false;
            grid.Columns["Roles"].Visible = false;
        }

        private void IncludeUsers()
        {
            DataGridViewColumn usersColumn = new DataGridViewColumn(new DataGridViewTextBoxCell());
            usersColumn.HeaderText = "UsersInGroup";
            usersColumn.Name = "UsersInGroup";
            grid.Columns.Insert(4, usersColumn);

            foreach (DataGridViewRow row in grid.Rows)
            {
                SPGroup group = row.DataBoundItem as SPGroup;

                string info = string.Empty;
                foreach (SPUser user in group.Users)
                {
                    if (ShowUserName.Checked)
                        info += user.Name;
                    else
                        info += user.LoginName;

                    info += ";";
                }

                if (!string.IsNullOrEmpty(info))
                    info = info.Remove(info.Length - 1, 1);

                row.Cells[usersColumn.Index].Value = info;
            }

            grid.Refresh();
        }

        private void IncludeUsersCheck_CheckedChanged(object sender, EventArgs e)
        {
            ShowUserName.Visible = IncludeUsersCheck.Checked;
        }
    }
}
