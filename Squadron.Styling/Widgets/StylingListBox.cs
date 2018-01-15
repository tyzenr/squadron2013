using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Squadron.Styling.Themes;

namespace Squadron.Styling.Widgets
{
    public class StylingListBox : ListBox, IThemeSupport
    {
        protected ThemePainter _painter = new ThemePainter();

        public StylingListBox()
        {
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Font = new System.Drawing.Font("Segoe UI", 12);
            this.ItemHeight = this.Font.Height + 2;

            ThemePart = Theme.Instance.PanelThemePart;

            BackColor2 = Color.WhiteSmoke;
            BorderColor = Color.Gray;

            BackHighlightColor1 = Color.FromArgb(128, 128, 255); ;
            BackHighlightColor2 = Color.Navy;

            this.ForecolorHighlight = Color.White;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private Glassy _glassy = new Glassy();

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (this.Items.Count > 0)
            {
                bool Selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
                if (e.Index >= 0)
                {
                    if (Selected)
                    {
                        this.WidgetState = Styling.WidgetState.MouseEnter;
                        _painter.PaintBackground(this, e.Graphics, e.Bounds);

                        Pen pen = new Pen(Color.Gray);
                        pen.Width = 1;
                        e.Graphics.DrawRectangle(pen, e.Bounds);
                    }
                    else
                    {
                        this.WidgetState = Styling.WidgetState.Normal;
                        _painter.PaintBackground(this, e.Graphics, e.Bounds);

                        Pen pen = new Pen(this.BorderColor);
                        pen.Width = 1;
                        e.Graphics.DrawRectangle(pen, e.Bounds);
                    }

                    _painter.DrawTextForListBoxItem(e, this, Selected);
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            //if (m.Msg == 0x0014)
            //{
            //    Graphics g = Graphics.FromHdc(m.WParam);
            //    _painter.PaintBackground(this, g, this.ClientRectangle);
            //}
            //else
                base.WndProc(ref m);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            this.ItemHeight = this.Font.Height;
        }

        private Color _BackColor2;
        public Color BackColor2
        {
            get { return _BackColor2; }
            set { _BackColor2 = value; this.Invalidate(); }
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

        public WidgetState WidgetState
        {
            get;
            set;
        }

        public Themes.ThemePart ThemePart
        {
            get;
            set;
        }

        public Color BorderColor { get; set; }
    }
}
