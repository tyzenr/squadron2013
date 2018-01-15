using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SquadronAddIns.Default.SizeInfo
{
    public class SizeAddin : Squadron.SquadronAddin
    {
        public override string Name
        {
            get { return "Size"; }
        }

        public override string Description
        {
            get { return "View Size of site collection, sub sites, lists, library."; }
        }

        public override Type UserControlType
        {
            get { return typeof(SizeControl); }
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
                return 102;
            }
        }
    }
}
