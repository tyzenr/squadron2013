using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Squadron.Addins.SqlServer.CopyTables
{
    public class CopyTablesAddin : SquadronAddin
    {
        public override bool IsEnabled
        {
            get
            {
                return true;
            }
        }

        public override string Name
        {
            get { return "SQL Copy Tables"; }
        }

        public override string Description
        {
            get { return "Copy Table(s) between SQL Servers."; }
        }

        public override Type UserControlType
        {
            get { return typeof(CopyTablesControl); }
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
                return "http://www.jeanpaulva.com/?p=4578";
            }
        }

        public override int Order
        {
            get
            {
                return 1150;
            }
        }
    }
}
