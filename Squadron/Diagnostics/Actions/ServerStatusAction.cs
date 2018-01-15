using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows8LookNFeel;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Utility;
using System.ComponentModel;
using Squadron;
using Microsoft.SharePoint.Administration;
using Squadron.Widgets;

namespace SquadronAddIns.Default.Diagnostics.Actions
{
    public class ServerStatusAction : ActionControl.Action
    {
        public override string Name
        {
            get
            {
                return "Server Status";
            }
        }

        public override string Description
        {
            get
            {
                return "Find Server Status.";
            }
        }

        private SharePointUtility _utility = new SharePointUtility();

        protected override bool InternalExecute()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPFarm farm = SPFarm.Local;
                foreach (SPServer server in farm.Servers)
                {
                    SquadronContext.WriteMessage(server.Name + " " + server.Role + " " + server.TypeName);
                }
            });
            
            return DisplayResult(DetailsList.Count == 0);
        }
    }
}
