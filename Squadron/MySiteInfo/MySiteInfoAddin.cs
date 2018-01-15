using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddins.Default.MySiteInfo
{
    public class MySiteInfoAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "My Site"; }
        }

        public override string Description
        {
            get { return "Returns My Site Url, Size etc. for the input records.\n1. Need input table with column 'PersonalSpace'\n2.Flexibility of Resume execution for large number of row processing"; }
        }

        public override Type UserControlType
        {
            get { return typeof(MySiteControl);  }
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
                return "http://www.jeanpaulva.com/?p=4059";
            }
        }
    }
}
