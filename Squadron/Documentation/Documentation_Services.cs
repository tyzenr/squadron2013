using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SquadronAddIns.Default.Documentation.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Default.Documentation
{
    partial class DocumentationControl
    {
        private IList<string> GridColumns_Services = new List<string>(new string[] { "Id", "DisplayName", "TypeName", "Status" });

        private void Refresh_Services()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                GridPanel panel = new GridPanel();
                IList<SPServiceEntity> list = new List<SPServiceEntity>();

                foreach (SPService s in SPFarm.Local.Services)
                    list.Add(new SPServiceEntity(s));

                panel.Title = "Services";
                panel.GridColumns = GridColumns_Services;
                panel.GridDataSource = list;

                AddPanel(panel);
            });
        }
    }
}
