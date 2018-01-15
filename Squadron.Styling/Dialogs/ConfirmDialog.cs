using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron.Styling.Widgets;

namespace Squadron.Styling
{
    public partial class ConfirmDialog : StylingForm
    {
        public ConfirmDialog()
        {
            InitializeComponent();
        }

        private bool _result;

        public bool ExecuteDialog(string message)
        {
            MessageText.Text = message;
            MessageText.SelectionStart = MessageText.SelectionLength = 0;

            ExecuteDialog();

            return _result;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            _result = true;
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            _result = false;
            CloseForm();
        }

        protected override bool IsOverlayRequrired
        {
            get
            {
                return false;
            }
        }

        protected override bool CanCloseOnEscapeKey
        {
            get
            {
                return false;
            }
        }
    }
}
