using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace SquadronAddIns.Default.Command
{
    public class EditCommand : BaseCommand
    {
        public override IEnumerable<Type> GetSupportedTypes()
        {
            yield return typeof(SPSite);
            yield return typeof(SPWeb);
            yield return typeof(SPList);
            yield return typeof(SPDocumentLibrary);
            yield return typeof(SPListItem);
        }

        public override string Text
        {
            get
            {
                return "Edit";
            }
        }

        public override string TooltipText
        {
            get
            {
                return "Edit Property of this object.\nFor example: Make a list Read-Only";
            }
        }
    }
}
