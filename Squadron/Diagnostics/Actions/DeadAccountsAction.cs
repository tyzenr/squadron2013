using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows8LookNFeel;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Utility;
using e = SquadronAddIns.Default.Utility.Entity;
using SquadronAddIns.Default.Utility.Entity;
using System.ComponentModel;
using Squadron.Widgets;

namespace SquadronAddIns.Default.Diagnostics.Actions
{
    public class DeadAccountsAction : ActionControl.Action
    {
        public override string Name
        {
            get
            {
                return "Dead Accounts";
            }
        }

        public override string Description
        {
            get
            {
                return "Find Disabled Users in permissions.";
            }
        }

        private PermissionUtility _utility = new PermissionUtility();
        private ActiveDirectoryUtility _adUtility = new ActiveDirectoryUtility();

        protected override bool InternalExecute()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                var securableObjects = this.SharePointObjects.OfType<SPSecurableObject>().ToList();
                var deadAccounts = _adUtility.GetDeadAccounts();

                foreach (ADEntity entity in deadAccounts)
                {
                    IList<e.Permission> foundPermissions = _utility.GetPermissions(entity.LoginName, securableObjects);

                    foreach (e.Permission p in foundPermissions)
                        DetailsList.Add(new DeadAccountEntity(p));
                }
            });

            return DisplayResult(DetailsList.Count == 0);
        }

        public class DeadAccountEntity
        {
            public DeadAccountEntity(e.Permission p)
            {
                this.DeadAccount = p.LoginName;
                this.Object = p.SecurableObjectFx;
                this.Group = p.Group;
                this.PermissionLevels = p.PermissionLevels;
            }

            public string DeadAccount
            {
                get;
                set;
            }

            [DisplayName("In use @")]
            public string Object
            {
                get;
                set;
            }

            public string Group
            {
                get;
                set;
            }

            public string PermissionLevels
            {
                get;
                set;
            }
        }
    }
}
