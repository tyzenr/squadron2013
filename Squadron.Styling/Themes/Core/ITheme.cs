using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron.Styling.Themes;
using System.Drawing;

namespace Squadron.Styling
{
    public interface IThemeSupport
    {
        WidgetState WidgetState { get; }
        ThemePart ThemePart { get; set; }

        Color ForeColor
        {
            get;
            set;
        }

        Color BackColor
        {
            get;
            set;
        }

        Color BackColor2
        {
            get;
            set;
        }

        Color BackHighlightColor1
        {
            get;
            set;
        }

        Color BackHighlightColor2
        {
            get;
            set;
        }

        Color ForecolorHighlight
        {
            get;
            set;
        }
    }
}
