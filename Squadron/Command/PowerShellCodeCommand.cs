using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SquadronAddIns.Default.Command.Dialogs;
using SquadronAddIns.Default.Explorer;

namespace SquadronAddIns.Default.Command
{
    public class PowerShellCodeCommand : BaseCommand
    {
        public override IEnumerable<Type> GetSupportedTypes()
        {
            IList<Type> types = new List<Type>();

            types.Add(typeof(SPSite));
            types.Add(typeof(SPWeb));
            types.Add(typeof(SPList));
            types.Add(typeof(SPDocumentLibrary));
            types.Add(typeof(SPListItem));

            return types;
        }

        public override string Text
        {
            get
            {
                return "PowerShell Code";
            }
        }

        public override string TooltipText
        {
            get
            {
                return "Get the PowerShell code pointing to selected object.";
            }
        }

        public override void Perform(object o, IExplorer explorer)
        {
            IList<string> codeLines = new List<string>();

            AddSharePointSnapInCode(codeLines);
            codeLines.Add("");
            codeLines.Add("#Code");

            if (o is SPSite)
            {
                codeLines.Add("$site = Get-SPSite " + (o as SPSite).Url);
                codeLines.Add("");
                codeLines.Add("#Print");
                codeLines.Add("$site.Url");
            }

            else if (o is SPWeb)
            {
                codeLines.Add("$site = Get-SPSite " + (o as SPWeb).Site.Url);

                codeLines.Add("$web = Get-SPWeb -Identity " + (o as SPWeb).Url);
                codeLines.Add("");
                codeLines.Add("#Print");
                codeLines.Add("$web.Title");
            }

            else if (o is SPList)
            {
                codeLines.Add("$site = Get-SPSite " + (o as SPList).ParentWeb.Site.Url);
                codeLines.Add("$web = Get-SPWeb -Identity " + (o as SPList).ParentWeb.Url);

                codeLines.Add("$list = $web.GetList(\"" + (o as SPList).DefaultViewUrl + "\")");
                codeLines.Add("");
                codeLines.Add("#Print");
                codeLines.Add("$list.Title");
            }

            else if (o is SPListItem)
            {
                codeLines.Add("$site = Get-SPSite " + (o as SPListItem).ParentList.ParentWeb.Site.Url);
                codeLines.Add("$web = Get-SPWeb -Identity " + (o as SPListItem).ParentList.ParentWeb.Url);
                codeLines.Add("$list = $web.GetList(\"" + (o as SPListItem).ParentList.DefaultViewUrl + "\")");

                codeLines.Add("$item = $list.GetItemById(" + (o as SPListItem).ID.ToString() + ")");
                codeLines.Add("");
                codeLines.Add("#Print");
                codeLines.Add("$item.DisplayName");
            }

            new PowerShellCodeDialog().ExecuteDialog(GetCode(codeLines));
        }

        private string GetCode(IList<string> codeLines)
        {
            string result = string.Empty;

            foreach (string line in codeLines)
                result += line + Environment.NewLine;

            return result;
        }

        private void AddSharePointSnapInCode(IList<string> codeLines)
        {
            codeLines.Add("# Add SharePoint SnapIn");
            codeLines.Add("If ((Get-PSSnapIn -Name Microsoft.SharePoint.PowerShell -ErrorAction SilentlyContinue) -eq $null )");
            codeLines.Add("{");
            codeLines.Add("    Add-PSSnapIn -Name Microsoft.SharePoint.PowerShell");
            codeLines.Add("}");
        }
    }
}
