using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.QuickTest
{
    public class QuickTestAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Quick Test"; }
        }

        public override string Description
        {
            get { return "Perform a Quick Test against your SharePoint site.  Test include Average Response Time, Upload Time, Database Size, Search Speed."; }
        }

        public override Type UserControlType
        {
            get { return typeof(QuickTestControl); }
        }

        public override bool IsEnabled
        {
            get
            {
                return true;
            }
        }

        public override int Order
        {
            get
            {
                return 1195;
            }
        }
    }
}
