using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Squadron.Styling.Themes
{
    /// <summary>
    /// Default Theme
    /// </summary>
    public class Theme
    {
        private static Theme _instance;

        public static Theme Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Theme();

                return _instance;
            }
        }

        

        public Theme()
        {
            // Panel
            PanelThemePart = new ThemePart();
            PanelThemePart.BorderColor = Color.LightGray;
            PanelThemePart.BackcolorAngle = 180;
            PanelThemePart.BackcolorNormalGlow = Color.LimeGreen;
            PanelThemePart.BackcolorHighlight1 = Color.WhiteSmoke;
            PanelThemePart.BackcolorHighlight2 = Color.Black;
            PanelThemePart.BackcolorHighlightGlow = Color.Yellow;

            // Button
            ButtonThemePart = new ThemePart();
            ButtonThemePart.BorderColor = Color.LightGray;
            ButtonThemePart.BackcolorAngle = 90;
            ButtonThemePart.BackcolorNormalGlow = Color.White;
            ButtonThemePart.BackcolorHighlightGlow = Color.LimeGreen;
        }

        public ThemePart PanelThemePart
        {
            get;
            set;
        }

        public ThemePart WorkareaThemePart
        {
            get;
            set;
        }

        public ThemePart ButtonThemePart
        {
            get;
            set;
        }

        public ThemePart LabelThemePart
        {
            get;
            set;
        }
    }


    public class ThemePart
    {
        public Color BorderColor;

        public int BackcolorAngle;

        public Color BackcolorNormalGlow;

        public Color BackcolorHighlight1;
        public Color BackcolorHighlight2;
        public Color BackcolorHighlightGlow;
    }
}
