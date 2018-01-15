using Squadron;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Default.Documentation
{
    public class DocumentationAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Documentation"; }
        }

        public override string Description
        {
            get { return "Documentation on SharePoint Inventory - Farm, Web Applications, Site Collections, Sites, Lists, Libraries, Items, Documents etc."; }
        }

        public override Type UserControlType
        {
            get { return typeof(DocumentationControl); }
        }

        public override int Order
        {
            get
            {
                return 1;
            }
        }

        public override bool IsEnabled
        {
            get
            {
                return true;
            }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/index.php/2014/01/18/squadron-documentation/";
            }
        }
    }
}
