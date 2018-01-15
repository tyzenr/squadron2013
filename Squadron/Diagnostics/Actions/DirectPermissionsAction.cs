using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows8LookNFeel;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Utility;
using System.ComponentModel;
using Squadron;
using Squadron.Widgets;

namespace SquadronAddIns.Default.Diagnostics.Actions
{
    public class DirectPermissionsAction : ActionControl.Action
    {
        public override string Name
        {
            get
            {
                return "Direct Permissions";
            }
        }

        public override string Description
        {
            get
            {
                return "Find Direct User permissions for web/list/items.";
            }
        }

        private SharePointUtility _utility = new SharePointUtility();

        protected override bool InternalExecute()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                foreach (object o in this.SharePointObjects.OfType<SPSecurableObject>())
                {
                    try
                    {
                        SPSecurableObject so = o as SPSecurableObject;

                        if (so.HasUniqueRoleAssignments)
                            foreach (SPRoleAssignment ra in so.RoleAssignments)
                                if (ra.Member is SPUser)
                                {
                                    DetailsList.Add(new DirectPermissionEntity()
                                    {
                                        User = ra.Member.LoginName,
                                        Title = _utility.GetDisplayName(o, false),
                                        Url = _utility.GetUrl(o)
                                    });
                                }
                    }
                    catch (Exception ex)
                    {
                        SquadronContext.HandleException(o, ex);
                    }
                }
            });
            
            return DisplayResult(DetailsList.Count == 0);
        }

        public class DirectPermissionEntity
        {
            public string User
            {
                get;
                set;
            }

            [DisplayName("Direct Permission @")]
            public string Title
            {
                get;
                set;
            }

            public string Url
            {
                get;
                set;
            }
        }
    }
}
