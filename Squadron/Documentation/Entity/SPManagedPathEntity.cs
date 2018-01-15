using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Utilities;
using Squadron;
using SquadronAddIns.Default.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Default.Documentation
{
    public class SPManagedPathEntity
    {
        private SPPrefix _underlyingObject;

        public SPManagedPathEntity(SPPrefix prefix)
        {
            _underlyingObject = prefix;
        }

        public string Name
        {
            get { return _underlyingObject.Name; }
        }

        public SPPrefixType Type
        {
            get { return _underlyingObject.PrefixType; }
        }

        public string ParentWebApplication
        {
            get;
            set;
        }
    }
}
