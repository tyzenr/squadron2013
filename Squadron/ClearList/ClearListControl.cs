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

namespace SquadronAddins.Default.EmptyList
{
    public partial class ClearListControl : UserControl
    {
        public ClearListControl()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshWithCountButton_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private IList<string> _listTitles = new List<string>();

        private void RefreshList()
        {
            NameList.Items.Clear();
            _listTitles.Clear();

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {

                using (SPSite site = new SPSite(SquadronContext.Url))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        foreach (SPList list in web.Lists)
                        {
                            if ((list.Hidden || !list.OnQuickLaunch) && !ShowHiddenCheck.Checked)
                                continue;

                            string value = list.Title;

                            if (CountCheck.Checked)
                                value += "  (" + list.Items.Count.ToString() + ")";

                            NameList.Items.Add(value);
                            _listTitles.Add(list.Title);
                        }
                    }
                }
            });
        }

        private void EmptyButton_Click(object sender, EventArgs e)
        {
            if (NameList.CheckedItems.Count == 0)
                SquadronContext.Info("Please check atleast one item!");

            if (NameList.CheckedItems.Count > 0)
                if (SquadronContext.Confirm("Are you sure you wanted to Clear the selected list/library?" +
                    Environment.NewLine + "List: " + GetSelectedTitles() + Environment.NewLine + Environment.NewLine +
                    "(If this is a Production Server, Please ensure you have Sufficient Backups)"))
                    PerformEmpty();
        }

        private string GetSelectedTitles()
        {
            string result = string.Empty;

            foreach (object item in NameList.CheckedItems)
                result += item.ToString() + ", ";

            if (result.Length > 0)
                result = result.Substring(0, result.Length - 2);

            return result;
        }

        private void PerformEmpty()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (SPSite site = new SPSite(SquadronContext.Url))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        foreach (int ix in NameList.CheckedIndices)
                        {
                            string title = _listTitles[ix];
                            SPList list = web.Lists[title];
                            int count = list.Items.Count;

                            for (int x = list.Items.Count - 1; x >= 0; x--)
                            {
                                list.Items[x].Delete();
                            }

                            SquadronContext.WriteMessage(title + " EMPTY performed by deleting " + count.ToString() + " items");
                        }
                    }
                }
            });

            SquadronContext.WriteMessage("Performed Empty operations.");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NameList.CheckedItems.Count == 0)
                SquadronContext.Info("Please check atleast one item!");

            if (NameList.CheckedItems.Count > 0)
                if (SquadronContext.Confirm("Are you sure you wanted to DELETE the selected list/library?" +
                    Environment.NewLine + "List: " + GetSelectedTitles() + Environment.NewLine + Environment.NewLine +
                    "(If this is a Production Server, Please ensure you have Sufficient Backups)")) ;
            PerformDelete();
        }

        private void PerformDelete()
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (SPSite site = new SPSite(SquadronContext.Url))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        foreach (string title in NameList.CheckedItems)
                        {
                            SPList list = web.Lists[title];

                            try
                            {
                                list.Delete();

                                SquadronContext.WriteMessage(title + " DELETE done.");
                            }
                            catch (Exception ex)
                            {
                                SquadronContext.WriteMessage("DELETE Exception for " + title + " " + ex.ToString());
                            }
                        }
                    }
                }
            });

            SquadronContext.WriteMessage("Performed DELETE operations.");
            RefreshList();
        }

        private void ShowHiddenCheck_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void CountCheck_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }}
}
