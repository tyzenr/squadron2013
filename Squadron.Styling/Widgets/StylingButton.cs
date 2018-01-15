using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using Windows8LookNFeel;

namespace Squadron.Styling.Widgets
{
    public class StylingButton : Windows8Panel
    {
        public StylingButton()
        {
            BackHighlightColor1 = Color.FromArgb(196, 18, 18);
            BackHighlightColor2 = Color.FromArgb(140, 2, 2);

            BackColor = Color.FromArgb(63, 144, 50);
            BackColor2 = Color.FromArgb(150, 220, 123);

            ForecolorHighlight = Color.White;

            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ForeColor = Color.White;

            this.Size = new Size(100, 24);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            _widgetState = WidgetState.MouseEnter;

            this.Invalidate();
        }

        public DialogResult DialogResult
        {
            get;
            set;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            _widgetState = WidgetState.Normal;

            this.Invalidate();
        }

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                this.Invalidate();
            }
        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            if (this.BackgroundImage == null)
            {
                _painter.PaintBackground(this, e.Graphics, e.ClipRectangle);
                _painter.PaintBorder(this, e.Graphics, this.ClientRectangle, Color.Gray);

                if (!string.IsNullOrEmpty(this.Text))
                    _painter.PaintText(this, e.Graphics, this.ClientRectangle, this.Text, this.Font, this.TextPadding, this.TextAlign);
            }
            else
            {
                _painter.PaintImage(e.Graphics, this.ClientRectangle, this.BackgroundImage, this.StretchImage, HorizontalAlignment.Center);
                if (this._widgetState == Styling.WidgetState.MouseEnter)
                    _painter.PaintBorder(this, e.Graphics, this.ClientRectangle, Color.Gray);
                else
                    _painter.PaintBorder(this, e.Graphics, this.ClientRectangle, Color.WhiteSmoke);
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            this.Invalidate();
        }

        public void PerformClick()
        {
            this.InvokeOnClick(this, new EventArgs());
        }
    }
}
