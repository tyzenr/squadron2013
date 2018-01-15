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
        private IList<string> GridColumns_ContentDatabases = new List<string>(new string[] { "Name", "Server", "WebApplication", "CurrentSiteCount", "WarningSiteCount" });

        private void Refresh_ContentDatabases()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPServiceCollection services = SPFarm.Local.Services;

                GridPanel panel = new GridPanel();
                IList<SPContentDatabaseEntity> list = new List<SPContentDatabaseEntity>();

                foreach (SPService service in services)
                {
                    if (service is SPWebService)
                    {
                        SPWebService webservice = (SPWebService)service;

                        foreach (SPWebApplication webapp in webservice.WebApplications)
                            foreach (SPContentDatabase cd in webapp.ContentDatabases)
                                list.Add(new SPContentDatabaseEntity(cd));
                    }
                }

                panel.Title = "Content Databases";
                panel.GridColumns = GridColumns_ContentDatabases;
                panel.GridDataSource = list;

                AddPanel(panel);
            });
        }
    }
}
