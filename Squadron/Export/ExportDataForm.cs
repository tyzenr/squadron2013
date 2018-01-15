using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Squadron.CanvasData;
using System.Diagnostics;

namespace Squadron.ExportData
{
    // Helps Exporting data with selection of columns
    public partial class ExportDataForm : Form
    {
        public ExportDataForm()
        {
            InitializeComponent();

            SquadronHelper.Instance.InitializeControls(this);
        }

        private void RefreshAddins()
        {
            SquadronHelper.Instance.RefreshAddins(AddinList, true, false);
        }

        private void AddinList_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid.DataSource = null;
            SelectedColumns.Items.Clear();

            if (AddinList.SelectedIndex == 0)
            {
            }
            else
            {
                grid.DataSource = Helper.Instance.GetDataSource((AddinList.SelectedItem as AddinView).Addin.DataControl);

                SelectedColumns.Items.Clear();
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    SelectedColumns.Items.Add(column.Name);
                    SelectedColumns.SetItemChecked(SelectedColumns.Items.Count - 1, true);
                }
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (AreInputsValid())
            {
                if (AddinList.SelectedIndex == 0) // Log Box
                    SquadronHelper.Instance.ExportToCSV(SquadronContext.MainForm.LogBox, SelectedColumns.CheckedItems.Cast<string>().ToList<string>(), LaunchCheck.Checked);
                
                else if (IsListBoxSelected())
                    SquadronHelper.Instance.ExportToCSV((AddinList.SelectedItem as AddinView).Addin.DataControl as ListBox, SelectedColumns.CheckedItems.Cast<string>().ToList<string>(), LaunchCheck.Checked);
                
                else // Grid
                    SquadronHelper.Instance.ExportToCSV(grid, SelectedColumns.CheckedItems.Cast<string>().ToList<string>(), LaunchCheck.Checked);
            }
        }

        private bool IsListBoxSelected()
        {
            if ((AddinList.SelectedItem as AddinView).Addin.DataControl is ListBox)
                return true;

            return false;
        }

        private bool AreInputsValid()
        {
            if ((SelectedColumns.CheckedItems.Count == 0) && (AddinList.SelectedIndex != 0) && !IsListBoxSelected())
            {
                SquadronContext.Info("Please check atleast one column!");
                return false;
            }

            return true;
        }

        private void ExportDataForm_Load(object sender, EventArgs e)
        {
            RefreshAddins();
        }

        private void checkAll(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectedColumns.Items.Count; i++)
                SelectedColumns.SetItemChecked(i, true);
        }

        private void uncheckAll(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectedColumns.Items.Count; i++)
                SelectedColumns.SetItemChecked(i, false);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
