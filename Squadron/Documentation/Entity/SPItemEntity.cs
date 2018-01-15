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
    public class SPItemEntity
    {
        private SPListItem _underlyingObject;

        public SPItemEntity(SPListItem item)
        {
            _underlyingObject = item;
        }

        public int Id
        {
            get { return _underlyingObject.ID; }
        }

        public string DisplayName
        {
            get { return _underlyingObject.DisplayName; }
        }

        private SharePointUtility _utility = new SharePointUtility();

        public string Url
        {
            get { return _utility.GetUrl(_underlyingObject); }
        }
        public string ContentType
        {
            get { try { return _underlyingObject.ContentType.Name; } catch (Exception ex) { return "(exception)"; } }
        }

        public string ParentUrl
        {
            get { return SPUtility.GetFullUrl(_underlyingObject.ParentList.ParentWeb.Site, _underlyingObject.ParentList.DefaultViewUrl); }
        }

        public int Versions
        {
            get { return _underlyingObject.Versions.Count; }
        }
    }
}
