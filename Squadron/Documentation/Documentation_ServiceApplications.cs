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
        private IList<string> GridColumns_ServiceApplications = new List<string>(new string[] { "Id", "DisplayName", "TypeName", "ServiceName", "Version", "Status" });

        private void Refresh_ServiceApplications()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                GridPanel panel = new GridPanel();
                IList<SPServiceApplicationEntity> list = new List<SPServiceApplicationEntity>();

                foreach (SPService s in SPFarm.Local.Services)
                    foreach (SPServiceApplication sa in s.Applications)
                        list.Add(new SPServiceApplicationEntity(sa));

                panel.Title = "Service Applications";
                panel.GridColumns = GridColumns_ServiceApplications;
                panel.GridDataSource = list;

                AddPanel(panel);
            });
        }
    }
}
