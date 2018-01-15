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
using SquadronAddIns.Default.Utility;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Utility.Entity;

namespace SquadronAddIns.Default.Permissions.Dialogs
{
    public partial class ResetDialog : Windows8LookNFeel.Windows8Form
    {
        public ResetDialog()
        {
            InitializeComponent();
        }

        protected override void FormInit()
        {
            base.FormInit();

            browser.Url = SquadronContext.Url;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Find();
        }

        private SharePointUtility _utility = new SharePointUtility();
        private IList<SharePointObject> _selectedList;

        private void Find()
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                var originalList = _utility.GetAllObjectsUnder(browser.SelectedObject);
                originalList.Insert(0, new SharePointObject() { InternalObject = browser.SelectedObject }); // Add current item too

                // Filter
                var tempList = originalList.Where(o => ((o.InternalObject is SPSecurableObject) && (o.InternalObject as SPSecurableObject).HasUniqueRoleAssignments)).ToList();
                _selectedList = tempList.Where(o => IsValid(o)).ToList();

                Show(originalList);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void Show(IList<SharePointObject> originalList)
        {
            ItemsList.Items.Clear();
            foreach (SharePointObject o in _selectedList)
                ItemsList.Items.Add(o);

            int diff = originalList.Count - _selectedList.Count;

            FooterPanel.Text = diff.ToString() + " result(s) discarded as they were Inheriting permissions or Non-Inheritable (eg: root site)";
        }

        private bool IsValid(SharePointObject o)
        {
            if (o.InternalObject is SPWeb)
                if ((o.InternalObject as SPWeb).IsRootWeb)
                    return false;

            return true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (Valid())
                if (Confirm())
                    Reset();
        }

        private bool Valid()
        {
            bool result = ItemsList.CheckedIndices.Count > 0;

            if (!result)
                SquadronContext.Warn("Please check atleast one item!" + Environment.NewLine + Environment.NewLine + "(You can right click & check/uncheck items)");

            return result;
        }

        private bool Confirm()
        {
            return SquadronContext.Confirm("Are you sure you want to Reset to Inherit?" + Environment.NewLine + Environment.NewLine + "Item(s): " + ItemsList.CheckedIndices.Count.ToString());
        }

        private PermissionUtility _permissionUtility = new PermissionUtility();

        private void Reset()
        {
            SquadronContext.StartMonitoringExceptions();

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                try
                {
                    int count = 0;
                    foreach (int i in ItemsList.CheckedIndices)
                        if (_permissionUtility.ResetToInherit(_selectedList[i].InternalObject as SPSecurableObject))
                            count++;

                    if (count < ItemsList.CheckedIndices.Count)
                        SquadronContext.Warn("Reset operation of some item(s) invoked errors. Please refresh & retry.");
                }
                catch (Exception ex)
                {
                    SquadronContext.HandleException(ex);
                }
                finally
                {
                    SquadronContext.StopMonitoringExceptions();
                    FooterPanel.Text = "Operation completed!";
                }
            });
        }
    }
}
