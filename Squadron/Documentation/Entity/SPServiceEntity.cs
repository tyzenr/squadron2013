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
    public class SPServiceEntity
    {
        private SPService _underlyingObject;

        public SPServiceEntity(SPService s)
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

        public SPObjectStatus Status
        {
            get { return _underlyingObject.Status; }
        }
    }
}
