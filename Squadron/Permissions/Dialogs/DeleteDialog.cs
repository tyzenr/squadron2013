using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using Squadron;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SquadronAddIns.Default.Utility;
using SquadronAddIns.Default.Permissions.Entity;
using System.Diagnostics;
using Squadron.Common;
using Squadron.Dialogs;
using Squadron.Components;
using Windows8LookNFeel;

namespace SquadronAddIns.Default.Permissions.Dialogs
{
    public partial class DeleteDialog : Windows8LookNFeel.Windows8Form
    {
        private SecurableObjectEnumerator _enumerator = new SecurableObjectEnumerator();

        public DeleteDialog()
        {
            InitializeComponent();
        }

        protected override void FormInit()
        {
            base.FormInit();

            UrlText.Text = SquadronContext.Url;
            ADText.Text = SquadronContext.DomainName;

            if (Debugger.IsAttached)
            {
                NameText.Text = "manager";
                ListCheck.Checked = ItemCheck.Checked = false;
            }
        }

        enum DialogMode
        {
            PermissionDelete,
            DeadAccountDelete
        }

        private DialogMode _mode;

        private void FindButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            _mode = DialogMode.PermissionDelete;

            try
            {
                SquadronHelper.Instance.StartAnimation();

                var soList = _enumerator.GetSecurableObjects(UrlText.Text, ScopeEnum.WebApplication, SiteCheck.Checked, ListCheck.Checked, ItemCheck.Checked, ItemCheck.Checked, !UniquePermissionsCheck.Checked);
                var nameList = GetNameList(soList);

                Display(nameList);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void Display(IList<NameEntity> nameList)
        {
            ItemsList.Items.Clear();

            foreach (NameEntity name in nameList)
                ItemsList.Items.Add(name);

            FooterPanel.Text = ItemsList.Items.Count.ToString() + " item(s) found!";
        }

        private IList<NameEntity> GetNameList(IList<SecurableObject> soList)
        {
            IList<NameEntity> result = new List<NameEntity>();
            string searchName = NameText.Text;

            foreach (SecurableObject so in soList)
            {
                foreach (SPRoleAssignment ra in (so.InternalObject as SPSecurableObject).RoleAssignments)
                {
                    IsMatch(string.Empty, result, searchName, so, ra.Member);

                    if (ra.Member is SPGroup)
                    {
                        SPGroup group = ra.Member as SPGroup;
                        foreach (SPUser user in group.Users)
                            IsMatch(group.Name, result, searchName, so, user);
                    }
                }
            }

            return result;
        }

        private bool IsMatch(string groupName, IList<NameEntity> list, string searchName, SecurableObject so, SPPrincipal p)
        {
            bool result = IsNameMatch(groupName, list, searchName, so, p) ||
                       IsLoginNameMatch(groupName, list, searchName, so, p);

            return result;
        }

        private bool IsLoginNameMatch(string groupName, IList<NameEntity> result, string searchName, SecurableObject so, SPPrincipal p)
        {
            if (!string.IsNullOrEmpty(p.LoginName))
                if (p.LoginName.ToLower().Contains(searchName.ToLower()))
                {
                    result.Add(new NameEntity() { Name = p.LoginName, Principal = p, SecurableObject = so, ContainerSPGroup = groupName });
                    return true;
                }

            return false;
        }

        private bool IsNameMatch(string groupName, IList<NameEntity> result, string searchName, SecurableObject so, SPPrincipal p)
        {
            if (!string.IsNullOrEmpty(p.Name))
                if (p.Name.ToLower().Contains(searchName.ToLower()))
                {
                    result.Add(new NameEntity() { Name = p.Name, Principal = p, SecurableObject = so, ContainerSPGroup = groupName });
                    return true;
                }

            return false;
        }

        private void ItemsList_DoubleClick(object sender, EventArgs e)
        {
            if (ItemsList.SelectedItem != null)
                if (ItemsList.SelectedItem is NameEntity)
                {
                    var selectedObject = (ItemsList.SelectedItem as NameEntity).SecurableObject.InternalObject;
                    new PropertyDialog().ExecuteDialog(selectedObject);
                }

                else if (ItemsList.SelectedItem is SPUser)
                {
                    var selectedObject = (ItemsList.SelectedItem as SPUser);
                    new PropertyDialog().ExecuteDialog(selectedObject);
                }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ItemsList.CheckedItems.Count == 0)
                SquadronContext.Info("Please check atleast one item!");

            else if (ConfirmDelete())
            {
                if (_mode == DialogMode.PermissionDelete)
                    Delete();

                else if (_mode == DialogMode.DeadAccountDelete)
                    RemoveDeadAccounts();
            }
        }

        private void RemoveDeadAccounts()
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                var selectedList = new List<SPUser>();
                foreach (SPUser spuser in ItemsList.CheckedItems)
                    selectedList.Add(spuser);

