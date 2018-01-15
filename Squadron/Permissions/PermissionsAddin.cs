using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.Permission
{
    public class PermissionsAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Permissions"; }
        }

        public override string Description
        {
            get { return "View permissions, groups, unique permissions for SharePoint securable objects."; }
        }

        public override Type UserControlType
        {
            get { return typeof(PermissionsControl); }
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
                return 1;
            }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/?p=4874";
            }
        }
    }
}
