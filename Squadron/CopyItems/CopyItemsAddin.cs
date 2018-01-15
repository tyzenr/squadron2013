using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;
using System.IO;

namespace SquadronAddins.Default.CopyItems
{
    public class CopyItemsAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Copy Items"; }
        }

        public override string Description
        {
            get { return "Copies items from one list to another."; }
        }

        public override Type UserControlType
        {
            get { return typeof(CopyItemsControl); }
        }

        public override string HelpUrl
        {
            get
            {
                return "http://www.jeanpaulva.com/?p=4314";
            }
        }

        public override bool IsEnabled
        {
            get
            {
                return File.Exists(Helper.Instance.GetExecutionFolder() + "\\jp.txt");
            }
        }
    }
}
