using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.Explorer
{
    public class ExplorerAddIn : SquadronAddin
    {
        public override string Name
        {
            get { return "Explorer"; }
        }

        public override string Description
        {
            get { return "View Site Structure, Perform common tasks."; }
        }

        public override Type UserControlType
        {
            get { return typeof(ExplorerControl); }
        }

        public override int Order
        {
            get
            {
                return 10;
            }
        }

        public override void OnChange()
        {
            if (UserControlInstance != null)
                (UserControlInstance as ExplorerControl).RefreshData();
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/?p=4752";
            }
        }
    }
}
