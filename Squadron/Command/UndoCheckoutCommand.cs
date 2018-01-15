using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Explorer;

namespace SquadronAddIns.Default.Command
{
    public class UndoCheckoutCommand : BaseCommand
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
                return "Undo Checkout";
            }
        }

        public override string TooltipText
        {
            get
            {
                return "Performs Undo Checkout for checked out file.";
            }
        }

        public override void Perform(object o, IExplorer explorer)
        {
            if (o is SPListItem)
            {
                if ((o as SPListItem).File != null)
                    (o as SPListItem).File.UndoCheckOut();
            }

            else
                ThrowInvalidOperation();
        }
    }
}
