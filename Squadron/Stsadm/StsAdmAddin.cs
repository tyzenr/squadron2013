using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddins.Default.Stsadm
{
    public class StsAdmAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Stsadm"; }
        }

        public override string Description
        {
            get { return "STSADM command execution integration."; }
        }

        public override Type UserControlType
        {
            get { return typeof(StsadmControl); }
        }

        public override string AuthorInfo
        {
            get
            {
                return "www.jeanpaulva.com";
            }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/?p=4093";
            }
        }
    }
}
