using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.Solutions
{
    public class SolutionsAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Solutions"; }
        }

        public override string Description
        {
            get { return "View, Add, Install, Remove SharePoint Solutions."; }
        }

        public override Type UserControlType
        {
            get { return typeof(SolutionsControl); }
        }
    }
}
