using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Squadron;
using SquadronAddIns.Default.Command.Dialogs;
using SquadronAddIns.Default.Utility;
using SquadronAddIns.Default.Explorer;

namespace SquadronAddIns.Default.Command
{
    public class EnsureUserCommand : BaseCommand
    {
        public override IEnumerable<Type> GetSupportedTypes()
        {
            IList<Type> types = new List<Type>();

            types.Add(typeof(SPWebApplication));
            types.Add(typeof(SPSite));
            types.Add(typeof(SPWeb));

            return types;
        }

        public override string Text
        {
            get
            {
                return "Ensure User";
            }
        }

        public override string TooltipText
        {
            get
            {
                return "Invokes web.EnsureUser() on each web site.  Helps in reducing UserInfo table traffic for newly deployed SharePoint isntances.";
            }
        }

        private SecurableObjectEnumerator _so = new SecurableObjectEnumerator();

        public override void Perform(object o, IExplorer explorer)
        {
            IList<SPWeb> siteList = _so.GetSecurableObjects(o, true, false, false, false, true).Select(so => so.InternalObject as SPWeb).ToList();

            new EnsureUserDialog().ExecuteDialog(siteList);
        }
    }
}
