using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using Squadron;
using System.IO;
using System.Diagnostics;

namespace SquadronAddIns.Default.Command.Dialogs
{
    public partial class PowerShellCodeDialog : Windows8LookNFeel.Windows8Form
    {
        public PowerShellCodeDialog()
        {
            InitializeComponent();
        }

        public bool ExecuteDialog(string code)
        {
            CodeText.Text = code;

            return this.ExecuteDialog();
        }

        private void LaunchPSButton_Click(object sender, EventArgs e)
        {
            string powerShellPath = Helper.Instance.GetPowerShellPath();
            string sharePointPS1Path = Helper.Instance.GetSharePointPS1Path();

            if (File.Exists(powerShellPath) & File.Exists(sharePointPS1Path))
            {
                string command = "  -NoExit  " +
                    "\" & ' " +
                    sharePointPS1Path +
                    " ' \"";
                Process.Start(powerShellPath, command);
            }

            else
                SquadronContext.Warn("Unable to find PowerShell/SharePoin PS1 Path!");
        }

        private void LaunchPSISEButton_Click(object sender, EventArgs e)
        {
            string powerShellISEPath = Helper.Instance.GetPowerShellISEPath();

            if (File.Exists(powerShellISEPath))
            {
                Process.Start(powerShellISEPath);
            }

            else
                SquadronContext.Warn("Unable to find PowerShell ISE Path!");
        }
    }
}
