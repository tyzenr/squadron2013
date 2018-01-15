using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint;

namespace SquadronAddIns.Default.Utility.Entity
{
    public class SharePointObject
    {
        private SharePointUtility _utility = new SharePointUtility();

        public object InternalObject
        {
            get;
            set;
        }

        public override string ToString()
        {
            return _utility.GetDisplayName(InternalObject);
        }
    }
}
