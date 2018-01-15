using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron.Styling.Themes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Squadron.Styling;
using Squadron.Styling.Widgets;

namespace Squadron.Styling
{
    public class ThemePainter
    {
        public void PaintBackground(IThemeSupport ts, Graphics graphics, Rectangle rectangle)
        {
            if ((ts.WidgetState == WidgetState.Normal) || (ts.WidgetState == WidgetState.MouseLeave))
            {
                DrawBackground_OutlookStyle(
                    graphics,
                    rectangle,
                    ts.BackColor,
                    ts.BackColor2,
                    ts.ThemePart.BackcolorNormalGlow,
                    ts.ThemePart.BorderColor,
                    ts.ThemePart.BackcolorAngle);
            }
            else if (ts.WidgetState == WidgetState.MouseEnter)
            {
                DrawBackground_OutlookStyle(
                    graphics,
                    rectangle,
                    ts.BackHighlightColor1,
                    ts.BackHighlightColor2,
                    ts.ThemePart.BackcolorHighlightGlow,
                    ts.ThemePart.BorderColor,
                    ts.ThemePart.BackcolorAngle);
            }
        }

        private void DrawBackground(
            Graphics graphics, 
            Rectangle rectangle,
            Color BackColor1, 
            Color BackColor2, 
            Color GlowColor, 
            Color BorderColor, 
            int GradientAngle)
        {
            FillGradient(graphics, rectangle, BackColor1, BackColor2, GradientAngle);

            this.DrawBackground(graphics, rectangle, false, false, false, false, Color.Transparent, GlowColor, Color.White, Color.WhiteSmoke, BorderColor, 0.3f);
        }

        private void DrawBackground_OutlookStyle(
            Graphics graphics,
            Rectangle rectangle,
            Color BackColor1,
            Color BackColor2,
            Color GlowColor,
            Color BorderColor,
            int GradientAngle)
        {
            if (rectangle.Height > 0)
                if (rectangle.Width > 0)
                {
                    Rectangle headerRect = rectangle;
                    using (Brush brush = new LinearGradientBrush(headerRect, BackColor1, BackColor2, LinearGradientMode.Vertical))
                    {
                        graphics.FillRectangle(brush, headerRect);
                    }
                }
        }
        
        private void DrawBackground(Graphics g, Rectangle rectangle,
            bool pressed, bool hovered, bool animating, bool enabled,
            Color outerBorderColor, Color backColor, Color glowColor, Color shineColor,
            Color innerBorderColor, float glowOpacity)
        {
            SmoothingMode sm = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            #region " white border "
            Rectangle rect = rectangle;
            rect.Width--;
            rect.Height--;
            using (GraphicsPath bw = CreateRoundRectangle(rect, 4))
            {
                using (Pen p = new Pen(outerBorderColor))
                {
                    g.DrawPath(p, bw);
                }
            }
            #endregion

            rect.X++;
            rect.Y++;
            rect.Width -= 2;
            rect.Height -= 2;
            Rectangle rect2 = rect;
            rect2.Height >>= 1;


            #region " content "
            using (GraphicsPath bb = CreateRoundRectangle(rect, 2))
            {
                int opacity = pressed ? 0xcc : 0x7f;

                using (Brush br = new SolidBrush(Color.FromArgb(opacity, backColor)))
                {
                    g.FillPath(br, bb);
                }
            }
            #endregion

            #region " glow "
            if ((hovered || animating) && !pressed)
            {
                using (GraphicsPath clip = CreateRoundRectangle(rect, 2))
                {
                    g.SetClip(clip, CombineMode.Intersect);
                    using (GraphicsPath brad = CreateBottomRadialPath(rect))
                    {
                        using (PathGradientBrush pgr = new PathGradientBrush(brad))
                        {
                            unchecked
                            {
                                int opacity = (int)(0xB2 * glowOpacity + .5f);
                                RectangleF bounds = brad.GetBounds();
                                pgr.CenterPoint = new PointF((bounds.Left + bounds.Right) / 2f, (bounds.Top + bounds.Bottom) / 2f);
                                pgr.CenterColor = Color.FromArgb(opacity, glowColor);
                                pgr.SurroundColors = new Color[] { Color.FromArgb(0, glowColor) };
                            }
                            g.FillPath(pgr, brad);
                        }
                    }
                    g.ResetClip();
                }
            }
            #endregion

            #region " shine "
            if (rect2.Width > 0 && rect2.Height > 0)
            {
                rect2.Height++;
                using (GraphicsPath bh = CreateTopRoundRectangle(rect2, 2))
                {
                    rect2.Height++;
                    int opacity = 0x99;
                    if (pressed | !enabled)
                    {
                        opacity = (int)(.4f * opacity + .5f);
                    }
                    using (LinearGradientBrush br = new LinearGradientBrush(rect2, Color.FromArgb(opacity, shineColor), Color.FromArgb(opacity / 3, shineColor), LinearGradientMode.Vertical))
                    {
                        g.FillPath(br, bh);
                    }
                }
                rect2.Height -= 2;
            }
            #endregion

            #region " black border "
            using (GraphicsPath bb = CreateRoundRectangle(rect, 3))
            {
                using (Pen p = new Pen(innerBorderColor))
                {
                    g.DrawPath(p, bb);
                }
            }
            #endregion

            g.SmoothingMode = sm;
        }

