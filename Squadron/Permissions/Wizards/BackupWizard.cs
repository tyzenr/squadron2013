using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using SquadronAddIns.Default.Permission;
using Squadron;
using Squadron.Export;
using System.Diagnostics;
using Squadron.Widgets;

namespace SquadronAddIns.Default.Permissions.Wizards
{
    public partial class BackupWizard : WizardForm
    {
        private const int PAGE_TREE = 0;
        private const int PAGE_GRID = 1;
        private const int PAGE_FILE = 2;
        private const int PAGE_LAST = 3;

        private PermissionsControl _permissionsControl;

        public BackupWizard()
        {
            InitializeComponent();

            // Init Controls
            browser.Url = SquadronContext.Url;

            _permissionsControl = new PermissionsControl();
            _permissionsControl.UrlStaticMode = true;
            _permissionsControl.Dock = DockStyle.Fill;
            _permissionsControl.HideControls();
            page3.Controls.Add(_permissionsControl);

            ShowHideButtons();
        }

        protected override void BeforeShowPage(int index, bool isNext, bool isPrev)
        {
            base.BeforeShowPage(index, isNext, isPrev);

            if (isNext)
                if (index == PAGE_LAST)
                    SaveToFile();
        }

        protected override void OnPageChanged(int index, bool isNext, bool isPrev)
        {
            base.OnPageChanged(index, isNext, isPrev);

            if (isNext)
                if (index == PAGE_GRID)
                    PrepareItemIdentification();
        }

        private void SaveToFile()
        {
            try
            {
                DataTable table = _permissionsControl.GetDataTable(true);
                ConvertBlanksToDots(table);
                FileLink.Text = new ExcelExport().ExportToExcel(table, FileText.Text);

                ShowSummary();
            }
            catch (Exception ex)
            {
                SquadronContext.Errr(ex.ToString());
            }
        }

        private void ShowSummary()
        {
            var list = _permissionsControl.GetList();

            WebUniqueCountLabel.Text = "Unique: " + list.Where(p => p.Type == "Site" && p.PermissionType == "Unique").Count().ToString();
            WebInheritedCountLabel.Text = "Inherit: " + list.Where(p => p.Type == "Site" && p.PermissionType == "Inherit").Count().ToString();
            
            ListUniqueCountLabel.Text = "Unique: " + list.Where(p => p.Type == "List" && p.PermissionType == "Unique").Count().ToString();
            ListInheritedCountLabel.Text = "Inherit: " + list.Where(p => p.Type == "List" && p.PermissionType == "Inherit").Count().ToString();

            LibraryUniqueCountLabel.Text = "Unique: " + list.Where(p => p.Type == "Library" && p.PermissionType == "Unique").Count().ToString();
            LibraryInheritedCountLabel.Text = "Inherit: " + list.Where(p => p.Type == "Library" && p.PermissionType == "Inherit").Count().ToString();
        }

        private void ConvertBlanksToDots(DataTable table)
        {
            foreach (DataRow r in table.Rows)
                foreach (DataColumn c in table.Columns)
                    if ((r[c] == null) || (r[c].ToString() == string.Empty))
                        r[c] = "."; 
        }

        private void PrepareItemIdentification()
        {
            _permissionsControl.SelectedObjects = browser.SelectedObjects;
            _permissionsControl.SelectedObjectsMode = true;

            _permissionsControl.FilterCheck.Checked = FilterCheck.Checked;
            _permissionsControl.FilterText.Text = FilterText.Text;

            _permissionsControl.ShowUsersInGroup.Checked = true;

            _permissionsControl.Execute();

            ShowCount();
        }

        private void ShowCount()
        {
            CountLabel.Text = _permissionsControl.Result.Count.ToString() + " item(s)";
        }

        private void FileDialog_Click(object sender, EventArgs e)
        {
            SaveDialog.Filter = "*.xlsx|*.xlsx";
            if (SaveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                FileText.Text = SaveDialog.FileName;
        }

        public override bool CanMoveNext(int index)
        {
            if (index == PAGE_TREE)
            {
                if (browser.SelectedObjects.Count == 0)
                {
                    SquadronContext.Errr("Please select atleast one item!");
                    return false;
                }
            }
            else if (index == PAGE_FILE)
            {
                if (string.IsNullOrEmpty(FileText.Text))
                {
                    SquadronContext.Errr("Please select a valid file!");
                    return false;
                }
            }

            return true;
        }

        private void FileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(FileLink.Text);
        }

        private void FilterCheck_CheckStateChanged(object sender, EventArgs e)
        {
            FilterText.Visible = FilterCheck.Checked;
        }
    }
}
