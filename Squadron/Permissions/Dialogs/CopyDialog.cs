using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using SquadronAddIns.Default.Utility;
using Squadron;
using System.Diagnostics;
using e = SquadronAddIns.Default.Utility.Entity;
using Squadron.Dialogs;

namespace SquadronAddIns.Default.Permissions.Dialogs
{
    public partial class CopyDialog : Windows8LookNFeel.Windows8Form
    {
        public CopyDialog()
        {
            InitializeComponent();
        }

        protected override void FormInit()
        {
            base.FormInit();

            if (Debugger.IsAttached)
            {
                SourceUserText.Text = "INZEON\\researchhead";
                DestUserText.Text = "INZEON\\newadmin";
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                SourcePermissions.CheckDisplayName = false;
                SourcePermissions.CheckGroupNames = true;
                SourcePermissions.ExactMatch = true;

                SourcePermissions.Refresh(SourceUserText.Text, SquadronContext.Url);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void Find2Button_Click(object sender, EventArgs e)
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                SourcePermissions.CheckDisplayName = false;
                SourcePermissions.CheckGroupNames = true;
                SourcePermissions.ExactMatch = true;

                DestinationPermissions.Refresh(DestUserText.Text, SquadronContext.Url);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valid())
                    if (Confirm())
                    {
                        SquadronHelper.Instance.StartAnimation();
                        Copy();
                    }
            }
            catch (Exception ex)
            {
                SquadronContext.Errr(ex.ToString());
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private bool Confirm()
        {
            return SquadronContext.Confirm("The selected " + SourcePermissions.GetSelectedPermissions().Count.ToString() + " permission(s) will be copied to following user: " + Environment.NewLine + DestUserText.Text + Environment.NewLine + Environment.NewLine + "Are you sure you want to continue?");
        }

        private bool Valid()
        {
            if (SourcePermissions.GetSelectedPermissions().Count == 0)
            {
                SquadronContext.Warn("Please select atleast one permission to copy!");
                return false;
            }

            return true;
        }

        private PermissionUtility _permissionUtility = new PermissionUtility();

        private void Copy()
        {
            var permissions = SourcePermissions.GetSelectedPermissions();

            _permissionUtility.SetPermissions(DestUserText.Text, permissions);

            FooterPanel.Text = "Copy operation completed!";

            if (_permissionUtility.SkippedPermissions)
                SquadronContext.Warn(FooterPanel.Text + Environment.NewLine + Environment.NewLine + "('Limited Access' permissions were skipped!)");
        }

        private void userPicture1_Click(object sender, EventArgs e)
        {
            UserDialog dialog = new UserDialog();
            if (dialog.ExecuteDialog(SourceUserText.Text, SquadronContext.Url))
                SourceUserText.Text = dialog.SelectedUser.LoginName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserDialog dialog = new UserDialog();
            if (dialog.ExecuteDialog(DestUserText.Text, SquadronContext.Url))
                DestUserText.Text = dialog.SelectedUser.LoginName;
        }
    }
}
