using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddins.Default.WFTerminator
{
    public class WFTerminatorAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Workflow Terminator"; }
        }

        public override string Description
        {
            get { return "Locate and Terminate a running / paused / problem causing workflow."; }
        }

        public override Type UserControlType
        {
            get { return typeof(WFTerminatorControl); }
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
                return "http://www.jeanpaulva.com/?p=4085";
            }
        }
    }
}
