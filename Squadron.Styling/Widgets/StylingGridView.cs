using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron.Styling.Themes;

namespace Squadron.Styling.Widgets
{
    public class StylingGridView : DataGridView, IThemeSupport
    {
        public IList<int> RedRows = new List<int>();
        public IList<int> BoldRows = new List<int>();
        public IList<int> ItalicRows = new List<int>();

        public StylingGridView()
        {
            RowTemplate.Height = 45;

            ColumnHeadersHeight = 30;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            ThemePart = Theme.Instance.PanelThemePart;
            BackColor = Color.FromArgb(128, 128, 255);
            BackColor2 = Color.Navy;

            SelectionTheme.ThemePart = Theme.Instance.PanelThemePart;
            SelectionTheme.BackColor = Color.Lime;
            SelectionTheme.BackColor2 = Color.Green;

            NormalTheme.ThemePart = Theme.Instance.PanelThemePart;
            NormalTheme.BackColor = Color.White;
            NormalTheme.BackColor2 = Color.WhiteSmoke;

            CellPainting += new DataGridViewCellPaintingEventHandler(StylingGridView_CellPainting);

            Font = new Font("Verdana", 9, FontStyle.Regular);
            NormalFont = new Font("Verdana", 9, FontStyle.Regular);
            BoldFont = new Font("Verdana", 9, FontStyle.Bold);
            ItalicFont = new Font("Verdana", 9, FontStyle.Italic);

            ForeColor = Color.FromArgb(45, 45, 45);
        }

        private Font NormalFont, BoldFont, ItalicFont;

        public IThemeSupport SelectionTheme = new SelectionTheme();
        public IThemeSupport NormalTheme = new SelectionTheme();

        protected ThemePainter _painter = new ThemePainter();

        public bool NoSelectedColor
        {
            get;
            set;
        }

        void StylingGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            bool Selected = ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected);
            string text = String.Empty;
            if (e.Value != null)
                text = e.Value.ToString();

            Font font = null;

            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex == -1)
                {
                    _painter.PaintBackground(this, e.Graphics, e.CellBounds);
                    font = this.Font;
                    _painter.PaintText(this, e.Graphics, e.CellBounds, GetReducedText(text, e, font), font, new Padding(2), GetHorizontalAlignment(this.Columns[e.ColumnIndex].DefaultCellStyle.Alignment), Color.WhiteSmoke, true);
                    e.Graphics.DrawLine(Pens.Gray, new Point(e.CellBounds.Left + e.CellBounds.Width - 1, e.CellBounds.Y), new Point(e.CellBounds.Left + e.CellBounds.Width - 1, e.CellBounds.Height));
                    e.Handled = true;
                }
                else
                {
                    bool isSelected = false;
                    if (Selected & !NoSelectedColor)
                        isSelected = true;

                    if (isSelected)
                    {
                        _painter.PaintBackground(SelectionTheme, e.Graphics, e.CellBounds);
                        font = GetFont(e.RowIndex);
                        _painter.PaintText(this, e.Graphics, e.CellBounds, GetReducedText(text, e, font), font, new Padding(0), GetHorizontalAlignment(this.Columns[e.ColumnIndex].DefaultCellStyle.Alignment), GetSelectedForecolor(e.RowIndex), false);
                        e.Handled = true;
                    }

                    else
                    {
                        _painter.PaintBackground(NormalTheme, e.Graphics, e.CellBounds);
                        font = GetFont(e.RowIndex);
                        _painter.PaintText(this, e.Graphics, e.CellBounds, GetReducedText(text, e, font), font, new Padding(0), GetHorizontalAlignment(this.Columns[e.ColumnIndex].DefaultCellStyle.Alignment), GetForeColor(e.RowIndex), false);
                        e.Graphics.DrawRectangle(Pens.LightSteelBlue, e.CellBounds);
                        e.Handled = true;
                    }
                }
            }
        }

        private Color GetSelectedForecolor(int ri)
        {
            if (RedRows.Contains(ri))
                return Color.Yellow;

            return Color.WhiteSmoke;
        }

        private Color GetForeColor(int ri)
        {
            if (RedRows.Contains(ri))
                return Color.Red;

            return ForeColor;
        }

        private string GetReducedText(string text, DataGridViewCellPaintingEventArgs e, System.Drawing.Font font)
        {
            string savedText = text;

            try
            {
                while (true)
                {
                    SizeF s = e.Graphics.MeasureString(text, font);
                    if (s.Width < e.CellBounds.Width)
                        return text;

                    text = text.Substring(0, text.Length - 1);

                    if (text.Length == 0)
                        break;
                }
            }
            catch { }

            return savedText;
        }

        private System.Drawing.Font GetFont(int rowIndex)
        {
            if (BoldRows.Contains(rowIndex))
                return BoldFont;

            else if (ItalicRows.Contains(rowIndex))
                return ItalicFont;

            return NormalFont;
        }

        private HorizontalAlignment GetHorizontalAlignment(DataGridViewContentAlignment al)
        {
            switch (al)
            {
                // Left
                case DataGridViewContentAlignment.BottomLeft:
                    goto case DataGridViewContentAlignment.TopLeft;
                case DataGridViewContentAlignment.MiddleLeft:
                    goto case DataGridViewContentAlignment.TopLeft;
                case DataGridViewContentAlignment.TopLeft:
                    return HorizontalAlignment.Left;

                // Right
                case DataGridViewContentAlignment.BottomRight:
                    goto case DataGridViewContentAlignment.TopRight;
                case DataGridViewContentAlignment.MiddleRight:
                    goto case DataGridViewContentAlignment.TopRight;
                case DataGridViewContentAlignment.TopRight:
                    return HorizontalAlignment.Right;

                // Center
                case DataGridViewContentAlignment.BottomCenter:
                    goto case DataGridViewContentAlignment.TopCenter;
                case DataGridViewContentAlignment.MiddleCenter:
                    goto case DataGridViewContentAlignment.TopCenter;
                case DataGridViewContentAlignment.TopCenter:
                    return HorizontalAlignment.Center;
            }

            return HorizontalAlignment.Left;
        }

        public WidgetState WidgetState
        {
            get { return Styling.WidgetState.Normal; }
        }

        public ThemePart ThemePart
        {
            get;
            set;
        }

        public Color BackColor2
        {
            get;
            set;
        }

        public Color BackHighlightColor1
        {
            get;
            set;
        }

        public Color BackHighlightColor2
        {
            get;
            set;
        }

        public Color ForecolorHighlight
        {
            get;
            set;
        }
    }

    public class SelectionTheme : IThemeSupport
    {

        public WidgetState WidgetState
        {
            get { return Styling.WidgetState.Normal; }
        }

        public ThemePart ThemePart
        {
            get;
            set;
        }

        public Color ForeColor
        {
            get;
            set;
        }

        public Color BackColor
        {
            get;
            set;
        }

        public Color BackColor2
        {
            get;
            set;
        }

        public Color BackHighlightColor1
        {
            get;
            set;
        }

        public Color BackHighlightColor2
        {
            get;
            set;
        }

        public Color ForecolorHighlight
        {
            get;
            set;
        }
    }
}
