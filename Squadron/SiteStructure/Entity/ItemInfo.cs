using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SquadronAddIns.Default.SiteStructure.Entity
{
    public class ItemInfo
    {
        public string Title
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public string ItemCount
        {
            get;
            set;
        }

        public string VersionCount
        {
            get;
            set;
        }

        [Browsable(false)]
        public object InternalObject
        {
            get;
            set;
        }
    }
}
