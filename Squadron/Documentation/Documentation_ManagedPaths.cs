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
        private IList<string> GridColumns_ManagedPaths = new List<string>(new string[] { "Name", "Type", "ParentWebApplication" });

        private void Refresh_ManagedPaths()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPServiceCollection services = SPFarm.Local.Services;

                GridPanel panel = new GridPanel();
                IList<SPManagedPathEntity> list = new List<SPManagedPathEntity>();

                foreach (SPService service in services)
                {
                    if (service is SPWebService)
                    {
                        SPWebService webservice = (SPWebService)service;

                        foreach (SPWebApplication webapp in webservice.WebApplications)
                            foreach (SPPrefix p in webapp.Prefixes)
                                list.Add(new SPManagedPathEntity(p) { ParentWebApplication = webapp.DisplayName });
                    }
                }

                panel.Title = "Managed Paths";
                panel.GridColumns = GridColumns_ManagedPaths;
                panel.GridDataSource = list;

                AddPanel(panel);
            });
        }
    }
}
