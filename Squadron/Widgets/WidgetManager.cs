using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using Windows8LookNFeel;
using System.Data;
using System.ComponentModel;
using System.Collections;

namespace Squadron.Widgets
{
    public class WidgetManager
    {
        public void InitializeControls(Control container)
        {
            if (container.Tag == null)
            {
                foreach (Control control in Helper.Instance.GetControlsRecursively(container))
                {
                    if (control is Windows8Button)
                    {
                        (control as Windows8Button).DrawingColor = Windows8DrawingColor.SelectionColor;
                    }

                    if (control is DataGridView)
                    {
                        DataGridView grid = control as DataGridView;

                        SetContextMenuStrip(grid);
                    }

                    else if (control is CheckedListBox)
                    {
                        CheckedListBox cbx = control as CheckedListBox;

                        SetContextMenuStrip(cbx);
                    }
                }
            }

            container.Tag = "Init-Done";
        }

        private void SetContextMenuStrip(CheckedListBox cbx)
        {
            if (cbx.ContextMenuStrip == null)
            {
                cbx.ContextMenuStrip = new ContextMenuStrip();
            }

            if (!cbx.ContextMenuStrip.Items.Cast<ToolStripMenuItem>().Any(m => m.Text == "Check All"))
            {
                ToolStripItem item = cbx.ContextMenuStrip.Items.Add("Check All");
                item.Click += delegate(object s, EventArgs e)
                {
                    CheckedListBox control = (s as ToolStripItem).Tag as CheckedListBox;
                    for (int i = 0; i < control.Items.Count; i++)
                        control.SetItemChecked(i, true);
                };

                item.Tag = cbx;
            }

            if (!cbx.ContextMenuStrip.Items.Cast<ToolStripMenuItem>().Any(m => m.Text == "Uncheck All"))
            {
                ToolStripItem item = cbx.ContextMenuStrip.Items.Add("Uncheck All");
                item.Click += delegate(object s, EventArgs e)
                {
                    CheckedListBox control = (s as ToolStripItem).Tag as CheckedListBox;
                    for (int i = 0; i < control.Items.Count; i++)
                        control.SetItemChecked(i, false);
                };
                item.Tag = cbx;
            }
        }

        private void SetContextMenuStrip(DataGridView grid)
        {
            if (grid.ContextMenuStrip == null)
            {
                grid.ContextMenuStrip = new ContextMenuStrip();
            }

            if (!grid.ContextMenuStrip.Items.Cast<ToolStripMenuItem>().Any(m => m.Text == "Import Data"))
            {
                ToolStripItem item = grid.ContextMenuStrip.Items.Add("Import Data");
                item.Click += new EventHandler(ImportData_Click);
                item.Tag = grid;
                item.Visible = false;
            }

            if (!grid.ContextMenuStrip.Items.Cast<ToolStripMenuItem>().Any(m => m.Text == "Save to Excel"))
            {
                ToolStripItem item = grid.ContextMenuStrip.Items.Add("Save to Excel");
                item.Click += new EventHandler(SaveToExcel_Click);
                item.Tag = grid;
            }

            if (!grid.ContextMenuStrip.Items.Cast<ToolStripMenuItem>().Any(m => m.Text == "Save to CSV"))
            {
                ToolStripItem item = grid.ContextMenuStrip.Items.Add("Save to CSV");
                item.Click += new EventHandler(SaveToCSV_Click);
                item.Tag = grid;
            }

            if (!grid.ContextMenuStrip.Items.Cast<ToolStripMenuItem>().Any(m => m.Text == LaunchAfterExportCaption))
            {
                ToolStripMenuItem item = new ToolStripMenuItem(LaunchAfterExportCaption);
                grid.ContextMenuStrip.Items.Add(item);
                item.ToolTipText = "Open the file using viewers such as Excel, Notepad etc.";
                item.CheckOnClick = true;
                item.Checked = true;
                item.Tag = grid;
                item.CheckedChanged += new EventHandler(item_CheckedChanged);

                SetContextMenuEvent(grid);
            }
        }

        void item_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (sender as ToolStripMenuItem);

            CanOpenAfterSave = menuItem.Checked;
        }

        private void SetContextMenuEvent(DataGridView grid)
        {
            if (grid.ContextMenuStrip.Tag == null)
            {
                grid.ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(ContextMenuStrip_Opening);
                grid.ContextMenuStrip.Tag = ";";
            }
        }

        public bool CanOpenAfterSave = true;
        private string LaunchAfterExportCaption = "Open after save..";

        void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ContextMenuStrip menuStrip = (sender as ContextMenuStrip);

            // Set Export Property
            if (menuStrip.Items.Cast<ToolStripMenuItem>().Any(m => m.Text == LaunchAfterExportCaption))
            {
                menuStrip.Items.Cast<ToolStripMenuItem>().Where(m => m.Text == LaunchAfterExportCaption).First().Checked = CanOpenAfterSave;
            }
        }

        void item_DropDownOpening(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void SaveToCSV_Click(object sender, EventArgs e)
        {
            SquadronHelper.Instance.ExportToCSV((sender as ToolStripItem).Tag as DataGridView, null, CanOpenAfterSave);
        }

        void SaveToExcel_Click(object sender, EventArgs e)
        {
            DataGridView grid = (sender as ToolStripItem).Tag as DataGridView;

            DataSet dataSet = null;

            if (grid.DataSource is DataSet)
                dataSet = grid.DataSource as DataSet;

            else if (grid.DataSource.GetType().ToString().StartsWith("System.Collections.Generic.List"))
            {
                DataTable table = Helper.Instance.ConvertToDataTable(grid.DataSource as IList);
                dataSet = new DataSet();
                dataSet.Tables.Add(table);
            }

            SquadronHelper.Instance.ExportToExcel(dataSet, CanOpenAfterSave);
        }

        void ImportData_Click(object sender, EventArgs e)
        {
        }


        private void DrawImage(object sender)
        {
            (sender as Button).BackgroundImage = DrawingResources.BG1;
            (sender as Button).Invalidate();
        }

        private Brush _textBrush = new SolidBrush(Color.White);
        private Font _textFont = new Font("Segoe UI", 11, FontStyle.Bold);

        private void DrawText(string text, PaintEventArgs e)
        {
            PointF pointF = new PointF();
            pointF.X = (e.ClipRectangle.Width - e.Graphics.MeasureString(text, _textFont).Width) / 2;
            pointF.Y = (e.ClipRectangle.Height - e.Graphics.MeasureString(text, _textFont).Height) / 2;

            e.Graphics.DrawString(text, _textFont, _textBrush, pointF);
        }
    }
}
