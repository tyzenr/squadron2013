using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Squadron;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using SquadronAddIns.Default.Utility;
using SquadronAddIns.Default.Utility.Entity;

namespace SquadronAddIns.Default.PermissionGroupsAD
{
    public partial class ActiveDirectoryControl : UserControl
    {
        public ActiveDirectoryControl()
        {
            InitializeComponent();

            grid.CellClick += grid_CellClick;
        }

        private ActiveDirectoryUtility _adHelper = new ActiveDirectoryUtility();
        private IList<ADEntity> _result;

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            SquadronContext.WriteMessage("Using " + SquadronContext.DomainName + " ...");
            _result = _adHelper.GetAll(SquadronContext.DomainName, true, true, true).ToList();

            CheckHighlight();
            grid.DataSource = _result;

            Helper.Instance.ResizeRowsToFit(grid);
            pgrid.Visible = true;
        }

        private void CheckHighlight()
        {
            grid.BoldRows.Clear();
            grid.RedRows.Clear();

            int ix = 0;
            if(HighlightCheck.Checked)
                foreach (ADEntity entity in _result)
                {
                    if (!entity.IsEnabled)
                    {
                        grid.BoldRows.Add(ix);
                        grid.RedRows.Add(ix);
                    }

                    ix++;
                }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.DataSource != null)
                if (e.RowIndex > 0)
                    pgrid.SelectedObject = (grid.Rows[e.RowIndex].DataBoundItem as ADEntity).InternalObject;
        }
    }
}

