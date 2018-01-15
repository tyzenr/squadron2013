using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron;
using System.Threading;
using Microsoft.SharePoint;
using Microsoft.Office.Server.UserProfiles;

namespace SquadronAddins.Default.MySiteInfo
{
    public partial class MySiteControl : UserControl
    {
        public MySiteControl()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (SquadronContext.HasCanvasData(true))
            {
                DataTable dataTable = SquadronContext.GetCanvasDataTable();

                grid.DataSource = dataTable;
            }
            else
                SquadronContext.Info("No Canvas Data!");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            SquadronContext.WriteMessage("Started..");

            if (AreInputsValid())
            {
                DataTable table = (grid.DataSource as DataTable);

                if (!table.Columns.Contains("MySite Url"))
                    table.Columns.Add("MySite Url", typeof(string));

                if (!table.Columns.Contains("Status"))
                    table.Columns.Add("Status", typeof(string));

                if (SizeCheck.Checked)
                    if (!table.Columns.Contains("Size"))
                        table.Columns.Add("Size", typeof(string));

                if (LastModifiedDateCheck.Checked)
                    if (!table.Columns.Contains("Last Modified Date"))
                        table.Columns.Add("Last Modified Date", typeof(string));

                Helper.Instance.RefreshGridData(grid);

                for (int i = 1; i <= 3; i++) // Guarantee Loop
                    foreach (DataRow row in table.Rows)
                    {
                        if (string.IsNullOrEmpty(row["Status"].ToString()) || row["Status"].ToString().StartsWith("Exception"))
                        {
                            DoWork(row);
                        }
                    }
            }

            SquadronContext.WriteMessage("Completed.");
        }

        private bool AreInputsValid()
        {
            DataTable table = (grid.DataSource as DataTable);

            if ((table == null) || (!table.Columns.Contains("PersonalSpace")))
            {
                SquadronContext.Errr("'PersonalSpace' column not in input table!");

                return false;
            }

            return true;
        }

        public void DoWork(object r)
        {
            DataRow row = (r as DataRow);

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                try
                {
                    row["MySite Url"] = SquadronContext.Url + row["PersonalSpace"];


                    using (SPSite site = new SPSite(row["MySite Url"].ToString()))
                    {
                        if (SizeCheck.Checked)
                            row["Size"] = site.Usage.Storage.ToString();

                        if (SizeCheck.Checked)
                            row["Last Modified Date"] = site.LastContentModifiedDate.ToString();

                        Helper.Instance.InvokeGarbageCollection();
                    }

                    row["Status"] = "Success";
                }
                catch (Exception ex)
                {
                    row["Status"] = "Exception: " + ex.ToString();
                }
            });
        }

        private bool _hasErrors;

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            _hasErrors = false;

            SquadronContext.WriteMessage("Started..");

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPSite site = new SPSite(SquadronContext.Url);

                DataTable table = RefreshUserProfiles(site);

                RefreshMySiteInfo();

                if (table != null)
                    SquadronContext.WriteMessage(table.Rows.Count.ToString() + " rows found");

                SquadronContext.WriteMessage("Completed.");
            });

            if (_hasErrors)
                SquadronContext.Errr("Errors occurred!");
        }

        private void RefreshMySiteInfo()
        {
            DataTable table = (grid.DataSource as DataTable);

            if (table != null)
            {
                if (!table.Columns.Contains("MySite Url"))
                    table.Columns.Add("MySite Url", typeof(string));

                if (!table.Columns.Contains("Status"))
                    table.Columns.Add("Status", typeof(string));

                if (SizeCheck.Checked)
                    if (!table.Columns.Contains("Size"))
                        table.Columns.Add("Size", typeof(string));

                if (LastModifiedDateCheck.Checked)
                    if (!table.Columns.Contains("Last Modified Date"))
                        table.Columns.Add("Last Modified Date", typeof(string));

                Helper.Instance.RefreshGridData(grid);

                for (int i = 1; i <= 3; i++) // Guarantee Loop
                    foreach (DataRow row in table.Rows)
                    {
                        if (string.IsNullOrEmpty(row["Status"].ToString()) || row["Status"].ToString().StartsWith("Exception"))
                        {
                            DoWork(row);
                        }
                    }
            }
        }

        private DataTable RefreshUserProfiles(SPSite site)
        {
            UserProfileManager manager = null;

            try
            {
                manager = new UserProfileManager(SPServiceContext.GetContext(site));
            }
            catch (NullReferenceException nex)
            {
                SquadronContext.Errr("User Profile Error!" + Environment.NewLine + "Please ensure User Profile Service application is Provisioned & Permissions are set correctly.");
                return null;
            }
            catch (UserProfileApplicationNotAvailableException uex)
            {
                SquadronContext.Errr("User Profile Error!" + Environment.NewLine + "Please configure User Profile Service Application & Ensure Permissions are set correctly.");
                return null;
            }
            catch
            {
                throw;
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

                bool canAdd = true;
                if (!FilterColumn.Text.Contains("("))
                    try
                    {
                        canAdd = (profile[FilterColumn.Text].Value != null) && profile[FilterColumn.Text].Value.ToString().Contains(FilterValue.Text);
                    }
                    catch (Exception ex)
                    {
                        _hasErrors = true;

                        SquadronContext.WriteMessage("Error: " + ex.ToString());
                        canAdd = false;
                    }

                if (canAdd)
                    table.Rows.Add(row);
            }

            grid.DataSource = table;
            return table;
        }
    }
}
