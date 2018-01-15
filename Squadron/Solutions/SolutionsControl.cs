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
using SquadronAddIns.Default.Utility;
using Squadron;
using SquadronAddIns.Default.Utility.Entity;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace SquadronAddIns.Default.Solutions
{
    public partial class SolutionsControl : UserControl
    {
        public SolutionsControl()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            RefreshSolutions();
        }

        private SolutionUtility _solutionUtility = new SolutionUtility();
        private SharePointUtility _utility = new SharePointUtility();

        private void RefreshSolutions()
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                var list = _solutionUtility.GetSolutions(SquadronContext.Url);

                grid.DataSource = list;
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                if (SquadronContext.Confirm("Are you sure you wanted to remove the Solution?"))
                    _solutionUtility.RemoveSolution(grid.SelectedRows[0].DataBoundItem as SolutionEntity);
            }

            else
                SquadronContext.Errr_PleaseSelect();
        }

        private void DeployButton_Click(object sender, EventArgs e)
        {
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                SPSolution solution = SPFarm.Local.Solutions.Add(OpenDialog.FileName);
                solution.Deploy(DateTime.Now, true, _utility.GetAllWebApplications(), true);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                if (SquadronContext.Confirm("Are you sure you wanted to delete the Solution?"))
                {
                    _solutionUtility.DeleteSolution(grid.SelectedRows[0].DataBoundItem as SolutionEntity);
                    RefreshSolutions();
                }
            }

            else
                SquadronContext.Errr_PleaseSelect();
        }
    }
}
