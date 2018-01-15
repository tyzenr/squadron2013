using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Squadron.Styling.Widgets
{
    public class StylingManager
    {
        private Color Color1 = Color.WhiteSmoke;
        private Color Color2;

        private Color Color1Dark = Color.Blue;
        private Color Color2Dark;

        public StylingManager()
        {
            Color2 = Color.WhiteSmoke;
            Color2Dark = Color.LightBlue;
        }

        public void InitializeControls(Control container)
        {
            foreach (Control control in Helper.Instance.GetControlsRecursively(container))
            {
                if (control is TextBox)
                {
                    (control as TextBox).BorderStyle = BorderStyle.FixedSingle;
                    (control as TextBox).BackColor = Color.WhiteSmoke;
                }

                else if (control.GetType().ToString() == typeof(Panel).ToString())
                {
                    if ((control as Panel).Tag == null)
                        if ((control as Panel).BackgroundImage == null)
                        {
                            (control as Panel).Paint += Background_Paint;
                        }
                }

                else if (control.GetType().ToString() == typeof(LinkLabel).ToString())
                {
                    if ((control as LinkLabel).Tag == null)
                        (control as LinkLabel).Font = new Font("Calibri", 8, FontStyle.Regular);
                }
                else if (control is DataGridView)
                {
                    DataGridView grid = control as DataGridView;

                    if (grid.Tag == null)
                    {
                        grid.BorderStyle = BorderStyle.FixedSingle;
                        grid.ReadOnly = true;
                        grid.GridColor = Color.LightSteelBlue;
                        grid.BackgroundColor = Color.LightGray;
                        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        grid.RowHeadersDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
                        grid.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;

                        grid.ColumnHeadersHeight = 30;
                        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

                        grid.RowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
                        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                        grid.RowTemplate.Height = 30;

                        grid.RowHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                        grid.DataSourceChanged += new EventHandler(grid_DataSourceChanged);
                        grid_DataSourceChanged(grid, null);
                    }
                }

                else if (control is CheckedListBox)
                {
                    CheckedListBox cbx = control as CheckedListBox;

                    if (IsTagValid(cbx.Tag))
                    {
                        cbx.BorderStyle = BorderStyle.FixedSingle;

                        cbx.Font = new Font("Segoe UI", 9);
                        cbx.ForeColor = Color.DarkBlue;
                    }

                    SetContextMenuStrip(cbx);
                }

                else if (control is ListBox)
                {
                    if ((control as ListBox).Tag == null)
                        (control as ListBox).BorderStyle = BorderStyle.FixedSingle;
                }

                else if (control is ComboBox)
                {
                    if ((control as ComboBox).Tag == null)
                        (control as ComboBox).FlatStyle = FlatStyle.Flat;
                }

                else if (control is Windows8LookNFeel.Windows8Button)
                {
                    Windows8LookNFeel.Windows8Button sbtn = control as Windows8LookNFeel.Windows8Button;

                    if (IsTagValid((control as Windows8LookNFeel.Windows8Button).Tag))
                    {
                        sbtn.BackColor = Color.White;
                        sbtn.BackColor2 = Color.Silver;
                        sbtn.ForeColor = Color.FromArgb(64, 64, 64);

                        sbtn.BackHighlightColor1 = Color.Green;
                        sbtn.BackHighlightColor2 = Color.Lime;
                    }
                }

                else if (control is StylingPanel)
                {
                    StylingPanel spnl = control as StylingPanel;

                    if (spnl.Tag == null)
                    {
                        spnl.BackColor = Color.FromArgb(128, 128, 255);
                        spnl.BackColor2 = Color.Navy;
                    }
                }

                else if (control is PropertyGrid)
                {
                    if ((control as PropertyGrid).Tag == null)
                    {
                        (control as PropertyGrid).BackColor = Color.WhiteSmoke;
                        (control as PropertyGrid).HelpBackColor = Color.WhiteSmoke;
                    }
                }

                else if (control is TreeView)
                {
                    if ((control as TreeView).Tag == null)
                        (control as TreeView).BorderStyle = BorderStyle.FixedSingle;
                }

                else if (control is CheckBox)
                {
                    if ((control as CheckBox).Tag == null)
                        (control as CheckBox).Font = new Font("Segoe UI", 9, FontStyle.Regular);
                }

                else if (control is RadioButton)
                {
                    if ((control as RadioButton).Tag == null)
                        (control as RadioButton).Font = new Font("Segoe UI", 9, FontStyle.Regular);
                }
            }
        }

        void grid_DataSourceChanged(object sender, EventArgs e)
        {
            Helper.Instance.RearrangeColumns(sender as DataGridView);
        }

        private bool IsTagValid(object tag)
        {
            if (tag != null)
                if (tag.GetType() == typeof(string))
                    if (tag.ToString() == ";")
                        return false;

            return true;
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

        void Background_Paint(object sender, PaintEventArgs e)
        {
            // Background
            Color c1 = Color1;
            Color c2 = Color2;

            if (sender is Button)
            {
            }
            else
                DrawBackground(e.Graphics, (sender as Control).ClientRectangle, c1, c2);

            // Text
            if (sender is Button)
            {
            }
        }

        public void DrawBackground(Graphics g, Rectangle rectangle, Color c1, Color c2)
        {
            LinearGradientBrush br = new LinearGradientBrush(rectangle, Color.Black, Color.Black, 0, false);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 0.3f, 1 };
            cb.Colors = new[] { c1, c2, c1 };
            br.InterpolationColors = cb;
            // rotate
            br.RotateTransform(90);
            // paint
            g.FillRectangle(br, rectangle);
        }
    }
}
