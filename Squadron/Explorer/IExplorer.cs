using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Default.Explorer
{
    public interface IExplorer
    {
        void RefreshData();
        void DeleteSelectedNode();
    }
}
