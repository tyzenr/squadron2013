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
    public class SPWebApplicationEntity
    {
        private SPWebApplication _underlyingObject;

        public SPWebApplicationEntity(SPWebApplication wa)
        {
            _underlyingObject = wa;
        }

        public string Name
        {
            get
            {
                if (!string.IsNullOrEmpty(_underlyingObject.Name))
                    return _underlyingObject.Name;

                else
                    return _underlyingObject.DisplayName;
            }
        }

        public Uri OfficialFileUrl
        {
            get { return _underlyingObject.OfficialFileUrl; }
        }

        public string ParentService
        {
            get;
            set;
        }
    }
}