                foreach (SPUser spuser in selectedList)
                {
                    foreach (SecurableObject so in _enumerator.GetSecurableObjects(UrlText.Text, ScopeEnum.WebApplication, true, false, false, false, false))
                    {
                        _sharePointUtility.RemoveUserFromWeb(so.InternalObject as SPWeb, spuser);

                        ItemsList.Items.Remove(spuser);
                    }
                }
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private bool ConfirmDelete()
        {
            if (_mode == DialogMode.PermissionDelete)
                return SquadronContext.Confirm("Are you sure you want to DELETE the selected Permission(s)?" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "WARNING: Role Assignment will be removed, SharePoint Group entry will be deleted");
            else
                return SquadronContext.Confirm("Are you sure you want to REMOVE the selected dead accounts?" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "WARNING: Dead Account will be removed from all web/list/item permission entries in given URL");
        }

        private void Delete()
        {
            var checkedItems = new List<NameEntity>();
            foreach (NameEntity o in ItemsList.CheckedItems)
                checkedItems.Add(o);

            int errorCount = 0;

            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    foreach (NameEntity ne in checkedItems)
                    {
                        SPSecurableObject spso = ne.SecurableObject.InternalObject as SPSecurableObject;
                        ne.Deleted = false;

                        try
                        {
                            if (string.IsNullOrEmpty(ne.ContainerSPGroup))
                                spso.RoleAssignments.Remove(ne.Principal);
                            else
                                RemoveUserFromSharePointGroup(ne, spso);

                            ne.Deleted = true;
                        }
                        catch (Exception ex)
                        {
                            SquadronContext.WriteMessage(ex.ToString());
                            errorCount++;
                            ne.Deleted = false;
                        }

                        // Remove from Groups
                        if (ne.Principal is SPGroup)
                        {
                            if (spso is SPWeb)
                            {
                                try
                                {
                                    if (string.IsNullOrEmpty(ne.ContainerSPGroup))
                                    {
                                        bool old = (spso as SPWeb).AllowUnsafeUpdates;

                                        (spso as SPWeb).AllowUnsafeUpdates = true;
                                        (spso as SPWeb).Update();

                                        (spso as SPWeb).SiteGroups.Remove(ne.Principal.Name);

                                        (spso as SPWeb).AllowUnsafeUpdates = old;
                                        (spso as SPWeb).Update();
                                    }

                                    ne.Deleted = true;
                                }
                                catch (Exception ex)
                                {
                                    SquadronContext.HandleException(spso, ex);
                                    errorCount++;
                                    ne.Deleted = false;
                                }
                            }
                        }

                        if (ne.Deleted)
                            ItemsList.Items.Remove(ne);
                    }
                });

            // Display
            if (errorCount > 0)
                SquadronContext.Info("Error(s) occured.  Please see the master log for details!");
        }

        private static void RemoveUserFromSharePointGroup(NameEntity ne, SPSecurableObject spso)
        {
            SPWeb web = null;
            if (spso is SPWeb)
                web = spso as SPWeb;
            else if (spso is SPList)
                web = (spso as SPList).ParentWeb;
            else if (spso is SPListItem)
                web = (spso as SPListItem).ParentList.ParentWeb;

            if (web != null)
            {
                bool old = web.AllowUnsafeUpdates;
                web.AllowUnsafeUpdates = true;
                web.Update();

                web.SiteGroups[ne.ContainerSPGroup].Users.Remove(ne.Principal.LoginName);

                web.AllowUnsafeUpdates = old;
                web.Update();
            }
        }

        private ActiveDirectoryUtility _adhelper = new ActiveDirectoryUtility();
        private IList<SPUser> _deadAccounts = new List<SPUser>();

        private void FindDeadAccountsButton_Click(object sender, EventArgs e)
        {
            _mode = DialogMode.DeadAccountDelete;

            try
            {
                SquadronHelper.Instance.StartAnimation();

                var soList = _enumerator.GetSecurableObjects(UrlText.Text, ScopeEnum.WebApplication, SiteCheck.Checked, ListCheck.Checked, ItemCheck.Checked, ItemCheck.Checked, !UniquePermissionsCheck.Checked);

                var allUsersList = _enumerator.GetPrincipals(UrlText.Text);

                _deadAccounts.Clear();

                foreach (SPUser user in allUsersList)
                    if (!_sharePointUtility.IsInternalUser(user))
                        if (!_adhelper.IsExists(ADText.Text, user.LoginName))
                            _deadAccounts.Add(user);

                Display(_deadAccounts);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private SharePointUtility _sharePointUtility = new SharePointUtility();

        private void Display(IList<SPUser> list)
        {
            ItemsList.Items.Clear();

            foreach (SPUser user in list)
                ItemsList.Items.Add(user);

            FooterPanel.Text = ItemsList.Items.Count.ToString() + " item(s) found!";
        }

        private void userPic_Click(object sender, EventArgs e)
        {
            UserDialog dialog = new UserDialog();
            if (dialog.ExecuteDialog(NameText.Text, UrlText.Text))
                NameText.Text = dialog.SelectedUser.LoginName;
        }
    }
}
