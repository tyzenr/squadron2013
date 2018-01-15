using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint;
using Squadron;

namespace SquadronAddins.Default.WFTerminator
{
    public partial class WFTerminatorControl : UserControl
    {
        public WFTerminatorControl()
        {
            InitializeComponent();

            RefreshInternalStates();
        }

        private void RefreshInternalStates()
        {
            InternalStateList.Items.Clear();
            InternalStateList.Items.Add("- Select Internal State -");
            Enum.GetValues(typeof(SPWorkflowState)).Cast<SPWorkflowState>().ToList().ForEach(w => InternalStateList.Items.Add(w.ToString()));

            InternalStateList.SelectedIndex = 0;
        }

        private void InternalStateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWorkflows();
        }

        private void RefreshWorkflows()
        {
            if (InternalStateList.SelectedIndex > 0)
                using (SPSite site = new SPSite(SquadronContext.Url))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        IEnumerable<SPWorkflow> list = web.Workflows.Cast<SPWorkflow>().Where(w => w.InternalState.ToString() == InternalStateList.SelectedItem.ToString()).ToList();

                        grid.DataSource = list;
                    }
                }
        }

        private void TerminateButton_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                if (SquadronContext.Confirm("Are you sure you wanted to Terminate this workflow?"))
                {
                    SPWorkflow workflow = grid.SelectedRows[0].DataBoundItem as SPWorkflow;

                    SPWorkflowManager.CancelWorkflow(workflow);

                    RefreshWorkflows();
                }
            }
        }
    }
}
