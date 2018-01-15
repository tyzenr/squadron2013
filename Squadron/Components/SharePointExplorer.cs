using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Squadron;
using Squadron.Common;
using SquadronAddIns.Exceptions;
using Windows8LookNFeel;
using Microsoft.SDK.SharePointServer.Samples;
using SquadronAddIns.Default.Utility;

namespace SquadronAddIns.Default.Components
{
    public partial class SharePointExplorer : UserControl
    {
        public delegate void SelectionEventHandler(object sender, object item);
        public event SelectionEventHandler OnSelect;

        public const int FolderImageIndex = 7;
        public const int ItemImageIndex = 5;

        public SharePointExplorer()
        {
            InitializeComponent();
        }

        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; RefreshData(); }
        }

        private void RefreshData()
        {
            tv.Nodes.Clear();

            if (!string.IsNullOrEmpty(Url))
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(_url));

                    if (webApplication != null)
                        AddNode(webApplication.Name, 0, null, webApplication, true);
                    else
                        throw new InvalidURLException();
                });
        }

        public TreeNode AddNode(string text, int ix, TreeNode parent, object o, bool needDummy)
        {
            TreeNode node = null;

            if (parent == null)
                node = tv.Nodes.Add(text);
            else
                node = parent.Nodes.Add(text);

            node.ImageIndex = node.SelectedImageIndex = ix;
            node.Tag = o;

            if (needDummy)
            {
                TreeNode dummyNode = node.Nodes.Add("..");
                dummyNode.ImageIndex = dummyNode.SelectedImageIndex = 6;
            }

            return node;
        }

        private void tv_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Tag is SPListItem) || (e.Node.Tag is SPFolder))
                return;

            SquadronHelper.Instance.StartAnimation();

            try
            {
                e.Node.Nodes.Clear();

                if (e.Node.Tag is SPWebApplication)
                    ExpandWebApplication(e.Node);

                else if (e.Node.Tag is SPSite)
                    ExpandSiteCollection(e.Node);

                else if (e.Node.Tag is SPWeb)
                    ExpandSite(e.Node);

                else if (e.Node.Tag is SPList)
                    ExpandList(e.Node);

                IncludeAdditionalProperties(e.Node);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void ExpandList(TreeNode node)
        {
            ExpandListEx(node);
            return;

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPList list = (node.Tag as SPList);

                foreach (SPListItem item in list.Folders)
                {
                }

                foreach (SPListItem item in list.Items)
                    AddNode(item.DisplayName, 5, node, item, false);
            });
        }

        private void ExpandListEx(TreeNode node)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPList list = (node.Tag as SPList);

                FolderHierarchy.Explorer = this;
                FolderHierarchy.RootNode = node;
                FolderHierarchy.ProcessAllFoldersInList(list);
            });
        }

        private void ExpandSite(TreeNode node)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPWeb web = (node.Tag as SPWeb);

                foreach (SPWeb subweb in web.Webs)
                    AddNode(subweb.Title, 2, node, subweb, true);

                foreach (SPList list in web.Lists)
                    if (!list.Hidden || !excludeHiddenLists.Checked)
                        AddNode(list.Title, 3, node, list, true);
            });
        }

        private void ExpandSiteCollection(TreeNode node)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPSite site = (node.Tag as SPSite);

                foreach (SPWeb web in site.AllWebs)
                    if (web.IsRootWeb)
                        AddNode(web.Title, 2, node, web, true);
            });
        }

        private TreeNode GetParentNode(SPWeb web)
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv))
                if (node.Tag is SPWeb)
                    if (web.ID == (node.Tag as SPWeb).ID)
                        return node;

            return AddNode(web.ParentWeb.Title, 2, GetParentNode(web.ParentWeb), web.ParentWeb, true);
        }

        private void ExpandWebApplication(TreeNode node)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPWebApplication webApplication = (node.Tag as SPWebApplication);

                foreach (SPSite site in webApplication.Sites)
                    AddNode(site.RootWeb.Title, 1, node, site, true);
            });
        }

        private void tv_DoubleClick(object sender, EventArgs e)
        {

        }

        public object SelectedObject
        {
            get
            {
                if (tv.SelectedNode != null)
                    if (tv.SelectedNode.Tag != null)
                        return tv.SelectedNode.Tag;

                return null;
            }
        }

        public IList<object> SelectedObjects
        {
            get
            {
                IList<object> nodes = new List<object>();
                foreach (TreeNode node in Helper.Instance.GetAllNodes(tv))
                    if (node.Checked)
                        nodes.Add(node.Tag);

                return nodes;
            }
        }

        private void propertiesMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedObject != null)
                new PropertyDialog().ExecuteDialog(SelectedObject);
        }

        private void tv_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // SetCheckState(e.Node.Nodes, e.Node.Checked);
        }

        private void SetCheckState(TreeNodeCollection nodes, bool value)
        {
            foreach (TreeNode node in nodes)
                node.Checked = value;
        }

        private void checkAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                node.Checked = true;
        }

        private void uncheckAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                node.Checked = false;
        }

        public bool Checkboxes
        {
            get
            {
                return tv.CheckBoxes;
            }

            set
            {
                tv.CheckBoxes = value;

                checkAll.Visible = uncheckAll.Visible = line1.Visible = value;
            }
        }

        private void excludeHiddenLists_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (OnSelect != null)
            {
                SquadronHelper.Instance.StartAnimation();

                try
                {
                    OnSelect(sender, e.Node.Tag);
                }
                catch
                {
                    SquadronHelper.Instance.StopAnimation();
                }
            }
        }

        public void ExpandAllChildren()
        {
        }

        private void tv_Click(object sender, EventArgs e)
        {
        }

        private void tv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                if (tv.GetNodeAt(e.X, e.Y) != null)
                    tv.SelectedNode = tv.GetNodeAt(e.X, e.Y);
        }

        private void expandAll_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode != null)
                tv.SelectedNode.ExpandAll();

            IncludeAdditionalProperties(tv.SelectedNode);
        }

        private void siteCollectionLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode != null)
                ExpandlUptoSiteCollection();
        }

        private void ExpandlUptoSiteCollection()
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (node.Tag is SPWebApplication)
                    node.Expand();

            IncludeAdditionalProperties(tv.SelectedNode);
        }

        private void itemLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode != null)
                tv.SelectedNode.ExpandAll();
        }

        private void siteLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode != null)
                ExpandlUptoSite();
        }

        private void ExpandlUptoSite()
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (node.Tag is SPWebApplication)
                    node.Expand();

            foreach (TreeNode n in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (n.Tag is SPSite)
                    n.Expand();

            ExpandIfSPWeb(tv.SelectedNode);
            IncludeAdditionalProperties(tv.SelectedNode);
        }

        private void ExpandIfSPWeb(TreeNode node)
        {
            foreach (TreeNode n in Helper.Instance.GetAllNodes(node))
            {
                if (n.Tag is SPWeb)
                {
                    n.Expand();

                    int count = 0;
                    foreach (TreeNode n1 in n.Nodes)
                        if (n1.Tag is SPWeb)
                        {
                            ExpandIfSPWeb(n1);
                            count++;
                        }

                    if (count == 0)
                        n.Collapse();
                }
            }
        }

        private void ExpandIfSPList(TreeNode node)
        {
            foreach (TreeNode n in Helper.Instance.GetAllNodes(node))
            {
                if (n.Tag is SPWeb)
                {
                    n.Expand();

                    int count = 0;
                    foreach (TreeNode n1 in n.Nodes)
                        if (n1.Tag is SPList)
                        {
                            ExpandIfSPWeb(n1);
                            count++;
                        }
                }
            }
        }

        private void ExpandlUptoList()
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (node.Tag is SPWebApplication)
                    node.Expand();

            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (node.Tag is SPSite)
                    node.Expand();

            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (node.Tag is SPWeb)
                    node.Expand();

            ExpandIfSPList(tv.SelectedNode);
            IncludeAdditionalProperties(tv.SelectedNode);
        }

        private void listLevel_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode != null)
                ExpandlUptoList();
        }

        private void RefreshMenu_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void HideSites_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (node.Tag is SPWeb)
                    node.Remove();
        }

        private void HideLists_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (node.Tag is SPList)
                    node.Remove();
        }

        private void HideItems_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(tv.SelectedNode))
                if (node.Tag is SPListItem)
                    node.Remove();
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(tv.Width, tv.Height);
            tv.DrawToBitmap(bmp, tv.ClientRectangle);

            bmp.Save("c:\\temp\\out.bmp");
        }

        private void includeSize_Click(object sender, EventArgs e)
        {
            try
            {
                SquadronHelper.Instance.StartAnimation();

                if (tv.Nodes.Count > 0)
                    IncludeAdditionalProperties(tv.Nodes[0]);
            }
            finally 
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private SharePointUtility _utility = new SharePointUtility();
        private SizeUtility _sizeUtility = new SizeUtility();

        private void IncludeAdditionalProperties(TreeNode rootNode)
        {
            foreach (TreeNode node in Helper.Instance.GetAllNodes(rootNode))
            {
                if (!(node.Tag is SPWebApplication))
                {
                    node.Text = _utility.GetSimpleDisplayName(node.Tag);

                    IList<string> list = new List<string>();
                    if (includeSize.Checked)
                        list.Add(_sizeUtility.GetSizeOf(node.Tag).ToMB().ToString() + " MB");

                    if (includeModifiedDate.Checked)
                        list.Add(_utility.GetLastModifiedDate(node.Tag).ToShortDateString());

                    if (list.Count == 0)
                        continue;

                    node.Text += " (";

                    foreach (string s in list)
                        node.Text += s + ", ";

                    node.Text = node.Text.Substring(0, node.Text.Length - 2);

                    node.Text += ")";
                }
            }
        }

        private void modifiedDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SquadronHelper.Instance.StartAnimation();
                if (tv.Nodes.Count > 0)
                    IncludeAdditionalProperties(tv.Nodes[0]);
            }
            finally 
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        public void DeleteSelectedNode()
        {
            if (tv.SelectedNode != null)
                tv.SelectedNode.Remove();
        }
    }
}
