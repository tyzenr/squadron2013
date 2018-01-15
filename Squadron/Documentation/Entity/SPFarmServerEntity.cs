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
    public class SPFarmServerEntity
    {
        private SPServer _underlyingObject;

        public SPFarmServerEntity(SPServer server)
        {
            _underlyingObject = server;
        }

        public string Name
        {
            get { return _underlyingObject.Name; }
        }

        public SPServerRole Role
        {
            get { return _underlyingObject.Role; }
        }

        public string Address
        {
            get { return _underlyingObject.Address; }
        }

        public SPObjectStatus Status
        {
            get { return _underlyingObject.Status; }
        }
    }
}
