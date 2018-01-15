using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.PermissionGroupsAD
{
    public class ActiveDirectoryAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Active Directory"; }
        }

        public override string Description
        {
            get { return "Reports all Active Directory Groups, Users."; }
        }

        public override Type UserControlType
        {
            get { return typeof(ActiveDirectoryControl); }
        }

        public override string Group
        {
            get
            {
                return "Permissions";
            }
        }

        public override int GroupOrder
        {
            get
            {
                return 3;
            }
        }
    }
}
