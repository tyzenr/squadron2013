using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;
using SquadronAddIns.Default.SiteStructure;

namespace SquadronAddins.Default.SiteStructure
{
    public class SiteStructureAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Site Structure"; }
        }

        public override string Description
        {
            get { return "Generates site structure information on Site Collections, Subsites, Document Libraries, Lists, Items etc.\n\nUseful in analyzing new sites & generating reports."; }
        }

        public override Type UserControlType
        {
            get { return typeof(SiteStructureControl); }
        }

        public override string Group
        {
            get
            {
                return "Site";
            }
        }

        public override int Order
        {
            get
            {
                return 100;
            }
        }

        public override bool IsEnabled
        {
            get
            {
                return false;
            }
        }
    }
}
