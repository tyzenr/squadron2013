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
    public class SPListEntity
    {
        private SPList _underlyingObject;

        public SPListEntity(SPList list)
        {
            _underlyingObject = list;
        }

        public string Title
        {
            get { return _underlyingObject.Title; }
        }

        private SharePointUtility _utility = new SharePointUtility();

        public string Url
        {
            get { return _utility.GetUrl(_underlyingObject); }
        }

        public DateTime Created
        {
            get { return _underlyingObject.Created; }
        }

        public string ParentUrl
        {
            get { return _utility.GetUrl(_underlyingObject.ParentWeb); }
        }

        public DateTime LastItemModifiedDate
        {
            get { return _underlyingObject.LastItemModifiedDate; }
        }
    }
}
