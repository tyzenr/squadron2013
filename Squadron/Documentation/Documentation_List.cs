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
        private IList<string> GridColumns_Lists = new List<string>(new string[] { "Title", "Url", "Created", "LastItemModifiedDate", "ParentUrl" });

        private void Refresh_Lists()
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
                                foreach (SPWeb web in sitec.AllWebs)
                                {
                                    GridPanel panel = new GridPanel();
                                    IList<SPListEntity> list = new List<SPListEntity>();

                                    foreach (SPList l in web.Lists)
                                        list.Add(new SPListEntity(l));

                                    panel.Title = "Lists under Site " + web.Title + " (" + web.Url + ")";
                                    panel.GridColumns = GridColumns_Lists;
                                    panel.GridDataSource = list;

                                    AddPanel(panel);
                                }
                    }
                }
            });
        }
    }
}
