using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squadron.AddIns.SqlServer.CopyTables
{
    public class CopyTablesAddIn
    {
        public override string Name
        {
            get { return "SQL Server - Copy Tables"; }
        }

        public override string Description
        {
            get { return "Copy Tables functionality between SQL Servers."; }
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
                return "http://jeanpaulva.com/";
            }
        }
    }
}
