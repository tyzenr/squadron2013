using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Windows8LookNFeel;

namespace Squadron.Widgets
{
    public class StatusPanel : Windows8Panel
    {
        public StatusPanel()
        {
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }

        public enum StatusEnum
        {
            None,
            Good,
            Average,
            Bad
        }

        private StatusEnum _Status;

        public StatusEnum Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                Display();
            }
        }

        private void Display()
        {
            if (_Status == StatusEnum.Good)
            {
                this.BackColor = Color.Lime;
                this.Text = "Good";
            }
            else if (_Status == StatusEnum.Average)
            {
                this.BackColor = Color.Yellow;
                this.Text = "Average";
            }
            else if (_Status == StatusEnum.Bad)
            {
                this.BackColor = Color.Red;
                this.Text = "Bad";
            }
            else if (_Status == StatusEnum.None)
            {
                this.BackColor = Color.LightGray;
                this.Text = string.Empty;
            }
        }
    }
}
