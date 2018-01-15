using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Squadron;
using SquadronAddIns.Default.ListSize.Entity;

namespace SquadronAddins.Default.SiteSize
{
    public partial class SiteSizeControl : UserControl
    {
        public SiteSizeControl()
        {
            InitializeComponent();

            TotalLabel.Text = string.Empty;
        }

        private IList<ListSizeEntity> _list = new List<ListSizeEntity>();

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            SquadronContext.WriteMessage("Started..");

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                _list.Clear();

                using (SPSite siteCollection = new SPSite(SquadronContext.Url))
                {
                    if (DocLibCheck.Checked)
                    {
                        var r1 = siteCollection.StorageManagementInformation(
                          SPSite.StorageManagementInformationType.DocumentLibrary,
                          SPSite.StorageManagementSortOrder.Decreasing,
                          SPSite.StorageManagementSortedOn.Size,
                          1000000
                          );

                        AddToList(r1);
                    }

                    if (ListCheck.Checked)
                    {
                        var r2 = siteCollection.StorageManagementInformation(
                            SPSite.StorageManagementInformationType.List,
                            SPSite.StorageManagementSortOrder.Decreasing,
                            SPSite.StorageManagementSortedOn.Size,
                            1000000
                            );

                        AddToList(r2);
                    }

                    ShowTotal();

                    grid.DataSource = _list;
                }
            });

            GC.Collect();
            SquadronContext.WriteMessage("Completed.");
        }

        private void ShowTotal()
        {
            int result = _list.Sum(e => e.Size);

            TotalLabel.Text = "Total Size: " + result.ToString();
        }

        private void AddToList(DataTable t)
        {
            foreach (DataRow row in t.Rows)
            {
                ListSizeEntity entity = new ListSizeEntity();
                entity.Title = row["Title"].ToString();
                entity.ItemCount = Helper.Instance.Int(row["ItemCount"]);
                entity.Size = Helper.Instance.Int(row["Size"]);
                entity.LeafName = row["LeafName"].ToString();
                entity.InternalObject = row;

                _list.Add(entity);
            }
        }

        public static long GetSPFolderSize(SPFolder folder)
        {
            long folderSize = 0;

            foreach (SPFile file in folder.Files)
                folderSize += file.TotalLength
                    + file.Versions.Cast<SPFileVersion>().Sum(f => f.Size);

            folderSize += folder.SubFolders.Cast<SPFolder>().Sum(sf => GetSPFolderSize(sf));

            return folderSize;
        }

        public static string FormatSize(long size)
        {
            if (size > Math.Pow(1024, 3))
                return (size / Math.Pow(1024, 3)).ToString("#,#.##") + " GB";

            else if (size > Math.Pow(1024, 2))
                return (size / Math.Pow(1024, 2)).ToString("#,#.##") + " MB";

            else if (size > 1024)
                return (size / 1024).ToString("#,#.##") + " KB";

            else
                return size.ToString("#,#.##") + " Bytes";
        }
    }
}
