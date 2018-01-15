using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Explorer;

namespace SquadronAddIns.Default.Command
{
    public class UnlockCommand : BaseCommand
    {
        public override IEnumerable<Type> GetSupportedTypes()
        {
            IList<Type> types = new List<Type>();

            types.Add(typeof(SPListItem));

            return types;
        }

        public override string Text
        {
            get
            {
                return "Unlock";
            }
        }

        public override string TooltipText
        {
            get
            {
                return "Perofrms Unlocking of locked files.";
            }
        }

        public override void Perform(object o, IExplorer explorer)
        {
            if (o is SPListItem)
            {
                
            }

            else 
                ThrowInvalidOperation();
        }
    }
}
