using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint;
using System.Windows.Forms;
using Squadron;

namespace SquadronAddIns.Default.SiteStructure
{
    partial class SiteStructureControl
    {
        private TreeNode _rootNode;

        private void GenerateHierarchy(string url)
        {
            tv.Nodes.Clear();
            SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(url));

            _rootNode = tv.Nodes.Add(webApplication.Id.ToString(), GetDisplay(webApplication), 0, 0);
            _rootNode.Tag = webApplication;

            foreach (SPSite site in webApplication.Sites)
            {
                if (FilterCheck.Checked)
                    if (!site.Url.StartsWith(FilterText.Text))
                        continue;

                TreeNode node = _rootNode.Nodes.Add(site.ID.ToString(), GetDisplay(site), 1, 1);
                node.Tag = site;
                node.ToolTipText = "Site Collection";

                IterateWebs(site, node);

                Application.DoEvents();
            }

            tv.ExpandAll();

            if (_rootNode != null)
                _rootNode.EnsureVisible();
        }

        private void IterateWebs(SPSite site, TreeNode parentNode)
        {
            foreach (SPWeb web in site.AllWebs)
            {
                if (FilterCheck.Checked)
                    if (!web.Url.StartsWith(FilterText.Text))
                        continue;

                if (!web.IsRootWeb)
                    parentNode = GetParent(web.ParentWebId.ToString());

                if (parentNode == null)
                    parentNode = _rootNode;

                TreeNode node = parentNode.Nodes.Add(web.ID.ToString(), GetDisplay(web), 2, 2);
                node.Tag = web;
                node.ToolTipText = "Site";

                if (ShowListsChecked.Checked)
                    IterateLists(web, node);
            }
        }

        private void IterateLists(SPWeb web, TreeNode parentNode)
        {
            foreach (SPList list in web.Lists)
            {
                if (list.Hidden || !list.OnQuickLaunch)
                    if (!ShowHiddenChecked.Checked)
                        continue;

                int imageIndex = 3;

                if (list is SPDocumentLibrary)
                    imageIndex = 4;

                TreeNode node = parentNode.Nodes.Add(list.ID.ToString(), GetDisplay(list), imageIndex, imageIndex);
                node.Tag = list;

                if (list is SPDocumentLibrary)
                    node.ToolTipText = "Library";
                else
                    node.ToolTipText = "List";

                if (ShowItemsCheck.Checked)
                    IterateItems(list, node);
            }
        }

        private void IterateItems(SPList list, TreeNode parentNode)
        {
            foreach (SPListItem item in list.Items)
            {
                TreeNode node = parentNode.Nodes.Add(item.ID.ToString(), GetDisplay(item), 5, 5);
                node.Tag = item;
            }
        }

        private string GetDisplay(object o)
        {
            string result = string.Empty;
            try
            {
                if (o is SPWebApplication)
                {
                    result = (o as SPWebApplication).DisplayName;
                }

                else if (o is SPSite)
                {
                    result = (o as SPSite).Url;
                }

                else if (o is SPWeb)
                {
                    result = (o as SPWeb).Title;

                    if (ShowUrlsChecked.Checked)
                        if (!ShowFlatCheck.Checked)
                            result += "  [" + (o as SPWeb).Url + "]";
                }

                else if (o is SPList)
                {
                    result = (o as SPList).Title;
                    if (ShowUrlsChecked.Checked)
                        if (!ShowFlatCheck.Checked)
                            result += "  [" + (o as SPList).DefaultViewUrl + "]";

                    if (ShowItemCountCheck.Checked)
                        if (!ShowFlatCheck.Checked)
                            result += " (" + (o as SPList).Items.Count.ToString() + ")";
                }

                else if (o is SPListItem)
                {
                    result = (o as SPListItem).DisplayName;

                    if (ShowVersionCountCheck.Checked)
                        if (!ShowFlatCheck.Checked)
                            result += " (" + (o as SPListItem).Versions.Count.ToString() + ")";
                }
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            return result;
        }

        private HashSet<TreeNode> _allNodes = new HashSet<TreeNode>();

        private TreeNode GetParent(string key)
        {
            _allNodes.Clear();
            CallRecursive(tv);

            foreach (TreeNode node in _allNodes)
                if (node.Name == key)
                    return node;

            return null;
        }

        private void PrintRecursive(TreeNode treeNode)
        {
            _allNodes.Add(treeNode);

            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        private void CallRecursive(TreeView treeView)
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                PrintRecursive(n);
            }
        }
    }
}
