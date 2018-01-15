using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;
using SquadronAddIns.Default.VersionCleaner;

namespace SquadronAddins.Default.VersionCleaner
{
    public class VersionCleanerAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Version Cleaner"; }
        }

        public override string Description
        {
            get { return "Removes unwanted/obsolete versions from lists/libraries saving storage space."; }
        }

        public override Type UserControlType
        {
            get { return typeof(VersionCleanerControl); }
        }

        public override int Order
        {
            get
            {
                return 113;
            }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/index.php/2014/01/09/squadron-version-cleaner/";
            }
        }
    }
}
