using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron;
using SquadronAddIns.Exceptions;
using SquadronAddIns.Default.Utility;
using Microsoft.SharePoint;
using System.Diagnostics;

namespace SquadronAddIns.Default.VersionCleaner
{
    public partial class VersionCleanerControl : UserControl
    {
        public VersionCleanerControl()
        {
            InitializeComponent();

            RefreshData();

            if (Debugger.IsAttached)
            {
                //list.Items.Add(new ListListItem() { Title = "ExpDocs", Item = new SPSite("http://hp").RootWeb.Lists["Expdocs"] }, true);
            }
        }

        public void RefreshData()
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                explorer.Url = SquadronContext.Url;
            }
            catch (InvalidURLException iex)
            {
                SquadronContext.Errr(iex.Message.ToString(), "http://jeanpaulva.com/2013/04/01/squadron-invalid-url-exception-solutions/");
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void explorer_OnSelect(object sender, object item)
        {
            RefreshListAndLibraries(item);
        }

        private SharePointUtility _utility = new SharePointUtility();

        private void RefreshListAndLibraries(object item)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    list.Items.Clear();

                    if (item is SPList)
                        AddListItem(item);

                    else if (item is SPWeb)
                        foreach (SPList l in (item as SPWeb).Lists)
                            AddListItem(l);

                    CheckAll();
                });
        }

        private void AddListItem(object item)
        {
            list.Items.Add(new ListListItem() { Title = (item as SPList).Title, Item = item as SPList });
        }

        private void CheckAll()
        {
            for (int i = 0; i < list.Items.Count; i++)
                list.SetItemChecked(i, true);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (list.CheckedItems.Count == 0)
                SquadronContext.Warn("No list(s) selected!" + Environment.NewLine + "Please choose a Site from Step 1 & Select a list from Step 2!");
            else
            {
                SquadronHelper.Instance.StartAnimation();

                try
                {
                    FindVersions();
                }
                finally
                {
                    SquadronHelper.Instance.StopAnimation();
                }
            }
        }

        private HashSet<VersionGridItem> _versions = new HashSet<VersionGridItem>();

        private void FindVersions()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                _versions.Clear();
                int count = Helper.Instance.Int(CountText.Text);

                foreach (SPList list in GetLists())
                    foreach (SPListItem item in list.Items)
                    {
                        VersionGridItem gridItem = new VersionGridItem() { Item = item, ListTitle = list.Title, ItemTitle = _utility.GetSimpleDisplayName(item) };

                        foreach (SPListItemVersion v in item.Versions)
                            if (!v.IsCurrentVersion)
                                if ((DateTime.Now - v.Created).TotalDays > count)
                                    gridItem.VersionItems.Add(new VersionItem() { Item = v });

                        gridItem.VersionCount = gridItem.VersionItems.Count;

                        if (gridItem.VersionItems.Count > 0)
                            _versions.Add(gridItem);
                    }

                grid.DataSource = _versions.ToList();
            });

            if (_versions.Count == 0)
                SquadronContext.WriteMessage("No item(s) found matching criteria!");
        }

        private IEnumerable<SPList> GetLists()
        {
            foreach (object o in list.CheckedItems)
                if (o is ListListItem)
                    yield return ((o as ListListItem).Item as SPList);
        }

        private void MoveToRecycleBinButton_Click(object sender, EventArgs e)
        {
            MoveToRecycleBin();
        }

        private void MoveToRecycleBin()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    List<SPListItemVersion> selectedList = new List<SPListItemVersion>();

                    foreach (VersionGridItem vgi in _versions)
                        foreach (SPListItemVersion v in vgi.Item.Versions)
                            if (!v.IsCurrentVersion)
                                selectedList.Add(v);

                    DoAction(selectedList, false);
                });
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteVersions();
        }

        private void DeleteVersions()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    List<SPListItemVersion> selectedList = new List<SPListItemVersion>();

                    foreach (VersionGridItem vgi in _versions)
                        foreach (SPListItemVersion v in vgi.Item.Versions)
                            if (!v.IsCurrentVersion)
                                selectedList.Add(v);

                    DoAction(selectedList, true);
                });
        }

        private void DoAction(List<SPListItemVersion> selectedList, bool delete)
        {
            string message = "Operation completed successfully!" + Environment.NewLine + selectedList.Count.ToString() + " version(s) ";
            if (delete)
                message += " Deleted!";
            else
                message += " Recycled!";

            bool hasErrors = false;
            int count = selectedList.Count;

            while (count > 0)
            {
                try
                {
                    var v = selectedList[count - 1];

                    if (delete)
                        v.Delete();
                    else
                        v.Recycle();

                    selectedList.RemoveAt(count - 1);
                }
                catch (Exception ex)
                {
                    SquadronContext.WriteMessage(ex.ToString());
                    hasErrors = true;
                }
                count--;
            }

            if (!hasErrors)
            {
                _versions.Clear();
                grid.DataSource = _versions;

                SquadronContext.Info(message);
            }
        }
    }
}
