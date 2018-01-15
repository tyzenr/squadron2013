using Hx.General;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Squadron;
using SquadronAddIns.Default.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Default.Documentation
{
    public class SPSiteEntity
    {
        private SPSite _underlyingObject;

        public SPSiteEntity(SPSite site)
        {
            _underlyingObject = site;
        }

        public string HostName
        {
            get { return _underlyingObject.HostName; }
        }

        private SharePointUtility _utility = new SharePointUtility();

        public string Url
        {
            get { return _utility.GetUrl(_underlyingObject); }
        }

        public DateTime LastContentModifiedDate
        {
            get { return _underlyingObject.LastContentModifiedDate; }
        }

        public string Size
        {
            get { return GeneralUtils.GetSizeInGB(_underlyingObject.Usage.Storage); }
        }

        public string Database
        {
            get { return _underlyingObject.ContentDatabase.DisplayName; }
        }
    }
}
