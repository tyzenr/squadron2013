using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Squadron.Common;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Reflection;
using Microsoft.SharePoint.Utilities;
using System.Net;

namespace Squadron
{
    public class Helper
    {
        private static Helper _Instance;

        public static Helper Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Helper();

                return _Instance;
            }
        }

        private Helper()
        {
        }

        public string GetExecutionFolder()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        public double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        public double ConvertBytesToGigabytes(long bytes)
        {
            return ((bytes / 1024f) / 1024f) / 1024f;
        }


        public string FormatDouble(double Amount)
        {
            return Amount.ToString("0.00");
        }

        private IList<Control> ControlsList = new List<Control>();

        /// <summary>
        /// Returns a list of controls in Container
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public IEnumerable<Control> GetControlsRecursively(Control container)
        {
            ControlsList.Clear();
            FindControlsRecursively(container);

            return ControlsList;
        }

        public bool InDevelopment()
        {
            return System.Diagnostics.Debugger.IsAttached;
        }

        private void FindControlsRecursively(Control container)
        {
            foreach (Control control in container.Controls)
            {
                ControlsList.Add(control);
                if (container.HasChildren)
                    FindControlsRecursively(control);
            }
        }

        public int GetRowCount(DataGridView grid)
        {
            if (grid.DataSource != null)
            {
                if (grid.DataSource is DataTable)
                    return (grid.DataSource as DataTable).Rows.Count;

                else
                    return (grid.Rows.Count);
            }

            return 0;
        }

        public object GetDataSource(Control control)
        {
            if (control is DataGridView)
                return (control as DataGridView).DataSource;

            return null;
        }

        public void RefreshGridData(DataGridView grid)
        {
            DataTable table = (grid.DataSource as DataTable);

            grid.DataSource = null;
            grid.DataSource = table;

            Application.DoEvents();
        }

        public DataTable ConvertToDataTable(IList data)
        {
            Type type = null;
            IList<string> nonBrowsableProperties = new List<string>();
            if (data.Count > 0)
            {
                type = data[0].GetType();
                foreach (PropertyInfo pinfo in type.GetProperties())
                    foreach (Attribute attr in pinfo.GetCustomAttributes(true))
                        if (attr is BrowsableAttribute)
                            if (!(attr as BrowsableAttribute).Browsable)
                                nonBrowsableProperties.Add(pinfo.Name);
            }

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(type);
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                if (!nonBrowsableProperties.Contains(prop.Name))
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (object item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    if (!nonBrowsableProperties.Contains(prop.Name))
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }

        public void WaitWithDoEvents(int seconds)
        {
            DateTime start = DateTime.Now;

            while (true)
            {
                DateTime end = DateTime.Now;
                TimeSpan span = end - start;

                if (span.TotalSeconds > seconds)
                    break;

                Thread.Sleep(100);
            }
        }

        private int _GCCount;

        public void InvokeGarbageCollection()
        {
            _GCCount++;

            if ((_GCCount % 100) == 0)
                GC.Collect();
        }

        public string ToMB(long value)
        {
            return (value / 1024000) + " MB";
        }

        public void CenterControl(Control control)
        {
            control.Left = (control.Parent.Width - control.Width) / 2;
            control.Top = (control.Parent.Height - control.Height) / 2;
        }

        private string GetApplicationTitle()
        {
            return Constants.ApplicationTitle;
        }

        public string GetStringAfter(string mainString, string subString)
        {
            string result = mainString;

            if (!string.IsNullOrEmpty(result))
                if (result.Contains(subString))
                    result = result.Substring(result.LastIndexOf(subString) + 1, result.Length - result.LastIndexOf(subString) - 1);

            return result;
        }

        public string FormatBool(bool value)
        {
            if (value)
                return "Yes";

            else
                return "No";
        }

        public object GetRowCount(ListBox listBox)
        {
            return listBox.Items.Count;
        }

        public bool IsUrlStartingWith(string url1, string url2)
        {
            if (url1.EndsWith("/") && !url2.EndsWith("/"))
                url2 += "/";

            if (!url1.EndsWith("/") && url2.EndsWith("/"))
                url1 += "/";

            return url1.StartsWith(url2);
        }

        public void ResizeRowsToFit(DataGridView grid)
        {
            if (grid.Width > (grid.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).Sum(c => c.Width) + 20))
            {
                int widthRequired = (grid.Width - 100) / grid.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).Count();

                foreach (DataGridViewColumn column in grid.Columns)
                    if (column.Visible)
                        column.Width = widthRequired;
            }
        }

        public int Int(string text)
        {
            try
            {
                return Int32.Parse(text);
            }
            catch
            {
            }

            return 0;
        }

        public int Int(object o)
        {
            if (o != null)
                return Int(o.ToString());

            return 0;
        }

        [DllImport("user32.dll", EntryPoint = "ShowCaret")]
        public static extern long ShowCaret(long hwnd);

        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        public static extern long HideCaret(long hwnd);

        public void ShowCaret(TextBox tbx)
        {
            ShowCaret(tbx.Handle.ToInt64());
        }

        public void HideCaret(TextBox tbx)
        {
            HideCaret(tbx.Handle.ToInt64());
        }

        public void DisableSort(DataGridView grid)
        {
            foreach (DataGridViewColumn column in grid.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void CheckAll(CheckedListBox box)
        {
            for (int i = 0; i < box.Items.Count; i++)
                box.SetItemChecked(i, true);
        }

        public void UncheckAll(CheckedListBox box)
        {
            for (int i = 0; i < box.Items.Count; i++)
                box.SetItemChecked(i, false);
        }

        public bool AreUrlsEqual(string url1, string url2)
        {
            url1 = RemoveTrailingSlash(url1);
            url2 = RemoveTrailingSlash(url2);

            bool result = url1.ToLower().Equals(url2.ToLower());

            return result;
        }

        private string RemoveTrailingSlash(string url)
        {
            if (url.EndsWith("\\"))
                url = url.Substring(0, url.Length - 1);

            return url;
        }

        public string GetType(object so)
        {
            if (so is SPWebApplication)
                return "Web Application";

            else if (so is SPSite)
                return "Site Collection";

            else if (so is SPWeb)
                return "Site";

            else if (so is SPList)
                return "List";

            else if (so is SPListItem)
            {
                if ((so as SPListItem).Folder == null)
                    return "Item";
                else
                    return "Folder";
            }

            return "Unknown";
        }

        public string GetUrl(object so)
        {
            if (so is SPWebApplication)
                return (so as SPWebApplication).OfficialFileUrl.ToString();

            else if (so is SPSite)
                return (so as SPSite).Url;

            else if (so is SPWeb)
                return (so as SPWeb).Url;

            else if (so is SPList)
                return (so as SPList).DefaultViewUrl;

            else if (so is SPListItem)
                return (so as SPListItem).Url;

            return string.Empty;
        }

        private IList<TreeNode> _nodes;

        public IEnumerable<TreeNode> GetAllNodes(TreeView tv)
        {
            _nodes = new List<TreeNode>();

            InternalGetAllNodes(tv.Nodes.Cast<TreeNode>());

            return _nodes;
        }

        public IEnumerable<TreeNode> GetAllNodes(TreeNode node)
        {
            _nodes = new List<TreeNode>();

            IList<TreeNode> list = new List<TreeNode>();
            list.Add(node);

            InternalGetAllNodes(list);

            return _nodes;
        }

        private void InternalGetAllNodes(IEnumerable<TreeNode> collection)
        {
            foreach (TreeNode node in collection)
            {
                _nodes.Add(node);

                if (node.Nodes.Count > 0)
                    InternalGetAllNodes(node.Nodes.Cast<TreeNode>());
            }
        }

        public void RegisterToGAC(string path)
        {
            try
            {
                foreach (string file in Directory.GetFiles("*.dll"))
                {
                    Assembly a = Assembly.LoadFile(file);
                }
            }
            catch
            {
            }
        }

        public string GetPowerShellPath()
        {
            string path = GetSystem32Path() + "\\WindowsPowerShell\\v1.0\\PowerShell.exe";

            return path;
        }

        public string GetSharePointPS1Path()
        {
            string path = SPUtility.GetGenericSetupPath(string.Empty) + "CONFIG\\POWERSHELL\\Registration\\sharepoint.ps1";

            return path;
        }

        public string GetPowerShellISEPath()
        {
            string path = GetSystem32Path() + "\\WindowsPowerShell\\v1.0\\PowerShell_ise.exe";

            return path;
        }

        private string GetSystem32Path()
        {
            return Environment.SystemDirectory;
        }

        public void RearrangeColumns(DataGridView grid)
        {
            int totalWidthPossible = grid.Width - 70;
            int visibleColumnCount = grid.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).Count();

            if (visibleColumnCount > 0)
            {
                int columnWidth = totalWidthPossible / visibleColumnCount;

                int visibleColumnsWidth = grid.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).Sum(c => c.Width);

                if (visibleColumnsWidth < (columnWidth * visibleColumnCount))
                {
                    foreach (var c in grid.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible))
                        c.Width = columnWidth;
                }
            }
        }

        public string GetDomainName()
        {
            string result = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;

            if (result.Contains("."))
                result = result.Substring(0, result.IndexOf("."));

            result = result.ToUpper();

            return result;
        }

        public string GetFullyQualifiedDomainName()
        {
            string result = "";

            string domainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            string hostName = Dns.GetHostName();

            if (!hostName.Contains(domainName))
                result = hostName + "." + domainName;
            else
                result = hostName;

            return result;
        }

        public string GetIndented(string title, object o)
        {
            title = title.Trim();

            if (o is SPWeb)
                title = "      " + title;

            else if (o is SPList)
                title = "            " + title;

            else if (o is SPItem)
                title = "                  " + title;

            return title;
        }

        public string ExtractFileName(string filename)
        {
            if (String.IsNullOrEmpty(filename))
                return "";
            else
                return filename.Substring(filename.LastIndexOf('\\') + 1);
        }

        public string ExtractFolder(string filename)
        {
            if (String.IsNullOrEmpty(filename))
                return "";
            else
                return filename.Substring(0, filename.LastIndexOf('\\'));
        }
    }
}