        private void FillGradient(Graphics g, Rectangle rectangle, Color c1, Color c2, int GradientAngle)
        {
            if (GradientAngle == 0)
                GradientAngle = 90;

            Brush brush = new LinearGradientBrush(rectangle, c1, c2, GradientAngle);
            g.FillRectangle(brush, rectangle);
            brush.Dispose();
        }

        private GraphicsPath CreateRoundRectangle(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int l = rectangle.Left;
            int t = rectangle.Top;
            int w = rectangle.Width;
            int h = rectangle.Height;
            int d = radius << 1;
            path.AddArc(l, t, d, d, 180, 90); // topleft
            path.AddLine(l + radius, t, l + w - radius, t); // top
            path.AddArc(l + w - d, t, d, d, 270, 90); // topright
            path.AddLine(l + w, t + radius, l + w, t + h - radius); // right
            path.AddArc(l + w - d, t + h - d, d, d, 0, 90); // bottomright
            path.AddLine(l + w - radius, t + h, l + radius, t + h); // bottom
            path.AddArc(l, t + h - d, d, d, 90, 90); // bottomleft
            path.AddLine(l, t + h - radius, l, t + radius); // left
            path.CloseFigure();
            return path;
        }

        private GraphicsPath CreateTopRoundRectangle(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int l = rectangle.Left;
            int t = rectangle.Top;
            int w = rectangle.Width;
            int h = rectangle.Height;
            int d = radius << 1;
            path.AddArc(l, t, d, d, 180, 90); // topleft
            path.AddLine(l + radius, t, l + w - radius, t); // top
            path.AddArc(l + w - d, t, d, d, 270, 90); // topright
            path.AddLine(l + w, t + radius, l + w, t + h); // right
            path.AddLine(l + w, t + h, l, t + h); // bottom
            path.AddLine(l, t + h, l, t + radius); // left
            path.CloseFigure();
            return path;
        }

        private GraphicsPath CreateBottomRadialPath(Rectangle rectangle)
        {
            GraphicsPath path = new GraphicsPath();
            RectangleF rect = rectangle;
            rect.X -= rect.Width * .35f;
            rect.Y -= rect.Height * .15f;
            rect.Width *= 1.7f;
            rect.Height *= 2.3f;
            path.AddEllipse(rect);
            path.CloseFigure();
            return path;
        }

        private Glassy glassy = new Glassy();

        public void PaintGlassy(Control control, Graphics graphics, Rectangle rectangle, Theme theme,
            WidgetState state, int Angle)
        {
                glassy.DrawBackground(control, graphics, rectangle, false, Color.Blue,
                   Color.Red, Color.Yellow, Color.Gray, 90);
        }

        public void DrawGlossyEffect(Graphics g, ToolStrip t, int offset)
        {
            Rectangle glossyRect = new Rectangle(0, offset,
                    t.Width - 1,
                    (t.Height - 1) / 2);

            using (LinearGradientBrush b = new LinearGradientBrush(
                glossyRect.Location, new PointF(0, glossyRect.Bottom),
                Color.Red,
                Color.Yellow))
            {
                using (GraphicsPath border =
                    CreateTopRoundRectangle(glossyRect, 100))
                {
                    g.FillPath(b, border);
                }
            }
        }

