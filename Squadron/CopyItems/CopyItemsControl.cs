using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Squadron;
using System.Web.UI.WebControls;

namespace SquadronAddins.Default.CopyItems
{
    public partial class CopyItemsControl : UserControl
    {
        private bool _connectedToDest;
        private SPSite _sourceSite, _destinationSite;
        private SPWeb _sourceWeb, _destinationWeb;

        public CopyItemsControl()
        {
            InitializeComponent();

            Url1.Text = Url2.Text = SquadronContext.Url;
        }

        private void Refresh1_Click(object sender, EventArgs e)
        {
            copyControl1.ClearAll();

            RefreshList1();
        }

        private IList<string> _titles = new List<string>();

        private void RefreshList1()
        {
            List1.Items.Clear();
            _titles.Clear();

            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    _sourceSite = new SPSite(Url1.Text);
                    _sourceWeb = _sourceSite.OpenWeb();

                    foreach (SPList list in _sourceWeb.Lists)
                    {
                        if (list.Hidden || list.BaseType == SPBaseType.DocumentLibrary)
                            continue;

                        string value = list.Title;

                        value += "  (" + list.Items.Count.ToString() + ")";

                        List1.Items.Add(value);
                        _titles.Add(list.Title);
                    }
                });
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (InputsValid())
            {
                StartCopying();
            }
        }

        private void StartCopying()
        {
            var copyItemControls = copyControl1.GetCopyControls();

            pbr1.Value = 0;
            pbr1.Maximum = copyItemControls.Count();

            foreach (CopyItemControl control in copyItemControls)
            {
                SPList sourceList = _sourceWeb.Lists[control.SourceListName];
                SPList destList = GetDestinationList(_sourceWeb, _destinationWeb, control.SourceListName, control.DestinationListName);

                pbr2.Maximum = sourceList.Items.Count;

                CopyItems(sourceList, destList);

                pbr1.Value++;

                SquadronContext.WriteMessage("Copied " + sourceList.Items.Count.ToString() + " item(s) to " + control.DestinationListName);
            }

            SquadronContext.WriteMessage("Completed!");
        }

        private void CopyItems(SPList sourceList, SPList destList)
        {
            pbr2.Value = 0;

            foreach (SPListItem item in sourceList.Items)
            {
                CopyItem(item, destList);

                pbr2.Value++;
            }
        }

        private void CopyItem(SPListItem item, SPList destList)
        {
            SPListItem newItem = destList.Items.Add();
            for (int i = 0; i < item.Fields.Count; i++)
                if ((!newItem.Fields[i].ReadOnlyField) && (newItem.Fields[i].InternalName != "Attachments"))
                    newItem[newItem.Fields[i].InternalName] = item[newItem.Fields[i].InternalName];

            newItem.Update();
        }

        private bool InputsValid()
        {
            if (List1.CheckedItems.Count == 0)
            {
                SquadronContext.Errr("Please select atleast one Source List!");
                return false;
            }

            if (!_connectedToDest)
            {
                SquadronContext.Errr("Unable to connect to Destination Server!" + Environment.NewLine + "Please retry changing url / user.");
                return false;
            }

            if (copyControl1.GetCopyControls().Count() == 0)
            {
                SquadronContext.Errr("No valid Destination Lists!");
                return false;
            }

            return true;
        }

        private SPList GetDestinationList(SPWeb sourceWeb, SPWeb destinationWeb, string sourceTitle, string destTitle)
        {
            if (destinationWeb.Lists.Cast<SPList>().Any(l => l.Title == destTitle))
                return destinationWeb.Lists[destTitle];

            return CreateList(sourceWeb, destinationWeb, sourceTitle, destTitle);
        }

        private SPList CreateList(SPWeb sourceWeb, SPWeb destinationWeb, string sourceTitle, string destTitle)
        {
            SPList dlist = null;

            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPList slist = sourceWeb.Lists[sourceTitle];
                    Guid dguid = destinationWeb.Lists.Add(destTitle, slist.Description, slist.BaseTemplate);

                    dlist = destinationWeb.Lists[dguid];
                    dlist.OnQuickLaunch = slist.OnQuickLaunch;
                    dlist.Update();
                });

            return dlist;
        }

        private IEnumerable<string> GetCheckedListTitles()
        {
            foreach (int ix in List1.CheckedIndices)
                yield return _titles[ix];
        }

        private void Refresh2_Click(object sender, EventArgs e)
        {
            copyControl1.ClearAll();

            ConnectToDestServer();

            if (_connectedToDest)
            {
                foreach (string title in GetCheckedListTitles())
                    copyControl1.AddItem(title, _sourceWeb, _destinationWeb);
            }
        }

        private void ConnectToDestServer()
        {
            _connectedToDest = false;

            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    try
                    {
                        _destinationSite = new SPSite(Url2.Text);
                        _destinationWeb = _destinationSite.OpenWeb();

                        _connectedToDest = true;
                    }
                    catch (Exception ex)
                    {
                        SquadronContext.Errr("Unable to connect to Destination Server!" + Environment.NewLine + ex.ToString());
                    }
                });
        }

        private void List1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (_connectedToDest)
                    copyControl1.AddItem(_titles[e.Index].ToString(), _sourceWeb, _destinationWeb);
            }

            if (e.NewValue == CheckState.Unchecked)
            {
                copyControl1.RemoveItem(_titles[e.Index].ToString(), _sourceWeb, _destinationWeb);
            }
        }
    }
}
