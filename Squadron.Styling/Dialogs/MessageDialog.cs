using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron.Styling.Widgets;
using System.Diagnostics;

namespace Squadron.Styling
{
    public partial class MessageDialog : StylingForm
    {
        public MessageDialog()
        {
            InitializeComponent();
        }

        private string _solutionLink;

        public void ExecuteDialog(string message, string solutionLink, MessageType type)
        {
            _solutionLink = solutionLink;
            SolutionLink.Visible = !string.IsNullOrEmpty(solutionLink);

            if (type == MessageType.Warning)
            {
                HeaderPanel.BackColor = Color.Orange;
                HeaderPanel.BackColor2 = Color.FromArgb(192, 64, 0);
            }

            if (type == MessageType.Error)
            {
                HeaderPanel.BackColor = Color.Red;
                HeaderPanel.BackColor2 = Color.DarkRed;
            }

            ExecuteDialog(message);
        }

        public void ExecuteDialog(string message, MessageType type)
        {
            ExecuteDialog(message, string.Empty, type);
        }

        public void ExecuteDialog(string message)
        {
            MessageText.Text = message;
            MessageText.SelectionStart = MessageText.SelectionLength = 0;

            Helper.Instance.HideCaret(MessageText);

            ExecuteDialog();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool IsOverlayRequrired
        {
            get
            {
                return false;
            }
        }

        private void SolutionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_solutionLink);
        }

        private void MessageDialog_Resize(object sender, EventArgs e)
        {
            OkButton.Left = (this.Width - OkButton.Width) / 2;
        }

        public bool ExecuteDialog(IList<object> list)
        {
            _isModal = true;

            DataGridView grid = new Squadron.Styling.Widgets.StylingGridView();
            grid.Parent = MessageText.Parent;
            MessageText.Hide();

            FormInit();

            grid.Dock = DockStyle.Fill;
            grid.DataSource = list;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;

            if (IsOverlayRequrired)
                ShowOverlayForm();

            try
            {
                // Show Form
                this.ShowDialog();
            }
            finally
            {
                if (IsOverlayRequrired)
                    HideOverlayForm();
            }

            return (this.DialogResult == DialogResult.OK);
        }
    }

    public enum MessageType
    {
        Information,
        Warning,
        Error
    }
}