        public void PaintImage(Graphics graphics, Rectangle rectangle, Image image, bool stretch, HorizontalAlignment imageAlign)
        {
            if (stretch)
                graphics.DrawImage(image, rectangle);
            else
            {
                if (imageAlign == HorizontalAlignment.Left)
                    graphics.DrawImage(image, new Point(0, 0));
                else if (imageAlign == HorizontalAlignment.Right)
                    graphics.DrawImage(image, new Point(rectangle.Width - image.Width, 0));
                else if (imageAlign == HorizontalAlignment.Center)
                    graphics.DrawImage(image, new Point((rectangle.Width - image.Width) / 2, (rectangle.Height - image.Height) / 2));
            }
        }

        public void PaintText(IThemeSupport ts, Graphics graphics, Rectangle rectangle, string text, Font font, Padding padding, HorizontalAlignment textAlign, Color forecolor, bool is3D)
        { 
            Brush brush = new SolidBrush(forecolor);

            // Drawing
            float left = 0, top = 0;

            if (textAlign == HorizontalAlignment.Left)
            {
                if (padding != null)
                {
                    SizeF sizeF = graphics.MeasureString(text, font);
                    left = rectangle.Left + padding.Left;
                    top = rectangle.Top + padding.Top + (rectangle.Height - sizeF.Height) / 2;
                }
            }
            else if (textAlign == HorizontalAlignment.Center)
            {
                SizeF sizeF = graphics.MeasureString(text, font);
                left = rectangle.Left + padding.Left + (rectangle.Width - sizeF.Width) / 2 + 2;
                top = rectangle.Top + padding.Top + (rectangle.Height - sizeF.Height) / 2;
            }

            if (is3D)
                graphics.DrawString(text, font, new SolidBrush(Color.Gray), left - 1, top - 1);

            graphics.DrawString(text, font, brush, left, top);
        }

        public void PaintText(IThemeSupport ts, Graphics graphics, Rectangle rectangle, string text, Font font, Padding padding, HorizontalAlignment textAlign)
        {
            // Find Brush
            Color forecolor = Color.Navy;
            if ((ts.WidgetState == WidgetState.Normal) || (ts.WidgetState == WidgetState.MouseLeave))
                forecolor = ts.ForeColor;

            else if (ts.WidgetState == WidgetState.MouseEnter)
                forecolor = ts.ForecolorHighlight;

            PaintText(ts, graphics, rectangle, text, font, padding, textAlign, forecolor, false);
        }

        public void PaintBorder(Widgets.Windows8LookNFeel.Windows8Button Windows8LookNFeel.Windows8Button, Graphics g, Rectangle rect, Color borderColor)
        {
            GraphicsPath gfxPath = new GraphicsPath();

            int radius = 4;
            Pen DrawPen = new Pen(borderColor);
            DrawPen.EndCap = DrawPen.StartCap = LineCap.Round;

            gfxPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            gfxPath.AddArc(rect.X + rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            gfxPath.AddArc(rect.X + rect.Width - radius - 1, rect.Y + rect.Height - radius - 1, radius, radius, 0, 90);
            gfxPath.AddArc(rect.X, rect.Y + rect.Height - radius - 1, radius, radius, 90, 90);
            gfxPath.CloseAllFigures();

            g.DrawPath(DrawPen, gfxPath);
        }

        public void PaintBorder(Graphics g, Rectangle rect, Color borderColor)
        {
            GraphicsPath gfxPath = new GraphicsPath();

            int radius = 4;
            Pen DrawPen = new Pen(borderColor);
            DrawPen.EndCap = DrawPen.StartCap = LineCap.Round;

            gfxPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            gfxPath.AddArc(rect.X + rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
            gfxPath.AddArc(rect.X + rect.Width - radius - 1, rect.Y + rect.Height - radius - 1, radius, radius, 0, 90);
            gfxPath.AddArc(rect.X, rect.Y + rect.Height - radius - 1, radius, radius, 90, 90);
            gfxPath.CloseAllFigures();

            g.DrawPath(DrawPen, gfxPath);
        }

        public void DrawTextForListBoxItem(DrawItemEventArgs e, StylingListBox lbox, bool Selected)
        {
            if (e.Index >= 0)
            {
                string text = String.Empty;

                if (lbox.Items[e.Index] != null)
                    text = lbox.Items[e.Index].ToString();

                SizeF size = e.Graphics.MeasureString(text, e.Font);

                Color Foreground = lbox.ForeColor;
                if (Selected)
                    Foreground = lbox.ForecolorHighlight;

                e.Graphics.DrawString(text, e.Font, new SolidBrush(Foreground), e.Bounds.X,
                    e.Bounds.Y + 1 +  (e.Bounds.Height - size.Height) / 2);
            }
        }
    }
}
