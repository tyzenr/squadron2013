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
using SquadronAddIns.Default.SiteStructure.Entity;
using Microsoft.SharePoint.Administration;

namespace SquadronAddIns.Default.SiteStructure
{
    public partial class SiteStructureControl : UserControl
    {
        public SiteStructureControl()
        {
            InitializeComponent();

            FilterText.Text = SquadronContext.Url;
            EnableDisable();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SquadronHelper.Instance.StartAnimation();

                // Show / Hide controls
                grid.Visible = ShowFlatCheck.Checked;
                tv.Visible = !grid.Visible;

                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    string url = SquadronContext.Url;

                    if (ShowFlatCheck.Checked)
                    {
                        GenerateHierarchy(url);
                        ShowInGrid();
                    }
                    else
                    {
                        GenerateHierarchy(url);
                    }
                });
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private IList<TreeNode> _flatNodes = new List<TreeNode>();

        private void ShowInGrid()
        {
            IList<ItemInfo> list = new List<ItemInfo>();
            _flatNodes.Clear();
            PrintRecursive2(tv.Nodes[0]);

            foreach (TreeNode node in _flatNodes)
            {
                ItemInfo info = new ItemInfo();
                info.Title = node.Text;
                info.Type = GetType(node.Tag);
                info.Url = GetUrl(node.Tag);

                if (ShowItemCountCheck.Checked)
                    info.ItemCount = GetItemCount(node.Tag);

                if (ShowVersionCountCheck.Checked)
                    info.VersionCount = GetVersionCount(node.Tag);

                info.InternalObject = node.Tag;

                list.Add(info);
            }

            grid.DataSource = null;
            grid.DataSource = list;

            // Hide unwanted columns
            if (!ShowUrlsChecked.Checked)
                grid.Columns["Url"].Visible = false;

            if (!ShowItemCountCheck.Checked)
                grid.Columns["ItemCount"].Visible = false;

            if (!ShowVersionCountCheck.Checked)
                grid.Columns["VersionCount"].Visible = false;
        }

        private string GetUrl(object o)
        {
            if (o is SPSite)
                return (o as SPSite).Url;

            else if (o is SPWeb)
                return (o as SPWeb).Url;

            else if (o is SPList)
                return (o as SPList).DefaultViewUrl;

            else if (o is SPListItem)
                return (o as SPListItem).Url;

            return string.Empty;
        }

        private string GetVersionCount(object o)
        {
            try
            {
                if (o is SPListItem)
                    return (o as SPListItem).Versions.Count.ToString();

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return string.Empty;
        }

        private string GetItemCount(object o)
        {
            if (o is SPList)
                return (o as SPList).Items.Count.ToString();

            return string.Empty;
        }

        private void PrintRecursive2(TreeNode treeNode)
        {
            _flatNodes.Add(treeNode);
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive2(tn);
            }
        }

        private void CallRecursive2(TreeView treeView)
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                PrintRecursive2(n);
            }
        }

        private string GetType(object o)
        {
            if (o is SPSite)
                return "Site Collection";

            else if (o is SPWeb)
                return "Site";

            else if (o is SPDocumentLibrary)
                return "Library";

            else if (o is SPList)
                return "List";

            else if (o is SPListItem)
                return "Item";

            return "IIS Web Application";
        }

        private void GenerateSiteParentInformation()
        {
            HashSet<SiteParentInfo> hashset = new HashSet<SiteParentInfo>();

            SPWebApplication application = SPWebApplication.Lookup(new Uri(SquadronContext.Url));
            foreach (SPSite site in application.Sites)
            {
                GetSiteParentInfo(hashset, site);
            }

            grid.DataSource = hashset.ToList();
        }

        private void GetSiteParentInfo(HashSet<SiteParentInfo> hashset, SPSite site)
        {
            foreach (SPWeb web in site.AllWebs)
            {
                var info = new SiteParentInfo() { Title = web.Title, Url = web.Url };

                if (web.IsRootWeb)
                {
                    info.Root = "[Root]";
                }
                else
                {
                    info.ParentSiteTitle = web.ParentWeb.Title;
                    info.ParentSiteUrl = web.ParentWeb.Url;

                    SPWeb rootWeb = GetRootWeb(web);

                    if (rootWeb != null)
                    {
                        info.RootSiteTitle = rootWeb.Title;
                        info.RootSiteUrl = rootWeb.Url;
                    }
                }

                hashset.Add(info);
            }
        }

        private SPWeb GetRootWeb(SPWeb web)
        {
            SPWeb result = web;

            while (result.ParentWeb != null)
                result = result.ParentWeb;

            return result;
        }

        public IList<SPWeb> _webList = new List<SPWeb>();

        private object GetText(string text, int level)
        {
            string result = new string('\t', level) + text;

            return result;
        }

        private int GetLevel(SPWeb web)
        {
            int level = 0;

            SPWeb parent = web.ParentWeb;

            while (parent != null)
            {
                parent = parent.ParentWeb;
                level++;
            }

            return level;
        }

        private void ShowListsChecked_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisable();
        }

        private void ParentCheck_CheckStateChanged(object sender, EventArgs e)
        {
            EnableDisable();
        }

        private void EnableDisable()
        {
            //  Helper.Instance.GetControlsRecursively(this).OfType<CheckBox>().ToList().ForEach(c => c.Enabled = !ShowFlatCheck.Checked);
            ShowFlatCheck.Enabled = true;

            ShowItemCountCheck.Enabled = ShowHiddenChecked.Enabled = ShowListsChecked.Checked;

            ShowVersionCountCheck.Enabled = ShowItemsCheck.Checked;
        }

        private void ShowPropertyGridCheck_CheckedChanged(object sender, EventArgs e)
        {
            propertyGrid.Visible = ShowPropertyGridCheck.Checked;
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                if (tv.SelectedNode != null)
                    propertyGrid.SelectedObject = tv.SelectedNode.Tag;
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                if (grid.SelectedRows.Count > 0)
                    if (grid.Rows[grid.SelectedRows[0].Index].DataBoundItem != null)
                        propertyGrid.SelectedObject = (grid.Rows[grid.SelectedRows[0].Index].DataBoundItem as ItemInfo).InternalObject;
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            FilterText.Visible = FilterCheck.Checked;
        }
    }
}
