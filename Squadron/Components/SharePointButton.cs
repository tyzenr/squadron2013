using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows8LookNFeel;
using SquadronAddIns.Default.Components.Dialogs;
using SquadronAddIns.Default.Utility;
using Squadron;
using System.Windows.Forms;

namespace SquadronAddIns.Default.Components
{
    public class SharePointButton : Windows8LookNFeel.Windows8Button
    {
        public SharePointButton()
        {
            _selectedAll = true;
            this.Text = "Selected: All Objects";
            this.Click += new EventHandler(SharePointButton_Click);

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this, "Click to select the SharePoint objects");
        }

        private bool _selectedAll;
        private IList<object> _selectedObjects;

        public delegate void SelectionChangedEventHandler(object sender);
        public event SelectionChangedEventHandler OnSelectionChanged;

        void SharePointButton_Click(object sender, EventArgs e)
        {
            ExplorerDialog dialog = new ExplorerDialog();
            dialog.explorer.Url = SquadronContext.Url;

            bool result = dialog.ExecuteDialog();

            if (result)
            {
                _selectedAll = false;
                _selectedObjects = dialog.SelectedObjects;
                this.Text = "SharePoint Objects: " + _selectedObjects.Count.ToString();

                if (OnSelectionChanged != null)
                    OnSelectionChanged(this);
            }
        }

        private SharePointUtility _utility = new SharePointUtility();

        public IList<object> SelectedObjects
        {
            get
            {
                SquadronHelper.Instance.StartAnimation();

                try
                {
                    if (_selectedAll)
                        return _utility.GetSharePointObjects(SquadronContext.Url);

                    else
                        return _selectedObjects;
                }
                finally
                {
                    SquadronHelper.Instance.StopAnimation();
                }
            }
        }
    }
}
