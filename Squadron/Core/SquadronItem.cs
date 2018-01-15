using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squadron
{
    public class SquadronItem
    {
        public SquadronAddin Addin
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Addin.Name;
        }
    }
}
