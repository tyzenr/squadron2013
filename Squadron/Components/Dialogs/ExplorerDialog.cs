using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;

namespace SquadronAddIns.Default.Components.Dialogs
{
    public partial class ExplorerDialog : Windows8LookNFeel.Windows8Form
    {
        public ExplorerDialog()
        {
            InitializeComponent();
        }

        public IList<object> SelectedObjects
        {
            get
            {
                return explorer.SelectedObjects;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
