using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Squadron;

namespace SquadronAddins.Default.Commands
{
    public partial class CommandControl : UserControl
    {
        public CommandControl()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            StartAnimation();

            try
            {
                Process process = new Process();

                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = process.StartInfo.RedirectStandardError = true;
                process.StartInfo.FileName = _Program;
                process.StartInfo.Arguments = GetCommand();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                OutText.Text += Environment.NewLine;

                if (output != Environment.NewLine)
                    OutText.Text += output;

                if (!string.IsNullOrEmpty(error))
                    OutText.Text += error;

                process.WaitForExit();
            }
            catch (Exception ex)
            {
                OutText.Text += ex.ToString();
            }

            OutText.SelectionStart = OutText.Text.Length;
            OutText.ScrollToCaret();

            StopAnimation();
        }

        private void StartAnimation()
        {
            CommandText.Enabled = ExecuteButton.Enabled = false;
            pbr.Visible = true;

            Application.DoEvents();
        }

        private void StopAnimation()
        {
            CommandText.Enabled = ExecuteButton.Enabled = true;
            pbr.Visible = false;
        }

        private string GetCommand()
        {
            string command = CommandText.Text;

            return command;
        }

        private string _Program;

        private void CommandControl_Load(object sender, EventArgs e)
        {
            _Program = Environment.GetEnvironmentVariable("windir") + "\\System32\\cmd.exe";

            if (!File.Exists(_Program))
                SquadronContext.WriteMessage("Unable to find cmd.exe at: " + _Program);
        }

        private void clearMenu_Click(object sender, EventArgs e)
        {
            OutText.Clear();
        }

        private void CommandText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ExecuteButton.PerformClick();
        }
    }
}
