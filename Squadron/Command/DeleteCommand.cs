using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Explorer;
using SquadronAddIns.Default.Utility;

namespace SquadronAddIns.Default.Command
{
    public class DeleteCommand : BaseCommand
    {
        public override IEnumerable<Type> GetSupportedTypes()
        {
            IList<Type> types = new List<Type>();

            types.Add(typeof(SPSite));
            types.Add(typeof(SPWeb));
            types.Add(typeof(SPList));
            types.Add(typeof(SPDocumentLibrary));

            return types;
        }

        public override string Text
        {
            get
            {
                return "Delete";
            }
        }

        private SharePointUtility _utility = new SharePointUtility();

        public override string TooltipText
        {
            get
            {
                return "Delete the selected object & child objects under it.";
            }
        }

        public override void Perform(object o, IExplorer explorer)
        {
            if (ConfirmDelete(o))
            {
                SquadronHelper.Instance.StartAnimation();

                try
                {
                    if (o is SPSite)
                        (o as SPSite).Delete();

                    else if (o is SPWeb)
                    {
                        foreach (SPWeb web in _utility.GetWebsRecursively(o as SPWeb).Reverse())
                            try
                            {
                                web.Delete();
                            }
                            catch { }

                        (o as SPWeb).Delete();
                    }

                    else if (o is SPList)
                        (o as SPList).Delete();

                    explorer.DeleteSelectedNode();
                    SquadronContext.WriteMessage("Delete operation completed!");
                }
                finally
                {
                    SquadronHelper.Instance.StopAnimation();
                }
            }
        }

        private bool ConfirmDelete(object o)
        {
            bool result = false;

            if (o is SPSite)
                result = SquadronContext.Confirm("Are you sure you wanted Delete the selected site collection?" + Environment.NewLine + "Site Collection: " + (o as SPSite).Url + Environment.NewLine + Environment.NewLine + GetSubSiteInfo(o));

            else if (o is SPWeb)
                result = SquadronContext.Confirm("Are you sure you wanted to Delete the selected site & sub sites?" + Environment.NewLine + "Site: " + (o as SPWeb).Url + Environment.NewLine + Environment.NewLine + GetSubSiteInfo(o));

            else if (o is SPList)
                result = SquadronContext.Confirm("Are you sure you wanted to Delete the selected list?");

            return result;
        }

        private string GetSubSiteInfo(object o)
        {
            string result = string.Empty;

            if (o is SPSite)
            {
                foreach (SPWeb web in (o as SPSite).AllWebs)
                    result += web.Title + Environment.NewLine;
            }

            else if (o is SPWeb)
            {
                foreach (SPWeb web in _utility.GetWebsRecursively(o as SPWeb))
                    result += web.Title + Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(result))
                result = "Sub sites underneath: " + Environment.NewLine + result;

            return result;
        }
    }
}
