using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SquadronAddIns.Default.Documentation.Controls;
using SquadronAddIns.Default.SharePointSKU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Default.Documentation
{
    partial class DocumentationControl
    {
        private IList<string> GridColumns_CoreInfo = new List<string>(new string[] { "Property", "Value" });

        private void Refresh_CoreInfo()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                GridPanel panel = new GridPanel();
                IList<SPCoreInfoEntity> list = new List<SPCoreInfoEntity>();

                list.Add(new SPCoreInfoEntity() { Property = "StockKeepingUnit", Value = SKUFinder.Execute().Replace("Product Installed: ", string.Empty) });
                list.Add(new SPCoreInfoEntity() { Property = "BuildVersion", Value = SPFarm.Local.BuildVersion.ToString() });
                
                panel.Title = "Core Info";
                panel.GridColumns = GridColumns_CoreInfo;
                panel.GridDataSource = list;

                AddPanel(panel);
            });
        }
    }
}
