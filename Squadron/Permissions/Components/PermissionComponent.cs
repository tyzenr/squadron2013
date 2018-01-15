using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SquadronAddIns.Default.Utility;
using Squadron.Common;
using e = SquadronAddIns.Default.Utility.Entity;
using Squadron;
using Squadron.Components;

namespace SquadronAddIns.Default.Permissions.Components
{
    public partial class PermissionComponent : UserControl
    {
        private PermissionUtility _permissionUtility = new PermissionUtility();

        public PermissionComponent()
        {
            InitializeComponent();
        }

        private IList<e.Permission> _list;

        public bool ExactMatch = true, CheckGroupNames = true, CheckDisplayName = false;

        public int Refresh(string loginName, string url)
        {
            _list = _permissionUtility.GetPermissions(loginName, url, ScopeEnum.WebApplication, ExactMatch, CheckGroupNames, CheckDisplayName);
            box.Items.Clear();

            foreach (e.Permission p in _list)
                box.Items.Add(p);

            Helper.Instance.CheckAll(box);

            FooterPanel.Text = _list.Count.ToString() + " permission(s) found.";

            return _list.Count;
        }

        public IList<e.Permission> GetSelectedPermissions()
        {
            IList<e.Permission> result = new List<e.Permission>();

            foreach (int i in box.CheckedIndices)
                result.Add(_list[i]);

            return result;
        }
    }
}
