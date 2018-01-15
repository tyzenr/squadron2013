using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squadron.Styling.Widgets
{
    public partial class StylingSection : UserControl
    {
        public StylingSection()
        {
            InitializeComponent();
            this.HeaderPanel.TextPadding = new Padding(3, 3, 0, 0);
        }

        public override string Text
        {
            get { return this.HeaderPanel.Text; }
            set { this.HeaderPanel.Text = value; this.Invalidate(); }
        }

        public Color HeaderBackColor
        {
            get { return this.HeaderPanel.BackColor; }
            set { this.HeaderPanel.BackColor = value; this.Invalidate(); }
        }

        public Color HeaderBackColor2
        {
            get { return this.HeaderPanel.BackColor2; }
            set { this.HeaderPanel.BackColor2 = value; this.Invalidate(); }
        }
    }
}
