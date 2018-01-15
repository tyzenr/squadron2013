using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Squadron.Styling
{
    /// <summary>
    /// Class for drawing Glassy Backgrounds
    /// </summary>
    public class Glassy
    {
        public void DrawBackground(Control control, Graphics graphics, Rectangle rectangle,
            bool MouseDown, Color GlowColor, Color BackColor1, Color BackColor2,
            Color BorderColor, int GradientAngle)
        {
            FillGradient(graphics, rectangle, BackColor1, BackColor2, GradientAngle);

            this.DrawBackground(graphics, rectangle, MouseDown, false, false, false, Color.Transparent, 
                GlowColor, Color.White, Color.WhiteSmoke, BorderColor, 0.3f);
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
    }
}
