using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SquadronAddIns.Default.ListSize.Entity
{
    public class ListSizeEntity
    {
        public string Title
        {
            get;
            set;
        }

        public string LeafName
        {
            get;
            set;
        }

        public int ItemCount
        {
            get;
            set;
        }

        public int Size
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
