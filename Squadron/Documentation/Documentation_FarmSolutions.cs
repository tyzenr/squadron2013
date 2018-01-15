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
        private IList<string> GridColumns_FarmSolutions = new List<string>(new string[] { "Id", "Name", "Status", "DeployedWebApplications" });

        private void Refresh_FarmSolutions()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                GridPanel panel = new GridPanel();
                IList<SPFarmSolutionEntity> list = new List<SPFarmSolutionEntity>();

                foreach (SPSolution s in SPFarm.Local.Solutions)
                    list.Add(new SPFarmSolutionEntity(s));

                panel.Title = "Farm Solutions";
                panel.GridColumns = GridColumns_FarmSolutions;
                panel.GridDataSource = list;

                AddPanel(panel);
            });
        }
    }
}
