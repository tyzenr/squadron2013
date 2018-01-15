using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using Microsoft.SharePoint.Administration;
using Squadron;
using SquadronAddIns.Default.Size.Entity;
using Microsoft.SharePoint;

namespace SquadronAddIns.Default.Size.Dialogs
{
    public partial class ContentDatabaseSizeForm : Windows8LookNFeel.Windows8Form
    {
        public ContentDatabaseSizeForm()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
               {
                   IList<DbSizeEntity> list = new List<DbSizeEntity>();
                   SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(SquadronContext.Url));
                   if (webApplication != null)
                   {
                       foreach (SPContentDatabase cd in webApplication.ContentDatabases)
                           list.Add(new DbSizeEntity() { Name = cd.DisplayName, Size = cd.DiskSizeRequired });
                   }

                   grid.DataSource = list;

                   FooterPanel.Text = SquadronContext.Url;
               });
        }
    }
}
