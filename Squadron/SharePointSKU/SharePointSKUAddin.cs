using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.SharePointSKU
{
    public class SharePointSKUAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "SharePoint SKU"; }
        }

        public override string Description
        {
            get { return "SharePoint SKU (Stock Keeping Unit) identifies the SharePoint 2010 Edition (Foundation, Standard, Enterprise) installed."; }
        }

        public override Type UserControlType
        {
            get { return typeof(SharePointSKUControl); }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/?p=4755";
            }
        }
    }
}
