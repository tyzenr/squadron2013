using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Collections;

namespace Squadron.Dialogs
{
    public partial class UserDialog : Windows8LookNFeel.Windows8Form
    {
        public UserDialog()
        {
            InitializeComponent();
        }

        private string _url;

        public bool ExecuteDialog(string name, string url)
        {
            NameText.Text = name;
            _url = url;

            return base.ExecuteDialog();
        }

        protected override void FormInit()
        {
            base.FormInit();

            Find();
        }

        private IList<SPUser> _users;

        protected override bool IsOverlayRequrired
        {
            get
            {
                return false;
            }
        }

        private IList<SPUser> GetUsers()
        {
            IList<SPUser> list = new List<SPUser>();

            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(_url));

                    foreach (SPSite site in webApplication.Sites)
                        foreach (SPWeb web in site.AllWebs)
                            foreach (SPUser user in web.AllUsers)
                            {
                                bool found = false;

                                if (string.IsNullOrEmpty(NameText.Text))
                                {
                                    found = true;
                                    AddUser(list, user);
                                }

                                else if (!string.IsNullOrEmpty(user.LoginName))
                                {
                                    if (user.LoginName.ToLower().Contains(NameText.Text.ToLower()))
                                    {
                                        found = true;
                                        AddUser(list, user);
                                    }

                                    if (!found)
                                        if (user.Name.ToLower().Contains(NameText.Text.ToLower()))
                                        {
                                            found = true;
                                            AddUser(list, user);
                                        }
                                }
                            }
                });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            return list;
        }

        private static void AddUser(IList<SPUser> list, SPUser user)
        {
            if (!list.Any(u => u.LoginName == user.LoginName))
                list.Add(user);
        }

        public SPUser SelectedUser;

        private void list_DoubleClick(object sender, EventArgs e)
        {
            SelectAndClose();
        }

        private void SelectAndClose()
        {
            if (list.SelectedItem != null)
            {
                SelectedUser = _users[list.SelectedIndex];
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void Find()
        {
            _users = GetUsers();

            list.Items.Clear();
            foreach (SPUser user in _users)
                list.Items.Add(user.LoginName);

            FooterPanel.Text = _users.Count.ToString() + " user(s) found.";
        }

        private void UserDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (NameText.Focused)
                    FindButton.PerformClick();

                else if (list.Focused)
                    SelectAndClose();
            }
        }
    }
}
