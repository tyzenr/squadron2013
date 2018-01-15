using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squadron.Animation
{
    public partial class AnimationForm : Form
    {
        public AnimationForm()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            SquadronHelper.Instance.InitializeControls(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbr.Value > 90)
                pbr.Value = 0;

            pbr.Value += 10;

            Application.DoEvents();
        }
    }
}
