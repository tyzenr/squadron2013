using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;

namespace Squadron.Dialogs
{
    public partial class InputDialog : Windows8LookNFeel.Windows8Form
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        public bool Execute(string text)
        {
            UserText.Text = text;

            return ExecuteDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            InputText = UserText.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public string InputText
        {
            get;
            set;
        }
    }
}
