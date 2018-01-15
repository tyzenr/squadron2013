using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using Squadron;
using System.IO;
using System.Diagnostics;
using SquadronAddIns.Default.Utility;
using SquadronAddIns.Default.Permissions.Entity;
using Squadron.Others;
using Squadron.Widgets;

namespace SquadronAddIns.Default.Permissions.Wizards
{
    public partial class RestoreWizard : WizardForm
    {
        private const int PAGE_FILE = 1;
        private const int PAGE_FILECONTENT = 2;
        private const int PAGE_MATCHES = 5;
        private const int PAGE_SUMMARY = 6;

        public RestoreWizard()
        {
            InitializeComponent();

            if (Debugger.IsAttached)
            {
                FileText.Text = "c:\\temp\\sample.xlsx";
            }

            TargetUrlText.Text = SquadronContext.Url;
        }

        private void BrowserButton_Click(object sender, EventArgs e)
        {
            OpenDialog.FileName = string.Empty;
            OpenDialog.Filter = "*.xlsx|*.xlsx";

            if (OpenDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                FileText.Text = OpenDialog.FileName;
        }

        public override bool CanMoveNext(int index)
        {
            if (index == PAGE_FILE)
            {
                if ((string.IsNullOrEmpty(FileText.Text))
                    ||
                !File.Exists(FileText.Text))
                {
                    SquadronContext.Errr("Please enter a valid file!");
                    return false;
                }
            }

            else if (index == PAGE_FILECONTENT)
            {
                if (!_isFileContentValid)
                {
                    SquadronContext.Errr("Due to error(s) cannot continue further!");
                    return false;
                }
            }

            else if (index == PAGE_MATCHES)
            {
                return CanApplyPermissions();
            }

            return true;
        }

        private bool CanApplyPermissions()
        {
            ConfirmDialog confirm = new ConfirmDialog();

            return confirm.ExecuteDialog("Are you sure you want to APPLY permissions?" + Environment.NewLine + "Existing Permissions in MATCHED objects will be deleted!");
        }

        protected override void OnPageChanged(int index, bool isNext, bool isPrev)
        {
            base.OnPageChanged(index, isNext, isPrev);

            if (isNext)
            {

            }
        }

        protected override void BeforeShowPage(int index, bool isNext, bool isPrev)
        {
            base.BeforeShowPage(index, isNext, isPrev);

            if (isNext)
            {
                if (index == PAGE_FILECONTENT)
                    RefreshFileContentPage();

                if (index == PAGE_MATCHES)
                    RefreshMatchesPage();

                if (index == PAGE_SUMMARY)
                    RefreshSummaryPage();
            }
        }

        private void RefreshSummaryPage()
        {
            ApplyPermissions();
        }

        private SecurableObjectEnumerator _securableObjectEnumerator = new SecurableObjectEnumerator();
        private IList<SecurableObject> _securableObjects;
        private IList<PermissionEntity> _permissionEntities;

        private void RefreshMatchesPage()
        {
            try
            {
                SquadronHelper.Instance.StartAnimation();
                _permissionEntities = _restoreExpert.GetPermissionEntities(grid.DataSource as DataTable);
                _securableObjects = _securableObjectEnumerator.GetSecurableObjects(TargetUrlText.Text, Squadron.Components.ScopeEnum.WebApplication, HasSite(_permissionEntities), HasListOrLibrary(_permissionEntities), HasFolder(_permissionEntities), HasItem(_permissionEntities), true);

                int count = _restoreExpert.MatchPermissions(_permissionEntities, _securableObjects);

                // Display

                SourceLabel.Text = "Source Objects: " + _permissionEntities.Count.ToString();
                DestinationLabel.Text = "Destination Objects Matched: " + count.ToString();

                DisplayToTreeview(_permissionEntities);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private IList<string> _invalidUsers;

        private void CheckUserErrors()
        {
            _invalidUsers = new List<string>();

            foreach (PermissionEntity pe in _permissionEntities)
                foreach (RoleEntity re in pe.Roles)
                    foreach (string user in re.Users)
                        if (!IsUserValid(user))
                            _invalidUsers.Add(user);

            if (_invalidUsers.Count > 0)
            {
                ErrorsText.Text += "Invalid Users(s)" + Environment.NewLine;

                foreach (string user in _invalidUsers)
                    ErrorsText.Text += "user";
            }
        }

        private bool IsUserValid(string user)
        {
            return true;
        }

        private bool HasItem(IList<Entity.PermissionEntity> list)
        {
            return list.Any(t => t.Type == "Item") || list.Any(t => t.Type == "Document");
        }

        private bool HasFolder(IList<Entity.PermissionEntity> list)
        {
            return list.Any(t => t.Type == "Folder");
        }

        private bool HasListOrLibrary(IList<Entity.PermissionEntity> list)
        {
            return list.Any(t => t.Type == "List") || list.Any(t => t.Type == "Library");
        }

        private bool HasSite(IList<Entity.PermissionEntity> list)
        {
            return list.Any(t => t.Type == "Site");
        }

        private bool _isFileContentValid;
        private RestoreExpert _restoreExpert = new RestoreExpert();

        private void RefreshFileContentPage()
        {
            DataTable table = SquadronHelper.Instance.GetDataTableFromExcel(FileText.Text);
            _isFileContentValid = IsTableValid(table) && AreTableColumnsValid(table) && IsSecurableObjectsValid(table);

            grid.DataSource = table;
            Helper.Instance.DisableSort(grid);

            if (_isFileContentValid)
            {
                FileStatusPanel.BackColor = Color.FromArgb(128, 128, 255);

                FileStatusFooterPanel.BackColor = Color.Gray;

                FileStatusPanel.Text = Constants.ApplicationTitle + " was able to read the file successfully!";

                _restoreExpert.AnalyzeTable(table);
                FileStatusFooterPanel.Text = "Please click the Next button to continue..";
            }
            else
            {
                FileStatusPanel.BackColor = Color.Red;

                FileStatusFooterPanel.BackColor = Color.Orange;

                FileStatusPanel.Text = "Invalid file content!";
                FileStatusFooterPanel.Text = _errorMessage;
            }
        }

        private bool IsSecurableObjectsValid(DataTable table)
        {
            _errorMessage = string.Empty;

            _restoreExpert.AnalyzeTable(table);

            if (_restoreExpert.TotalSecurableObjects == 0)
            {
                _errorMessage = "Total Securable Objects found in the Excel Sheet is 0!";
                return false;
            }

            return true;
        }

        private bool AreTableColumnsValid(DataTable table)
        {
            _errorMessage = string.Empty;

            IList<string> columns = new List<string>() { "Title", "Type", "Url", "PermissionType", "RoleAssignments", "RoleType", "UsersInGroup", "PermissionLevels" };

            foreach (string c in columns)
                if (!table.Columns.Cast<DataColumn>().Any(dc => dc.ColumnName == c))
                {
                    _errorMessage = "Unable to find column: " + c;
                    return false;
                }

            return true;
        }

        private string _errorMessage;

        private bool IsTableValid(DataTable table)
        {
            _errorMessage = string.Empty;

            if (table == null)
            {
                _errorMessage = "Unable to generate table from excel sheet!";
                return false;
            }

            if (table.Rows.Count == 0)
            {
                _errorMessage = "Row Count is 0!";
                return false;
            }

            return true;
        }

        private GridForm _gridFormSource;

        private void SourceFlyout_MouseMove(object sender, MouseEventArgs e)
        {
            if ((_gridFormSource == null) || (_gridFormSource.IsDisposed))
                _gridFormSource = new GridForm();

            _gridFormSource.PositionToMouse();
            _gridFormSource.Text = "Source Objects";
            _gridFormSource.Grid.DataSource = grid.DataSource;
            _gridFormSource.Execute(true);
        }

        private GridForm _gridFormDestination;

        private void DestinationFlyout_MouseMove(object sender, MouseEventArgs e)
        {
            if ((_gridFormDestination == null) || (_gridFormDestination.IsDisposed))
                _gridFormDestination = new GridForm();

            _gridFormDestination.PositionToMouse();
            _gridFormDestination.Text = "Destination Objects";
            _gridFormDestination.Grid.DataSource = _securableObjects.ToList();
            _gridFormDestination.Execute(true);
        }

        private void SourceFlyout_Click(object sender, EventArgs e)
        {
            if ((_gridFormSource == null) || (_gridFormSource.IsDisposed))
                _gridFormSource = new GridForm();

            _gridFormSource.PositionToMouse();
            _gridFormSource.Text = "Source Objects";
            _gridFormSource.Grid.DataSource = grid.DataSource;
            _gridFormDestination.IsFlyout = true;
            _gridFormSource.Execute(true);
        }

        private void DestinationFlyout_Click(object sender, EventArgs e)
        {
            if ((_gridFormDestination == null) || (_gridFormDestination.IsDisposed))
                _gridFormDestination = new GridForm();

            _gridFormDestination.PositionToMouse();
            _gridFormDestination.Text = "Destination Objects";
            _gridFormDestination.Grid.DataSource = _securableObjects.ToList();
            _gridFormDestination.IsFlyout = true;
            _gridFormDestination.Execute(true);
        }
    }
}
