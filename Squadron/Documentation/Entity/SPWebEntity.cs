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
    public class SPWebEntity
    {
        private SPWeb _underlyingObject;

        public SPWebEntity(SPWeb web)
        {
            _underlyingObject = web;
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

        public int WebTemplate
        {
            get { return _underlyingObject.WebTemplateId; }
        }

        public string ParentUrl
        {
            get
            {
                if (_underlyingObject.ParentWeb != null)
                    return _utility.GetUrl(_underlyingObject.ParentWeb);

                return "(none)";
            }
        }
    }
}
