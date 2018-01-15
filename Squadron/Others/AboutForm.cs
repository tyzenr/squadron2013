using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using Squadron.Others;

namespace Squadron.Misc
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            SquadronHelper.Instance.InitializeControls(this);

            SystemInfoText.Text = "Version: " + Assembly.GetEntryAssembly().GetName().Version.ToString() + Environment.NewLine +
                "Application Folder: " + Helper.Instance.GetExecutionFolder();
        }

        private void JeanPaulVAlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.jeanpaulva.com");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisclaimerButton_Click(object sender, EventArgs e)
        {
            new DisclaimerForm().ShowDialog();
        }
    }
}
