using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SquadronAddIns.Default.Utility.Entity
{
    public class ADEntity
    {
        public string Name
        {
            get;
            set;
        }

        public string LoginName
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Description
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

        public bool IsEnabled
        {
            get;
            set;
        }
    }
}
