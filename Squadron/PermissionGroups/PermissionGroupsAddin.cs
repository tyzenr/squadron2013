using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.PermissionGroups
{
    public class PermissionGroupsAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Permission Groups"; }
        }

        public override string Description
        {
            get { return "Retrieves all SharePoint Groups.  The report is useful in analyzing the Site Collection, Sub Sites as a whole.  \n\n(For Active Directory groups, please use the Active Directory Addin)"; }
        }

        public override Type UserControlType
        {
            get { return typeof(PermissionGroupsControl); }
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
                return 2;
            }
        }

        public override bool IsEnabled
        {
            get
            {
                return false;
            }
        }
    }
}
