using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron;
using Microsoft.SharePoint;
using Microsoft.Office.Server.UserProfiles;

namespace SquadronAddins.Default.UserProfileInfo
{
    public partial class UserProfileControl : UserControl
    {
        public UserProfileControl()
        {
            InitializeComponent();
        }

        private long GetSize(string url)
        {
            long result = 0;

            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    using (SPSite site = new SPSite(url))
                    {
                        result = site.Usage.Storage;
                    }
                });

            return result;
        }

        private void PerformButton_Click(object sender, EventArgs e)
        {
            SquadronContext.WriteMessage("Started..");
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPSite site = new SPSite(SquadronContext.Url);
                UserProfileManager manager = null;

                try
                {
                    manager = new UserProfileManager(SPServiceContext.GetContext(site));
                }
                catch (Exception ex)
                {
                    SquadronContext.Errr("Unable to create UserProfileManager object!" + Environment.NewLine + "Please ensure Central Administration > User Profile Service Application > Permissions are set!");
                    SquadronContext.HandleException(ex);
                    return;
                }

                DataTable table = new DataTable();
                foreach (Property p in manager.Properties)
                {
                    table.Columns.Add(p.Name, typeof(string));
                }

                foreach (UserProfile profile in manager)
                {
                    DataRow row = table.NewRow();
                    foreach (Property property in manager.Properties)
                    {
                        row[property.Name] = profile[property.Name].Value;
                    }

                    table.Rows.Add(row);
                }

                grid.DataSource = table;

                SquadronContext.WriteMessage(table.Rows.Count.ToString() + " rows found");
                SquadronContext.WriteMessage("Completed.");
            });
        }
    }
}
