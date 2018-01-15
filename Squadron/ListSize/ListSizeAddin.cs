using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddins.Default.SiteSize
{
    public class ListSizeAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "List Size"; }
        }

        public override string Description
        {
            get { return "Returns the List / Library starting with input URL.  (FASTER results as the content database records are fetched through API)"; }
        }

        public override Type UserControlType
        {
            get { return typeof(SiteSizeControl); }
        }

        public override string Group
        {
            get
            {
                return "Site";
            }
        }

        public override int Order
        {
            get
            {
                return 101;
            }
        }

        public override bool IsEnabled
        {
            get
            {
                return false;
            }
        }
    }
}
