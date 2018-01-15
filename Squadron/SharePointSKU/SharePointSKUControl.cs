using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SquadronAddIns.Default.SharePointSKU
{
    public partial class SharePointSKUControl : UserControl
    {
        public SharePointSKUControl()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = SKUFinder.Execute();
        }
    }
}
