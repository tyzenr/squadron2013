using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squadron.Widgets
{
    public partial class Section : UserControl
    {
        public Section()
        {
            InitializeComponent();
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
            get { return this.HeaderPanel.BackColor; }
            set { this.HeaderPanel.BackColor = value; this.Invalidate(); }
        }
    }
}
