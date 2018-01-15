using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using SquadronAddIns.Default.Diagnostics.Actions;
using Squadron;
using SquadronAddIns.Default.Utility;
using System.Diagnostics;
using Squadron.Widgets;

namespace SquadronAddIns.Default.Diagnostics
{
    public partial class DiagnosticsControl : UserControl
    {
        public DiagnosticsControl()
        {
            InitializeComponent();

            if (Debugger.IsAttached)
            {
                actionControl.Add(new ActionControl.ActionGroup() { Name = "Size" });
                actionControl.Add(new DiskSizeAction());
                actionControl.Add(new DatabaseSizeAction());
                actionControl.Add(new WebsiteSizeAction());

                actionControl.Add(new ActionControl.ActionGroup() { Name = "Server" });
                actionControl.Add(new ServerStatusAction());
            }

            actionControl.Add(new ActionControl.ActionGroup() { Name = "User" });
            actionControl.Add(new DeadAccountsAction());
            actionControl.Add(new DeadAlertsAction());
            actionControl.Add(new DirectPermissionsAction());

            actionControl.CheckAll();
        }

        private IList<object> SharePointObjects;

        private void SelectionButton_OnSelectionChanged(object sender)
        {
            this.SharePointObjects = SharePointObjectsButton.SelectedObjects;

            foreach (ActionControl.Action action in actionControl.GetAllActions())
                action.SharePointObjects = SharePointObjects;
        }

        private void RefreshSharePointObjects()
        {
            SharePointObjects = _utility.RefreshSharePointObjects(SharePointObjects);
        }

        private SharePointUtility _utility = new SharePointUtility();

        private void actionControl_BeforeExecute(ActionControl.Action action)
        {
            if (SharePointObjects == null)
                SharePointObjects = SharePointObjectsButton.SelectedObjects;

            if (action.SharePointObjects == null)
                action.SharePointObjects = SharePointObjects;
        }

        private void ExecuteAllButton_Click(object sender, EventArgs e)
        {
            foreach (ActionControl.Action action in actionControl.GetCheckedActions())
            {
                try
                {
                    action.Execute();

                    SquadronContext.WriteMessage("Action: " + action.Name + " completed");
                }
                catch (Exception ex)
                {
                    SquadronContext.WriteMessage("Action: " + action.Name + " Error: " + ex.ToString());
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshSharePointObjects();
        }
    }
}
