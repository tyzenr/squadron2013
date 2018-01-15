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
        private IList<string> GridColumns_Sites = new List<string>(new string[] { "Title", "Url", "Created", "WebTemplate", "ParentUrl" });

        private void Refresh_Sites()
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
                            foreach (SPSite sitec in webapp.Sites)
                            {
                                GridPanel panel = new GridPanel();
                                IList<SPWebEntity> list = new List<SPWebEntity>();

                                foreach (SPWeb web in sitec.AllWebs)
                                    list.Add(new SPWebEntity(web));

                                panel.Title = "Sites under Site Collection " + sitec.HostName + " (" + sitec.Url + ")";
                                panel.GridColumns = GridColumns_Sites;
                                panel.GridDataSource = list;

                                AddPanel(panel);
                            }
                    }
                }
            });
        }
    }
}
