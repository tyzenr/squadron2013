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
    public class SPServiceApplicationEntity
    {
        private SPServiceApplication _underlyingObject;

        public SPServiceApplicationEntity(SPServiceApplication s)
        {
            _underlyingObject = s;
        }

        public Guid Id
        {
            get { return _underlyingObject.Id; }
        }

        public string DisplayName
        {
            get { return _underlyingObject.DisplayName; }
        }

        public string TypeName
        {
            get { return _underlyingObject.TypeName; }
        }

        public string ServiceName
        {
            get { return _underlyingObject.Service.DisplayName; }
        }

        public long Version
        {
            get { return _underlyingObject.Version; }
        }

        public SPObjectStatus Status
        {
            get { return _underlyingObject.Status; }
        }
    }
}
