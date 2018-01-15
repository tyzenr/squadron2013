using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using Squadron.Dialogs;
using Squadron;
using SquadronAddIns.Default.Utility;
using e = SquadronAddIns.Default.Utility.Entity;

namespace SquadronAddIns.Default.Permissions.Dialogs
{
    public partial class FindDialog : Windows8LookNFeel.Windows8Form
    {
        public FindDialog()
        {
            InitializeComponent();
        }

        protected override void FormInit()
        {
            base.FormInit();

            UrlText.Text = SquadronContext.Url;

            if (scope.SelectedIndex == -1)
                if (scope.Items.Count > 0)
                    scope.SelectedIndex = 0;
        }

        private void userPicture1_Click(object sender, EventArgs e)
        {
            UserDialog dialog = new UserDialog();
            if (dialog.ExecuteDialog(NameText.Text, UrlText.Text))
                NameText.Text = dialog.SelectedUser.LoginName;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                PerformFind();
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private SecurableObjectEnumerator _securableObjectEnumerator = new SecurableObjectEnumerator();
        private PermissionUtility _permissionUtility = new PermissionUtility();

        private void PerformFind()
        {
            var list = _permissionUtility.GetPermissions(NameText.Text, UrlText.Text, scope.Scope, false, true, true);

            var ourList = GetConvertedList(list);
            grid.DataSource = ourList;
        }

        private object GetConvertedList(IList<e.Permission> list)
        {
            IList<PermissionFound> result = new List<PermissionFound>();

            foreach (e.Permission p in list)
                result.Add(
                    new PermissionFound() 
                    { 
                        Type = Helper.Instance.GetType(p.SecurableObject), 
                        Url = Helper.Instance.GetUrl(p.SecurableObject),
                        LoginName = p.LoginName,
                        DisplayName = p.DisplayName,
                        Group = p.Group,
                        PermissionLevels = p.PermissionLevels
                    });

            return result;
        }

        class PermissionFound
        {
            public string DisplayName
            {
                get;
                set;
            }

            public string LoginName
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }

            public string Url
            {
                get;
                set;
            }

            public string Group
            {
                get;
                set;
            }

            public string PermissionLevels
            {
                get;
                set;
            }
        }

        private void FindDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindButton.PerformClick();
        }
    }
}
