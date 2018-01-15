using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.Farm
{
    public class FarmAddIn : SquadronAddin
    {
        public override string Name
        {
            get { return "Farm"; }
        }

        public override string Description
        {
            get { return "View Farm Information."; }
        }

        public override Type UserControlType
        {
            get { return typeof(FarmControl); }
        }

        public override int Order
        {
            get
            {
                return 5;
            }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/index.php/2013/06/27/sharepoint-2010-how-to-get-farm-servers-through-code/";
            }
        }
    }
}
