using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Squadron.Misc
{
    public partial class AddinInfoForm : Form
    {
        public AddinInfoForm()
        {
            InitializeComponent();

            SquadronHelper.Instance.InitializeControls(this);
        }

        public bool Execute(SquadronAddin Addin)
        {
            this.NamePanel.Text = Addin.Name;
            this.DescLabel.Text = Addin.Description;
            this.AuthorInfoLabel.Text = Addin.AuthorInfo;

            this.ShowDialog();


            return (DialogResult == System.Windows.Forms.DialogResult.OK);
        }

        private void AuthorInfoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AuthorInfoLabel.Text);
        }

        private void AddinInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
