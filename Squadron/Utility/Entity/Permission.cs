using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.Utility;
using System.ComponentModel;
using Microsoft.SharePoint;

namespace SquadronAddIns.Default.Utility.Entity
{
    public class Permission
    {
        private SharePointUtility _utility = new SharePointUtility();

        [Browsable(false)]
        public SPSecurableObject SecurableObject
        {
            get;
            set;
        }

        [DisplayName("Object")]
        public string SecurableObjectFx
        {
            get
            {
                if (SecurableObject != null)
                {
                    return _utility.GetDisplayName(SecurableObject, true);
                }

                return string.Empty;
            }
        }

        [DisplayName("Levels")]
        public string PermissionLevels
        {
            get;
            set;
        }

        [Browsable(false)]
        public SPGroup SharePointGroup
        {
            get;
            set;
        }

        [Browsable(false)]
        public string LoginName
        {
            get;
            set;
        }

        [Browsable(false)]
        public string DisplayName
        {
            get;
            set;
        }

        public string Group
        {
            get
            {
                if (SharePointGroup == null)
                    return "(Direct)";

                else
                    return SharePointGroup.Name;
            }
        }

        public override string ToString()
        {
            return SecurableObjectFx + " " + SharePointGroup + " [" + PermissionLevels + "]";
        }
    }
}
