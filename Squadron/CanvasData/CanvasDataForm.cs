using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Squadron.CanvasData
{
    public partial class CanvasDataForm : Form
    {
        public CanvasDataForm()
        {
            InitializeComponent();

            SquadronHelper.Instance.InitializeControls(this);
        }

        private void CanvasDataForm_Load(object sender, EventArgs e)
        {
            SquadronHelper.Instance.RefreshAddins(AddinList, false, true);
        }

        private void AddinList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddinList.SelectedIndex == 0) // Open from CSV File
            {
                DataTable table = SquadronHelper.Instance.GetDataTableFromCSV();

                if (table != null)
                {
                    SelectedColumns.Items.Clear();
                    foreach (DataColumn c in table.Columns)
                    {
                        SelectedColumns.Items.Add(c.ColumnName);
                    }

                    grid.DataSource = table;
                }
            }
            else
            {
                OpenFromGrid();
            }

            for (int i = 0; i < SelectedColumns.Items.Count; i++)
                SelectedColumns.SetItemChecked(i, true);

            if (grid.DataSource != null)
                if (grid.DataSource is DataTable)
                    InfoLabel.Text = (grid.DataSource as DataTable).Rows.Count.ToString() + " rows";
                else
                    InfoLabel.Text = grid.Rows.Count.ToString() + " rows";
        }

        private void OpenFromGrid()
        {
            grid.DataSource = Helper.Instance.GetDataSource((AddinList.SelectedItem as AddinView).Addin.DataControl);

            SelectedColumns.Items.Clear();
            FilterList.Items.Clear();
            foreach (DataGridViewColumn column in grid.Columns)
            {
                SelectedColumns.Items.Add(column.Name);
                FilterList.Items.Add(column.Name);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (SelectedColumns.CheckedItems.Count > 0)
            {
                DataGrid = this.grid;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
                SquadronContext.Info("Please check atleast one column!");
        }

        public DataGridView DataGrid;

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterList.SelectedIndex >= 0)
            {
                string fc = FilterList.SelectedItem.ToString();
                DataGridView selectedGrid = GetSelectedGrid();

                DataTable newTable = new DataTable();

                foreach (DataGridViewColumn column in selectedGrid.Columns)
                {
                    newTable.Columns.Add(column.Name, typeof(string));
                }

                foreach (DataGridViewRow row in selectedGrid.Rows)
                    if (selectedGrid[FilterList.SelectedIndex, row.Index].Value != null)
                        if (FilterText.Lines.Contains(selectedGrid[FilterList.SelectedIndex, row.Index].Value.ToString()))
                        {
                            DataRow newRow = newTable.NewRow();

                            foreach (DataGridViewColumn c in selectedGrid.Columns)
                            {
                                newRow[c.Name] = grid[c.Index, row.Index].Value;
                            }

                            newTable.Rows.Add(newRow);
                        }

                grid.DataSource = newTable;
            }
        }

        private DataGridView GetSelectedGrid()
        {
            return (AddinList.SelectedItem as AddinView).Addin.DataControl as DataGridView;
        }

        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilterText.Text = File.ReadAllText(dialog.FileName);
            }
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
    }
}
