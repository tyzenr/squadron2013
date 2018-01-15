using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddins.Default.EmptyList
{
    public class ClearListAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Clear List"; }
        }

        public override string Description
        {
            get { return "Clears the specified List / Library by deleting all the items."; }
        }

        public override Type UserControlType
        {
            get { return typeof(ClearListControl); }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/?p=4189";
            }
        }

        public override int Order
        {
            get
            {
                return 111;
            }
        }
    }
}
