using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddins.Infra
{
    public class SystemAddIn : SquadronAddin
    {
        public override string Name
        {
            get { return "System"; }
        }

        public override string Description
        {
            get { return "View System, Process information"; }
        }

        public override Type UserControlType
        {
            get { return typeof(SystemControl); }
        }

        public override int Order
        {
            get
            {
                return 1198;
            }
        }

        public override void OnChange()
        {
            if (UserControlInstance != null)
                (UserControlInstance as SystemControl).RefreshData();
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/index.php/2013/06/30/squadron-new-addin-added-file-lock-finder/";
            }
        }
    }
}
