using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron.Styling.Themes;

namespace Squadron.Styling.Widgets
{
    public class StylingCheckBox : CheckBox, IThemeSupport
    {
        public StylingCheckBox()
        {
            Font = new Font("Segoe UI", 10, FontStyle.Regular);

            ThemePart = Theme.Instance.PanelThemePart;

            SetColor();

            // this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void SetColor()
        {
            BackColor = Color.FromArgb(192, 255, 192);
            BackColor2 = Color.FromArgb(128, 255, 128);
            ForeColor = Color.DarkOliveGreen;

            BackHighlightColor1 = Color.FromArgb(148, 252, 20);
            BackHighlightColor2 = Color.FromArgb(0, 192, 0);
            ForecolorHighlight = Color.Black;
        }

        protected ThemePainter _painter = new ThemePainter();
        private Glassy _glassy = new Glassy();

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            return;

            if (!this.Checked)
            {
                this.WidgetState = Styling.WidgetState.Normal;
                BorderColor = Color.White;
            }
            else
            {
                this.WidgetState = Styling.WidgetState.MouseEnter;
                BorderColor = Color.Orange;
            }

            pevent.Graphics.FillRectangle(new SolidBrush(Color.White), this.ClientRectangle);
            _painter.PaintBackground(this, pevent.Graphics, this.ClientRectangle);
            _painter.PaintText(this, pevent.Graphics, this.ClientRectangle, this.Text.Replace("&&", "&"), this.Font, this.Padding, HorizontalAlignment.Center);
            _painter.PaintBorder(pevent.Graphics, this.ClientRectangle, this.BorderColor);
        }

        private Color BorderColor
        {
            get;
            set;
        }

        private HorizontalAlignment GetAlignment(ContentAlignment contentAlignment)
        {
            if (contentAlignment == ContentAlignment.BottomLeft || contentAlignment == ContentAlignment.MiddleLeft || contentAlignment == ContentAlignment.TopLeft)
                return HorizontalAlignment.Left;

            else if (contentAlignment == ContentAlignment.BottomCenter || contentAlignment == ContentAlignment.MiddleCenter || contentAlignment == ContentAlignment.TopCenter)
                return HorizontalAlignment.Center;
            
            else if (contentAlignment == ContentAlignment.BottomRight || contentAlignment == ContentAlignment.MiddleRight || contentAlignment == ContentAlignment.TopRight)
                return HorizontalAlignment.Right;

            return HorizontalAlignment.Left;
        }

        public WidgetState WidgetState
        {
            get;
            set;
        }

        public ThemePart ThemePart
        {
            get;
            set;
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
    }
}
