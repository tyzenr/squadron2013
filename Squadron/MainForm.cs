using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron.Core;
using Squadron.Misc;
using System.Diagnostics;
using Squadron.Widgets;
using System.Threading;
using Windows8LookNFeel;
using mshtml;
using Squadron.Animation;
using Squadron.Others;

namespace Squadron
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            SquadronContext.MainForm = this;
            SquadronHelper.Instance.InitializeControls(this);

            DisclaimerForm.CheckAndShowDisclaimer();
            ThemeRegister.RegisterKey("jpva2014feb22shadowbrook");
            ThemePainter.Instance.Theme = new GrayTheme();

            SetAdCode();
        }

        private void SetAdCode()
        {
            try
            {
                browser.Url = new Uri("http://www.sharepointcto.com/Squadron/Faq.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RegisterToGAC();

            PopulateAddins();

            if (Debugger.IsAttached)
            {
                if (Environment.MachineName == "HP")
                    UrlText.Text = "http://hp";

                else if (Environment.MachineName.StartsWith("HPVM"))
                    UrlText.Text = "http://hpvm";

                // AddinList.SelectedIndex = AddinList.FindStringExact("Documentation");
            }

            SetDomain();
        }

        private void PopulateAddins()
        {
            var Addins = SquadronContext.Addins;

            foreach (SquadronAddin Addin in Addins)
            {
                SquadronItem item = new SquadronItem()
                {
                    Addin = Addin
                };

                AddinList.Items.Add(item);
            }
        }

        private void SetDomain()
        {
            DomainText.Text = Helper.Instance.GetFullyQualifiedDomainName();
        }

        private void RegisterToGAC()
        {
            Helper.Instance.RegisterToGAC(Helper.Instance.GetExecutionFolder());
        }

        private void AddinList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddinList.SelectedItem != null)
            {
                SquadronAddin Addin = (AddinList.SelectedItem as SquadronItem).Addin;

                if (Addin != null)
                {
                    SquadronContext.ActiveAddin = Addin;

                    AddinTitleLabel.Caption = Addin.Name;
                    AddinTitleLabel.Tag = Addin;

                    AddinControlContainer.Controls.Clear();

                    SquadronHelper.Instance.InitializeControls(Addin.UserControlInstance);

                    AddinControlContainer.Controls.Add(Addin.UserControlInstance);

                    Addin.UserControlInstance.Dock = DockStyle.Fill;

                    SetHelpLink(Addin);

                    Addin.OnChange();
                }
            }
        }

        private void SetHelpLink(SquadronAddin Addin)
        {
            if (Constants.IsReducedVersion)
                return;

            helpbox.Tag = Addin;

            bool valid = helpbox.Visible = !string.IsNullOrEmpty(Addin.HelpUrl);

            if (helpbox.Visible)
            {
                AddinTitleLabel.Cursor = Cursors.Hand;
            }
            else

            if (valid)
                new Thread(new ThreadStart(() =>
                    {
                        for (int i = 1; i <= 6; i++)
                        {
                            helpbox.Visible = !helpbox.Visible;
                            Thread.Sleep(100);
                        }

                        helpbox.Visible = !string.IsNullOrEmpty((helpbox.Tag as SquadronAddin).HelpUrl);
                    }
                    )).Start();
        }

        private void ExportDataButton_Click(object sender, EventArgs e)
        {
            SquadronContext.ExportDataForm.ShowDialog();
        }

        private void clearMenu_Click(object sender, EventArgs e)
        {
            LogBox.Items.Clear();
        }

        private void helpbox_Click(object sender, EventArgs e)
        {
            SquadronAddin Addin = (sender as Windows8LookNFeel.Windows8Button).Tag as SquadronAddin;

            if (Addin != null)
                if (!string.IsNullOrEmpty(Addin.HelpUrl))
                    Process.Start(Addin.HelpUrl);
                else
                    Process.Start("http://www.jeanpaulva.com");
        }

        private void FacebookButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com/pages/Power-of-SharePoint/267975136652260?ref=hl");
        }

        private void TwitterButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/jeanpaulmvp");
        }

        private void BlogButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://jeanpaulva.com");
        }

        private void HeadingLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Constants.IsReducedVersion)
                new AboutForm().ShowDialog();
        }

        private void AddinTitleLabel_Click(object sender, EventArgs e)
        {
            if (!Constants.IsReducedVersion)
                if (AddinTitleLabel.Tag != null)
                    new AddinInfoForm().Execute(AddinTitleLabel.Tag as SquadronAddin);
        }

        private void LogBox_DoubleClick(object sender, EventArgs e)
        {
            new LogForm().ExecuteDialog(LogBox);
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m = string.Empty;

            foreach (int i in LogBox.SelectedIndices)
                m += LogBox.Items[i].ToString();

            Clipboard.SetText(m);
        }

        private void copyToClipboardAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m = string.Empty;

            foreach (object o in LogBox.Items)
                m += o.ToString();

            Clipboard.SetText(m);
        }

        private void UrlText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RefreshAddin();
        }

        private void RefreshAddin()
        {
            SquadronContext.AddinManager.InvokeOnChange();
        }

        public string Url;

        private void UrlText_TextChanged(object sender, EventArgs e)
        {
            Url = UrlText.Text;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshAddin();
        }
    }
}
