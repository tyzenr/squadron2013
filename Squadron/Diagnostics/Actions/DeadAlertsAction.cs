using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows8LookNFeel;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Utility;
using Squadron;
using Squadron.Widgets;

namespace SquadronAddIns.Default.Diagnostics.Actions
{
    public class DeadAlertsAction : ActionControl.Action
    {
        public override string Name
        {
            get
            {
                return "Dead Alerts";
            }
        }

        public override string Description
        {
            get
            {
                return "Find Alerts for Disabled Users.";
            }
        }

        private ActiveDirectoryUtility _adutility = new ActiveDirectoryUtility();

        protected override bool InternalExecute()
        {
            var validUsers = _adutility.GetActiveUsers(SquadronContext.DomainName);

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                foreach (SPWeb web in this.SharePointObjects.OfType<SPWeb>())
                    foreach (SPAlert alert in web.Alerts)
                    {
                        if (alert.User != null)
                            if (!string.IsNullOrEmpty(alert.User.LoginName))
                                if (!validUsers.Any(u => (Helper.Instance.GetDomainName().ToLower() + "\\" + u.LoginName.ToLower()) == alert.User.LoginName.ToLower()))
                                    DetailsList.Add(new DeadAlertEntity()
                                        {
                                            DeadAccount = alert.User.LoginName + " (" + alert.User.Name + ")",
                                            AlertTitle = alert.Title,
                                            AlertOn = GetAlertInfo(alert)
                                        });
                    }
            });

            return DisplayResult(DetailsList.Count == 0);
        }

        private SharePointUtility _utility = new SharePointUtility();

        private string GetAlertInfo(SPAlert alert)
        {
            if (alert.List != null)
                return _utility.GetDisplayName(alert.List, true);

            if (alert.Item != null)
                return _utility.GetDisplayName(alert.Item, true);

            return string.Empty;
        }

        public class DeadAlertEntity
        {
            public string DeadAccount
            {
                get;
                set;
            }

            public string AlertTitle
            {
                get;
                set;
            }

            public string AlertOn
            {
                get;
                set;
            }
        }
    }
}
