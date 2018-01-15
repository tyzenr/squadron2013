using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Squadron.Styling.Widgets
{
    public class StylingStatusPanel : StylingHeaderPanel
    {
        public StylingStatusPanel()
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
                this.BackColor2 = Color.Green;
                this.Text = "Good";
            }
            else if (_Status == StatusEnum.Average)
            {
                this.BackColor = Color.Yellow;
                this.BackColor2 = Color.Gold;
                this.Text = "Average";
            }
            else if (_Status == StatusEnum.Bad)
            {
                this.BackColor = Color.Red;
                this.BackColor2 = Color.Maroon;
                this.Text = "Bad";
            }
            else if (_Status == StatusEnum.None)
            {
                this.BackColor = Color.LightGray;
                this.BackColor2 = Color.Gray;
                this.Text = string.Empty;
            }
        }
    }
}
