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
        private IList<string> GridColumns_SiteCollections = new List<string>(new string[] { "HostName", "Url", "LastContentModifiedDate", "Size", "Database" });

        private void Refresh_SiteCollections()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPServiceCollection services = SPFarm.Local.Services;

                foreach (SPService service in services)
                {
                    if (service is SPWebService)
                    {
                        SPWebService webservice = (SPWebService)service;

                        foreach (SPWebApplication webapp in webservice.WebApplications)
                        {
                            GridPanel panel = new GridPanel();
                            IList<SPSiteEntity> list = new List<SPSiteEntity>();

                            foreach (SPSite sitec in webapp.Sites)
                                list.Add(new SPSiteEntity(sitec));

                            panel.Title = "Site Collections under Web Application " + webapp.Name;
                            panel.GridColumns = GridColumns_SiteCollections;
                            panel.GridDataSource = list;

                            AddPanel(panel);
                        }
                    }
                }
            });
        }
    }
}
