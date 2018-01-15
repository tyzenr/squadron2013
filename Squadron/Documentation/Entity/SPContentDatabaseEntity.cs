using Hx.General;
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
    public class SPContentDatabaseEntity
    {
        private SPContentDatabase _underlyingObject;

        public SPContentDatabaseEntity(SPContentDatabase cd)
        {
            _underlyingObject = cd;
        }

        public string Name
        {
            get { return _underlyingObject.Name; }
        }

        public string Server
        {
            get { return _underlyingObject.Server; }
        }

        public string WebApplication
        {
            get 
            { 
                if (!string.IsNullOrEmpty(_underlyingObject.WebApplication.Name))
                    return _underlyingObject.WebApplication.Name;

                else
                    return _underlyingObject.WebApplication.DisplayName; 
            }
        }

        public int CurrentSiteCount
        {
            get { return _underlyingObject.CurrentSiteCount; }
        }

        public int WarningSiteCount
        {
            get { return _underlyingObject.WarningSiteCount; }
        }
    }
}
