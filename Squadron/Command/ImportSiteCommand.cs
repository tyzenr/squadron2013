using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Squadron;
using SquadronAddIns.Default.Command.Dialogs;
using SquadronAddIns.Default.Utility;
using System.Windows.Forms;
using Microsoft.SharePoint.Deployment;
using System.IO;
using Microsoft.SharePoint.Utilities;
using SquadronAddIns.Default.Explorer;
using System.Collections;

namespace SquadronAddIns.Default.Command
{
    public class ImportSiteCommand : BaseCommand
    {
        public override IEnumerable<Type> GetSupportedTypes()
        {
            IList<Type> types = new List<Type>();

            types.Add(typeof(SPWeb));

            return types;
        }

        public override string Text
        {
            get
            {
                return "Import Site";
            }
        }

        public override string TooltipText
        {
            get
            {
                return "Import the Exported CMP file(s) into selected site.";
            }
        }

        public override void Perform(object o, IExplorer explorer)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.cmp|*.cmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SquadronHelper.Instance.StartAnimation();

                try
                {
                    ImportExportUtility utility = new ImportExportUtility();

                    if (utility.Import(o as SPWeb, dialog.FileName))
                        SquadronContext.Info("Imported succesfully!" + Environment.NewLine + Environment.NewLine + "Please ensure home page, list contents, features, sub sites, user permissions in the new site.");
                }
                finally
                {
                    SquadronHelper.Instance.StopAnimation();
                }
            }
        }
    }
}
