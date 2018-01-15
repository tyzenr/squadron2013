using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SquadronAddIns.Default.Documentation.Controls;
using SquadronAddIns.Default.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Default.Documentation
{
    partial class DocumentationControl
    {
        private SharePointUtility _utility = new SharePointUtility();

        private IList<string> GridColumns_UserSolutions = new List<string>(new string[] { "SolutionId", "Name", "Status", "DeployedSiteCollectionUrl" });

        private void Refresh_UserSolutions()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPServiceCollection services = SPFarm.Local.Services;
                GridPanel panel = new GridPanel();
                IList<SPUserSolutionEntity> list = new List<SPUserSolutionEntity>();

                foreach (SPService service in services)
                {
                    if (service is SPWebService)
                    {
                        SPWebService webservice = (SPWebService)service;

                        foreach (SPWebApplication webapp in webservice.WebApplications)
                            foreach (SPSite sitec in webapp.Sites)
                                foreach (SPUserSolution s in sitec.Solutions)
                                    list.Add(new SPUserSolutionEntity(s) { DeployedSiteCollectionUrl = _utility.GetUrl(sitec) });
                    }
                }

                panel.Title = "User Solutions";
                panel.GridColumns = GridColumns_UserSolutions;
                panel.GridDataSource = list;

                AddPanel(panel);
            });
        }
    }
}
