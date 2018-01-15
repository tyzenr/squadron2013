using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Squadron.Styling.Widgets
{
    public class BlinkingButton : Windows8LookNFeel.Windows8Button
    {
        public string LaunchUrl
        {
            get;
            set;
        }

        public BlinkingButton()
        {
        }

        public void StartBlinking()
        {
            bool valid = !string.IsNullOrEmpty(LaunchUrl);

            if (Constants.IsReducedVersion)
                valid = false;

            if (valid)
            {
                Timer timer = new Timer();
                timer.Interval = 300;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Enabled = true;

                Click += new EventHandler(BlinkingButton_Click);
            }
            else
                this.Hide();
        }

        void BlinkingButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LaunchUrl))
                Process.Start(LaunchUrl);
        }

        private int _count;

        void timer_Tick(object sender, EventArgs e)
        {
            _count++;
            this.Visible = !this.Visible;

            if (_count == 10)
            {
                (sender as Timer).Enabled = false;
                this.Visible = true;
            }
        }
    }
}
