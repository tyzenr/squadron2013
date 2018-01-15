using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint;

namespace SquadronAddIns.Default.Farm
{
    public partial class FarmControl : UserControl
    {
        public FarmControl()
        {
            InitializeComponent();

            grid.CellClick += grid_CellClick;
        }
        
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.DataSource != null)
                if (e.RowIndex > 0)
                    pgrid.SelectedObject = (grid.Rows[e.RowIndex].DataBoundItem as FarmEntity).InternalObject;
        }

        public void RefreshData()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPFarm farm = SPFarm.Local;
                    var result = new List<FarmEntity>();

                    foreach (SPServer server in farm.Servers)
                    {
                        result.Add(new FarmEntity() { ServerName = server.Name, Type = server.Role + " " + server.TypeName, InternalObject = server });
                    }

                    grid.DataSource = result;
                });
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }

    public class FarmEntity
    {
        [DisplayName("Server")]
        public string ServerName
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        [Browsable(false)]
        public object InternalObject
        {
            get;
            set;
        }
    }
}
