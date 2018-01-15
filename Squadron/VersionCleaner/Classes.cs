using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace SquadronAddIns.Default.VersionCleaner
{
    class VersionGridItem
    {
        public VersionGridItem()
        {
            VersionItems = new HashSet<VersionItem>();
        }

        [Browsable(false)]
        public SPListItem Item
        {
            get;
            set;
        }

        public string ListTitle
        {
            get;
            set;
        }

        public string ItemTitle
        {
            get;
            set;
        }

        public int VersionCount
        {
            get;
            set;
        }

        [Browsable(false)]
        public HashSet<VersionItem> VersionItems
        {
            get;
            set;
        }
    }

    class VersionItem
    {
        public SPListItemVersion Item
        {
            get;
            set;
        }
    }

    class ListListItem
    {
        public string Title
        {
            get;
            set;
        }

        public SPList Item
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
