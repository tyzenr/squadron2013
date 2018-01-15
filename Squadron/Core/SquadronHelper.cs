using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron.Widgets;
using System.Windows.Forms;
using Squadron.CanvasData;
using System.IO;
using System.Diagnostics;
using System.Data;
using Squadron.Animation;
using Squadron.Export;
using Windows8LookNFeel;

namespace Squadron
{
    public class SquadronHelper
    {
        private CSVExport _csvExport = new CSVExport();
        private ExcelExport _excelExport = new ExcelExport();

        private static SquadronHelper _Instance;

        public static SquadronHelper Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SquadronHelper();

                return _Instance;
            }
        }

        private SquadronHelper()
        {
        }

        private WidgetManager _widgetManager = new WidgetManager();

        public WidgetManager WidgetManager
        {
            get
            {
                return _widgetManager;
            }
        }

        public void InitializeControls(Control container)
        {
            if (container is MainForm)
                if (Constants.IsReducedVersion)
                {
                    (container as MainForm).TitleLabel.Text = "ATPCO Auditer";
                    (container as MainForm).Text = "ATPCO Auditer";
                    (container as MainForm).browser.Hide();
                    (container as MainForm).FollowPanel.Hide();
                }

            _widgetManager.InitializeControls(container);
        }

        private AnimationForm _animationForm;

        public void StartAnimation(bool monitorExceptions)
        {
            StartAnimation();

            if (monitorExceptions)
                SquadronContext.StartMonitoringExceptions();
        }

        public void StartAnimation()
        {
            FreeAnimation();

            _animationForm = new AnimationForm();
            _animationForm.Show();

            Application.DoEvents();
        }

        public string StopAnimation(bool monitorExceptions)
        {
            StopAnimation();

            if (monitorExceptions)
                return SquadronContext.StopMonitoringExceptions();

            return string.Empty;
        }

        public void StopAnimation()
        {
            FreeAnimation();
        }

        private void FreeAnimation()
        {
            try
            {
                if (_animationForm != null)
                {
                    _animationForm.Dispose();
                    _animationForm = null;
                }
            }
            catch
            {
            }
        }

        public void RefreshAddins(ComboBox list, bool logEntry, bool csvEntry)
        {
            list.Items.Clear();

            if (logEntry)
                list.Items.Add("[Log entries]");

            if (csvEntry)
                list.Items.Add("[Load from CSV]");

            foreach (SquadronAddin Addin in SquadronContext.Addins)
            {
                list.Items.Add((new AddinView() { Addin = Addin }));

                if (SquadronContext.MainForm.AddinControlContainer.Controls.Count > 0)
                    if (object.ReferenceEquals(SquadronContext.MainForm.AddinControlContainer.Controls[0], Addin.UserControlInstance))
                        list.SelectedIndex = list.Items.Count - 1;
            }
        }

        public void ExportToCSV(ListBox listBox, List<string> list, bool launch)
        {
            _csvExport.ExportToCSV(listBox, list, launch);
        }

        public void ExportToCSV(DataGridView grid, List<string> list, bool launch)
        {
            _csvExport.ExportToCSV(grid, list, launch);
        }

        public void ExportToExcel(DataSet dataset, bool launch)
        {
            string file = _excelExport.ExportToExcel(dataset.Tables[0]);

            if (launch)
                Launch(file);
        }

        public void ExportToExcel(string file, DataSet dataset)
        {
            _excelExport.ExportToExcel(dataset.Tables[0], file);
        }

        public DataTable GetDataTableFromExcel(string file)
        {
            return _excelExport.GetDataTable(file);
        }

        public void Launch(string file)
        {
            try
            {
                if (File.Exists(file))
                    Process.Start(file);
            }
            catch
            {
            }
        }

        public DataTable GetDataTableFromCSV()
        {
            return _csvExport.GetDataTableFromCSVFile();
        }

        public void ImportFromCSV(Control control)
        {
            _csvExport.ImportFromCSV(control);
        }
    }
}
