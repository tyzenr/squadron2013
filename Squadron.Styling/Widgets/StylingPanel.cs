using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using Squadron.Styling;
using Squadron.Styling.Themes;

namespace Squadron.Styling.Widgets
{
    public class StylingPanel : Panel, IThemeSupport
    {
        public StylingPanel()
        {
            Font = new Font("Segoe UI", 10, FontStyle.Regular);
            ThemePart = Theme.Instance.PanelThemePart;

            BackColor = Color.FromArgb(50, 55, 61);
            BackColor2 = Color.Gray;
        }

        public ThemePart ThemePart
        {
            get;
            set;
        }

        protected ThemePainter _painter = new ThemePainter();
        private Glassy _glassy = new Glassy();

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            _painter.PaintBackground(this, e.Graphics, e.ClipRectangle);

            if (this.Image != null)
                _painter.PaintImage(e.Graphics, e.ClipRectangle, this.TransparentImage, this.StretchImage, ImageAlign);

             //if (!string.IsNullOrEmpty(this.Text))
                _painter.PaintText(this, e.Graphics, e.ClipRectangle, this.Text, this.Font, this.TextPadding, this.TextAlign);
        }

        public string Caption;

        [Browsable(true)]
        public override string Text
        {
            get { return this.Caption; }
            set { this.Caption = value; this.Invalidate(); }
        }

        public Image Image
        {
            get;
            set;
        }

        public bool _stretchImage;

        public bool StretchImage
        {
            get { return _stretchImage; }
            set { _stretchImage = value; Invalidate(); }
        }

        private Padding _textPadding;

        public Padding TextPadding
        {
            get { return _textPadding; }
            set { _textPadding = value; Invalidate(); }
        }

        public HorizontalAlignment TextAlign
        {
            get;
            set;
        }

        public HorizontalAlignment ImageAlign
        {
            get;
            set;
        }

        protected WidgetState _widgetState = WidgetState.Normal;

        public WidgetState WidgetState
        {
            get
            {
                return _widgetState;
            }
        }

        private Image _tansparentImage;

        protected Image TransparentImage
        {
            get
            {
                return Image;

                if (_tansparentImage == null)
                {
                    Bitmap bitmap = new Bitmap(Image);
                    bitmap.MakeTransparent(bitmap.GetPixel(1, 1));

                    _tansparentImage = bitmap;
                }

                return _tansparentImage;
            }
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
