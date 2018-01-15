using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Deployment;
using Squadron;
using System.Collections;

namespace SquadronAddIns.Default.Utility
{
    public class ImportExportUtility
    {
        public bool Export(SPWeb web, string filename)
        {
            SPExportSettings exportSettings = new SPExportSettings();
            exportSettings.SiteUrl = web.Url;
            exportSettings.ExportMethod = SPExportMethodType.ExportAll;
            exportSettings.BaseFileName = Helper.Instance.ExtractFileName(filename);
            exportSettings.FileLocation = Helper.Instance.ExtractFolder(filename);
            exportSettings.OverwriteExistingDataFile = true;

            SPExport export = new SPExport(exportSettings);
            export.Run();

            return true;
        }

        public bool Import(SPWeb web, string filename)
        {
            SPImportSettings importSettings = new SPImportSettings();
            importSettings.BaseFileName = Helper.Instance.ExtractFileName(filename);
            importSettings.FileLocation = Helper.Instance.ExtractFolder(filename);
            importSettings.SiteUrl = web.Url;

            importSettings.RetainObjectIdentity = false;
            importSettings.SuppressAfterEvents = true;

            // DeleteLists(web);

            SPImport import = new SPImport(importSettings);
            import.Run();

            return true;
        }

        private void DeleteLists(SPWeb web)
        {
            ArrayList list = new ArrayList();
            foreach (SPList l in web.Lists)
                list.Add(l);

            foreach (SPList l in list)
            {
                try
                {
                    l.Delete();
                }
                catch { }
            }
        }
    }
}
