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
using SquadronAddIns.Default.Explorer;

namespace SquadronAddIns.Default.Command
{
    public class ExportSiteCommand : BaseCommand
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
                return "Export Site";
            }
        }

        public override string TooltipText
        {
            get
            {
                return "Exports the selected site into a CMP file.  Later you can Import the file in target site collection.";
            }
        }

        public override void Perform(object o, IExplorer explorer)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.cmp|*.cmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SquadronHelper.Instance.StartAnimation();
                SquadronContext.WriteMessage("Starting Export to file(s): " + dialog.FileName);

                try
                {
                    ImportExportUtility utility = new ImportExportUtility();
                    if (utility.Export(o as SPWeb, dialog.FileName))
                    {
                        string message = "Exported succesfully!" + Environment.NewLine + Environment.NewLine + "Following are the files:" + Environment.NewLine;

                        foreach (string file in Directory.GetFiles(Helper.Instance.ExtractFolder(dialog.FileName), Helper.Instance.ExtractFileName(dialog.FileName).Replace(".cmp", "*.cmp")))
                            message += file + Environment.NewLine;

                        SquadronContext.Info(message);
                    }
                }
                finally
                {
                    SquadronHelper.Instance.StopAnimation();
                }
            }
        }
    }
}
