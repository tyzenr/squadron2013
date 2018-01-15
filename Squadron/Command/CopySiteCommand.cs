using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Command.Dialogs;
using Squadron;
using Squadron.Dialogs;
using SquadronAddIns.Default.Utility;
using System.IO;
using SquadronAddIns.Default.Explorer;
using System.Collections;

namespace SquadronAddIns.Default.Command
{
    public class CopySiteCommand : BaseCommand
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
                return "Copy Site";
            }
        }

        public override string TooltipText
        {
            get
            {
                return "Copy the site, sub sites to destination site.";
            }
        }

        public override void Perform(object o, IExplorer explorer)
        {
            SquadronContext.WriteMessage("Export operation started..");

            try
            {
                SPWeb source = (o as SPWeb);

                if (GetParent())
                {
                    if (CreateDestinationWeb(source))
                    {
                        SquadronHelper.Instance.StartAnimation();

                        if (ExportWeb(source))
                            if (ImportWeb(_destWeb))
                            {
                                DeleteFolder();
                                Success();
                                explorer.RefreshData();
                            }
                    }
                }
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
                SquadronContext.WriteMessage("Export operation completed.");
            }
        }

        private void DeleteFolder()
        {
            try
            {
                Directory.Delete(_exportpath, true);
            }
            catch
            {
            }
        }

        bool ImportWeb(SPWeb dest)
        {
            ImportExportUtility utility = new ImportExportUtility();
            bool result = utility.Import(dest, _exportpath);

            return true;
        }

        private void Success()
        {
            SquadronContext.Info("Copied successfully.");
        }

        string _tempfolder, _exportpath;

        private bool ExportWeb(SPWeb source)
        {
            _tempfolder = Helper.Instance.GetExecutionFolder() + "\\" + Guid.NewGuid().ToString();
            _exportpath = _tempfolder + "\\export.cmp";
            ImportExportUtility utility = new ImportExportUtility();
            bool result = utility.Export(source, _exportpath);

            return result;
        }

        private bool CreateDestinationWeb(SPWeb source)
        {
            InputDialog dialog = new InputDialog();

            if (_parent is SPWeb)
            {
                if (dialog.Execute(source.ServerRelativeUrl))
                {
                    _destWeb = (_parent as SPWeb).Webs.Add(dialog.InputText, source.Title, source.Description, (uint)source.Locale.LCID, source.WebTemplate, false, false);
                }
            }
            else
                return false;

            return true;
        }

        private object _parent;
        private SPWeb _destWeb;

        private bool GetParent()
        {
            SharePointDialog dialog = new SharePointDialog();
            bool result = dialog.Execute("Select Destination Parent Site", SquadronContext.Url);
            _parent = dialog.SelectedObject;

            return result;
        }
    }
}
