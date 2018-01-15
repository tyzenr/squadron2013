using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SquadronAddIns.Default.Permissions.Entity
{
    public class PermissionInfo
    {
        public string Title
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public string InheritUrl
        {
            get;
            set;
        }

        public string PermissionType
        {
            get;
            set;
        }

        public string RoleAssignments
        {
            get;
            set;
        }

        public string RoleType
        {
            get;
            set;
        }

        public string Owner
        {
            get;
            set;
        }

        public string UsersInGroup
        {
            get;
            set;
        }

        public string PermissionLevels
        {
            get;
            set;
        }

        [Browsable(false)]
        public object InternalObject
        {
            get;
            set;
        }
    }
}
