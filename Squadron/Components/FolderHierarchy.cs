using System;

using Microsoft.SharePoint;
using Microsoft.Office.Server.Utilities;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using SquadronAddIns.Default.Components;
using Squadron;

namespace Microsoft.SDK.SharePointServer.Samples
{
    public static class FolderHierarchy
    {
        public static TreeNode RootNode;
        public static SharePointExplorer Explorer;

        private static void ProcessFolder(SPFolder folder)
        {
            SPQuery query = new SPQuery();
            query.Folder = folder;
            SPListItemCollection items = folder.ParentWeb.Lists[folder.ParentListId].GetItems(query);

            foreach (SPListItem item in items)
                Explorer.AddNode(item.DisplayName, GetImageIndex(item), GetNode(folder), GetItemOrFolder(item), false);
        }

        private static object GetItemOrFolder(SPListItem item)
        {
            if (item.Folder == null)
                return item;

            return item.Folder;
        }

        private static int GetImageIndex(SPListItem item)
        {
            if (item.Folder == null)
                return SharePointExplorer.ItemImageIndex;

            return SharePointExplorer.FolderImageIndex;
        }

        private static TreeNode GetNode(SPFolder folder)
        {
            if (string.IsNullOrEmpty(folder.ParentFolder.Name))
                return RootNode;

            var nodes = Helper.Instance.GetAllNodes(RootNode);
            foreach (TreeNode node in nodes)
                if (node.ImageIndex == SharePointExplorer.FolderImageIndex)
                    if (node.Text == folder.Name)
                        return node;

            return RootNode;
        }

        private static void HandleThrottledException(SPException ex)
        {
            // This means the folder hierarchy could not be retrieved.  This happens if all of the following are true:
            // 1. the list does not have an index on the content type ID field (see ContentIterator.ListHasIndexedContentType(SPList))
            // 2. the list was large enough that the folder items could not be queried directly
            // 3. at least one folder in the hierarchy had enough subfolders that SPFolder.SubFolders was also throttled
            //
            // If this happens, there is no way get the folder hierarchy and the SPBuiltInFieldId.ContentTypeId field must
            // be indexed.
        }

        private static void ProcessFolderRecursively(SPFolderHierarchy folders, SPFolder folder)
        {
            ProcessFolder(folder);

            SPFolderHierarchy subFolders = folders.GetSubFolders(folder.ServerRelativeUrl);
            foreach (SPFolder subfolder in ((IEnumerable<SPFolder>)subFolders))
            {
                ProcessFolderRecursively(folders, subfolder);
            }
        }

        public static void ProcessAllFoldersInList(SPList list)
        {
            string viewFields = ContentIterator.FolderCoreViewFields +
                "<FieldRef Name=\"ItemChildCount\"/>" +
                "<FieldRef Name=\"FolderChildCount\"/>";

            // Handle the root web separately since it is not contained in the hierarchy
            ProcessFolder(list.RootFolder);

            // Check if the list has folders other than the root folder
            if (!SPFolderHierarchy.ListHasFolders(list))
                return;

            try
            {
                SPFolderHierarchy folders = new SPFolderHierarchy(list, true, viewFields, true);

                Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
                    "Total # of folders in list:  {0}",
                    folders.Count));

                SPFolderHierarchy subFolders = folders.GetSubFolders(list.RootFolder.ServerRelativeUrl);
                foreach (SPFolder subfolder in ((IEnumerable<SPFolder>)subFolders))
                {
                    ProcessFolderRecursively(folders, subfolder);
                }
            }
            catch (SPQueryThrottledException ex)
            {
                HandleThrottledException(ex);
            }
        }
    }
}
