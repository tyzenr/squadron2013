using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Windows8LookNFeel;

namespace SquadronAddIns.Default.Command.Dialogs
{
    public partial class SharePointDialog : Windows8LookNFeel.Windows8Form
    {
        public SharePointDialog()
        {
            InitializeComponent();
        }

        public bool Execute(string title, string url)
        {
            HeaderPanel.Text = title;
            UrlText.Text = url;

            FormInit(); 

            return ExecuteDialog();
        }

        public object SelectedObject
        {
            get;
            set;
        }

        protected override void FormInit()
        {
            base.FormInit();

            RefreshExplorer();
        }

        private void RefreshExplorer()
        {
            explorer.Url = UrlText.Text;
        }

        private void UrlText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RefreshExplorer();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SelectedObject = explorer.SelectedObject;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
