using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron.Core;
using System.Windows.Forms;
using Squadron.CanvasData;
using System.Data;
using Squadron.ExportData;
using Microsoft.SharePoint;
using Squadron.Others;
using Windows8LookNFeel;
using Squadron.Common;

namespace Squadron
{
    public static class SquadronContext
    {
        static SquadronContext()
        {
            _exceptionSolutionMessages.Add("Retrieving the COM class factory for component with CLSID {BDEADF26-C265-11D0-BCED-00A0C90AB50F} failed", "Squadron requires SharePoint Foundation 2010 to be installed. (Info: GAC Assemblies & Registry Entries might be missing)");

            _exceptionSolutionLinks.Add("by users who have permissions in SQL Server to read from the configuration database", "http://jeanpaulva.com/2013/03/15/knowledge-sheet-configuration-database-permission-solution/");
            _exceptionSolutionLinks.Add("SPDeletedSite", "http://jeanpaulva.com/2013/03/29/squadron-exception-unable-to-find-spdeletedsite/");
            _exceptionSolutionLinks.Add("Invalid URL!", "http://jeanpaulva.com/2013/04/01/squadron-invalid-url-exception-solutions/");

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        private static CanvasDataForm _CanvasDataForm;

        internal static CanvasDataForm CanvasDataForm
        {
            get
            {
                if (_CanvasDataForm == null)
                    _CanvasDataForm = new CanvasDataForm();

                return _CanvasDataForm;
            }
        }

        private static ExportDataForm _ExportDataForm;

        internal static ExportDataForm ExportDataForm
        {
            get
            {
                if (_ExportDataForm == null)
                    _ExportDataForm = new ExportDataForm();

                return _ExportDataForm;
            }
        }

        public static MainForm MainForm { get; set; }

        private static AddinManager _AddinManager;

        public static SquadronAddin ActiveAddin { get; set; }

        public static AddinManager AddinManager
        {
            get
            {
                if (_AddinManager == null)
                {
                    _AddinManager = new AddinManager();
                }

                return _AddinManager;
            }
        }

        public static string Url
        {
            get
            {
                return MainForm.Url;
            }
        }

        public static string DomainName
        {
            get
            {
                return MainForm.DomainText.Text;
            }
        }

        public static IEnumerable<SquadronAddin> Addins
        {
            get
            {
                return AddinManager.Addins;
            }
        }

        private static IList<string> _debugMessages = new List<string>();

        public static void WriteDebugMessage(string message)
        {
            if (MainForm.DebugMessagesChecked.Checked)
                WriteMessage("DEBUG " + message);

            else
            {
                if (_debugMessages.Count > 5)
                    _debugMessages.Clear();

                _debugMessages.Add("DEBUG " + message);
            }
        }

        public static void ClearMessages()
        {
            MainForm.LogBox.Items.Clear();
        }

        public static void WriteMessage(string message)
        {
            string context = string.Empty;
            if (ActiveAddin != null)
                context += DateTime.Now.ToLongTimeString() + " [" + ActiveAddin.Name + "] ";

            MainForm.LogBox.Items.Add(context + message);
            MainForm.LogBox.SelectedIndex = MainForm.LogBox.Items.Count - 1;

            Application.DoEvents();
        }

        public static System.Data.DataTable GetCanvasDataTable()
        {
            if (SquadronContext.HasCanvasData(false))
            {
                DataTable table = new DataTable();

                foreach (object obj in SquadronContext.CanvasDataForm.SelectedColumns.CheckedItems)
                {
                    table.Columns.Add(obj.ToString(), typeof(string));
                }

                foreach (DataRow r in (SquadronContext.CanvasDataForm.DataGrid.DataSource as DataTable).Rows)
                {
                    DataRow row = table.NewRow();

                    foreach (DataColumn c in table.Columns)
                    {
                        row[c.ColumnName] = r[c.ColumnName];
                    }

                    table.Rows.Add(row);
                }

                return table;
            }

            return null;
        }

        public static bool HasCanvasData(bool force)
        {
            if (!HasCanvasData())
                if (force)
                {
                }

            return HasCanvasData();
        }

        public static bool HasCanvasData()
        {
            bool result = (SquadronContext.CanvasDataForm.DataGrid != null)
                               && SquadronContext.CanvasDataForm.SelectedColumns.CheckedItems.Count > 0;

            return result;
        }

        private static string GetUserNames(SPWeb web)
        {
            string result = string.Empty;

            foreach (SPUser user in web.Users)
                result += user.LoginName + " ";

            return result;
        }

        public static SPUserToken GetUserToken(string url, string userName)
        {
            SPSite site = new SPSite(url);
            SPUserToken token = site.SystemAccount.UserToken;

            try
            {
                token = site.OpenWeb().Users[userName].UserToken;
            }
            catch (Exception ex)
            {
                SquadronContext.Errr(ex.ToString());
            }

            return token;
        }

        public static void Warn(string message)
        {
            MessageDialog mform = new MessageDialog();

            mform.ExecuteDialog(message, MessageType.Warning);
        }

        public static void Warn(string message, string solutionLink)
        {
            MessageDialog mform = new MessageDialog();

            mform.ExecuteDialog(message, solutionLink, MessageType.Warning);
        }

        public static void Info(string message)
        {
            MessageDialog mform = new MessageDialog();

            mform.ExecuteDialog(message, MessageType.Information);
        }

        public static void Info(string message, string solutionLink)
        {
            MessageDialog mform = new MessageDialog();

            mform.ExecuteDialog(message, solutionLink, MessageType.Information);
        }

        public static void Errr(string message)
        {
            MessageDialog mform = new MessageDialog();

            mform.ExecuteDialog(message, MessageType.Error);
        }

        public static void Errr_PleaseSelect()
        {
            Errr("Please select a valid item!");
        }

        public static void Errr(string message, string solutionLink)
        {
            MessageDialog mform = new MessageDialog();

            mform.ExecuteDialog(message, solutionLink, MessageType.Error);
        }

        public static bool Confirm(string message)
        {
            ConfirmDialog mform = new ConfirmDialog();

            return mform.ExecuteDialog(message);
        }

        public static void StartMonitoringExceptions()
        {
            _exceptionStart = _exceptions.Count;
        }

        public static string StopMonitoringExceptions()
        {
            string result = string.Empty;

            if (_exceptionStart != _exceptions.Count)
            {
                IList<string> list = new List<string>();
                for (int i = _exceptionStart; i < _exceptions.Count; i++)
                {
                    string e = _exceptions[i].ToString();
                    list.Add(e);
                    result += e + Environment.NewLine;
                }

                LogForm form = new LogForm();
                form.HeaderPanel.Text = "Exceptions";
                form.ExecuteDialog(list);
            }

            return result;
        }

        private static int _exceptionStart;
        private static IList<Exception> _exceptions = new List<Exception>();

        public static void HandleException(object contextObject, Exception ex)
        {
            _exceptions.Add(ex);

            WriteLastDebugMessages();
            WriteMessage(contextObject.ToSPString() + " " + ex.ToString());

            ShowMessageIfFoundInSolutionMessages(ex);
            ShowMessageIfFoundInSolutionLinks(ex);
        }

        public static void HandleException(Exception ex)
        {
            _exceptions.Add(ex);

            WriteLastDebugMessages();
            WriteMessage(ex.ToString());

            ShowMessageIfFoundInSolutionMessages(ex);
            ShowMessageIfFoundInSolutionLinks(ex);
        }

        private static void WriteLastDebugMessages()
        {
            bool written = false;

            foreach (string s in _debugMessages)
            {
                written = true;
                WriteMessage(s);
            }

            if (written)
                WriteMessage("(Problem could be on / after the last DEBUG item)");
        }

        private static Dictionary<string, string> _exceptionSolutionMessages = new Dictionary<string, string>();
        private static Dictionary<string, string> _exceptionSolutionLinks = new Dictionary<string, string>();

        private static void ShowMessageIfFoundInSolutionLinks(Exception ex)
        {
            string found = string.Empty;

            foreach (string keyword in _exceptionSolutionLinks.Keys)
                if (ex.ToString().ToLower().Contains(keyword.ToLower()))
                {
                    found = keyword;
                    new MessageDialog().ExecuteDialog(ex.ToString(), _exceptionSolutionLinks[keyword], MessageType.Error);
                    break;
                }

            if (!string.IsNullOrEmpty(found))
                _exceptionSolutionLinks.Remove(found);
        }

        private static void ShowMessageIfFoundInSolutionMessages(Exception ex)
        {
            string found = string.Empty;

            foreach (string keyword in _exceptionSolutionMessages.Keys)
                if (ex.ToString().ToLower().Contains(keyword.ToLower()))
                {
                    found = keyword;
                    new MessageDialog().ExecuteDialog(_exceptionSolutionMessages[keyword] + Environment.NewLine + Environment.NewLine + " Exception >> " + Environment.NewLine + ex.ToString(), MessageType.Error);
                    break;
                }
        }
    }
}
