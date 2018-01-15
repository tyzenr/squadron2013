using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddins.Default.UserProfileInfo
{
    public class UserProfileAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "User Profile"; }
        }

        public override string Description
        {
            get { return "Returns User Profile Information"; }
        }

        public override Type UserControlType
        {
            get { return typeof(UserProfileControl); }
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
                return "http://www.jeanpaulva.com/?p=4029";
            }
        }
    }
}
