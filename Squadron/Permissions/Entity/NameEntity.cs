using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.Utility;
using Microsoft.SharePoint;

namespace SquadronAddIns.Default.Permissions.Entity
{
    public class NameEntity
    {
        public SPPrincipal Principal;
        public SecurableObject SecurableObject;

        public string Name;
        public string ContainerSPGroup;

        public override string ToString()
        {
            string g = string.Empty;
            if (!string.IsNullOrEmpty(ContainerSPGroup))
                g = "[" + ContainerSPGroup + "] > ";

            return g + this.Name + "  @  " + this.SecurableObject.ToShortString();
        }

        public bool Deleted;
    }
}
