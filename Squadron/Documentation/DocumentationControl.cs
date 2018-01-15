using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SquadronAddIns.Default.Documentation.Controls;
using Squadron;
using System.Diagnostics;
using Microsoft.SharePoint;
using Hx.General.HTML;
using System.IO;
using Hx.General;
using Microsoft.SharePoint.Administration;

namespace SquadronAddIns.Default.Documentation
{
    public partial class DocumentationControl : UserControl
    {
        public DocumentationControl()
        {
            InitializeComponent();

            RefreshData();
        }

        private const string Option_CoreInfo = "Core Info";
        private const string Option_FarmServers = "Farm Servers";
        private const string Option_Services = "Services";
        private const string Option_ServiceApplications = "Service Applications";
        private const string Option_ContentDatabases = "Content Databases";
        private const string Option_FarmSolutions = "Farm Solutions";
        private const string Option_UserSolutions = "User Solutions";
        private const string Option_ManagedPaths = "Managed Paths";
        private const string Option_WebApplications = "Web Applications";
        private const string Option_SiteCollections = "Site Collections";
        private const string Option_Sites = "Sites";
        private const string Option_Lists = "Lists";
        private const string Option_Items = "Items";

        private void RefreshData()
        {
            OptionsList.Items.Add(Option_CoreInfo);
            OptionsList.Items.Add(Option_FarmServers);
            OptionsList.Items.Add(Option_Services);
            OptionsList.Items.Add(Option_ServiceApplications);
            OptionsList.Items.Add(Option_ContentDatabases);
            OptionsList.Items.Add(Option_FarmSolutions);
            OptionsList.Items.Add(Option_UserSolutions);
            OptionsList.Items.Add(Option_ManagedPaths);
            OptionsList.Items.Add(Option_WebApplications);
            OptionsList.Items.Add(Option_SiteCollections);
            OptionsList.Items.Add(Option_Sites);
            OptionsList.Items.Add(Option_Lists);
            OptionsList.Items.Add(Option_Items);

            GeneralUtils.CheckAll(OptionsList);
            OptionsList.SetItemChecked(OptionsList.Items.IndexOf(Option_Items), false);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (OptionsList.CheckedIndices.Count > 0)
            {
                SquadronHelper.Instance.StartAnimation();

                try
                {
                    // Clear
                    ClearControls();

                    // Farm Section
                    if (IsChecked(Option_CoreInfo))
                        Refresh_CoreInfo();

                    if (IsChecked(Option_FarmServers))
                        Refresh_FarmServers();

                    if (IsChecked(Option_Services))
                        Refresh_Services();

                    if (IsChecked(Option_ServiceApplications))
                        Refresh_ServiceApplications();

                    if (IsChecked(Option_ContentDatabases))
                        Refresh_ContentDatabases();

                    if (IsChecked(Option_FarmSolutions))
                        Refresh_FarmSolutions();

                    if (IsChecked(Option_UserSolutions))
                        Refresh_UserSolutions();

                    if (IsChecked(Option_ManagedPaths))
                        Refresh_ManagedPaths();

                    // Application Section
                    if (IsChecked(Option_WebApplications))
                        Refresh_WebApplications();

                    if (IsChecked(Option_SiteCollections))
                        Refresh_SiteCollections();

                    if (IsChecked(Option_Sites))
                        Refresh_Sites();

                    if (IsChecked(Option_Lists))
                        Refresh_Lists();

                    if (IsChecked(Option_Items))
                        Refresh_Items();
                }
                finally
                {
                    SquadronHelper.Instance.StopAnimation();

                    SquadronContext.WriteMessage(this.Text + " operation completed!");
                }
            }
            else
                SquadronContext.Warn("Please select atleast one item!");
        }

        private int _nextTop;

        private void ClearControls()
        {
            _nextTop = 0;
            ResultPanel.Controls.Clear();
        }

        private bool IsChecked(string option)
        {
            foreach (int i in OptionsList.CheckedIndices)
                if (OptionsList.Items[i].ToString() == option)
                    return true;

            return false;
        }

        private void AddPanel(GridPanel panel)
        {
            ResultPanel.Controls.Add(panel);
            panel.Top = _nextTop;

            _nextTop += panel.Height;
        }

        private void ExportToHTMLButton_Click(object sender, EventArgs e)
        {
            if (ResultPanel.Controls.OfType<GridPanel>().Count() > 0)
            {
                string html = GetHTMLReport();

                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Squadron_Documentation_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + ".html";

                File.WriteAllText(path, html);

                Process.Start(path);
            }
            else
                SquadronContext.WriteMessage("No result(s) to show.");
        }
    }
}
