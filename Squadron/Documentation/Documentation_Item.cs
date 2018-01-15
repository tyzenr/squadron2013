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
        private IList<string> GridColumns_Items = new List<string>(new string[] { "Id", "DisplayName", "Url", "Versions", "ContentType", "ParentUrl" });

        private void Refresh_Items()
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
                                    foreach (SPList l in web.Lists)
                                    {
                                        GridPanel panel = new GridPanel();
                                        IList<SPItemEntity> list = new List<SPItemEntity>();

                                        foreach (SPListItem item in l.Items)
                                            list.Add(new SPItemEntity(item));

                                        panel.Title = "Items under " + GetListOrLibrary(l) + " " + l.Title + " (" + _utility.GetUrl(l) + ")";
                                        panel.GridColumns = GridColumns_Items;
                                        panel.GridDataSource = list;

                                        AddPanel(panel);
                                    }
                    }
                }
            });
        }

        private string GetListOrLibrary(SPList l)
        {
            if (l is SPDocumentLibrary)
                return "Library";

            return "List";
        }
    }
}
