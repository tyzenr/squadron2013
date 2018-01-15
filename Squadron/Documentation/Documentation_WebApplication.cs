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
        private IList<string> GridColumns_WebApplications = new List<string>(new string[] { "Name", "OfficialFileUrl", "ParentService" });

        private void Refresh_WebApplications()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPServiceCollection services = SPFarm.Local.Services;

                GridPanel panel = new GridPanel();
                IList<SPWebApplicationEntity> list = new List<SPWebApplicationEntity>();

                foreach (SPService service in services)
                {
                    if (service is SPWebService)
                    {
                        SPWebService webservice = (SPWebService)service;

                        foreach (SPWebApplication webapp in webservice.WebApplications)
                            list.Add(new SPWebApplicationEntity(webapp) { ParentService = webservice.DisplayName });
                    }
                }

                panel.Title = "Web Applications";
                panel.GridColumns = GridColumns_WebApplications;
                panel.GridDataSource = list;

                AddPanel(panel);
            });
        }
    }
}
