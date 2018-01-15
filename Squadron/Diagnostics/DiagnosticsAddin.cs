using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.Diagnostics
{
    public class DiagnosticsAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Diagnostics"; }
        }

        public override string Description
        {
            get { return "Checks for Issues regarding SharePoint Server Health, Governance."; }
        }

        public override Type UserControlType
        {
            get { return typeof (DiagnosticsControl); }
        }

        public override int Order
        {
            get
            {
                return 1200;
            }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/?p=5079";
            }
        }
    }
}
