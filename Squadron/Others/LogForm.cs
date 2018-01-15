using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;

namespace Squadron.Others
{
    public partial class LogForm : Windows8LookNFeel.Windows8Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        public bool ExecuteDialog(ListBox lbx)
        {
            RefreshData(lbx);

            return ExecuteDialog();
        }

        public bool ExecuteDialog(IList<string> list)
        {
            RefreshData(list);

            return ExecuteDialog();
        }

        private void RefreshData(IList<string> list)
        {
            foreach (string s in list)
                LogBox.Items.Add(s);
        }

        private void RefreshData(ListBox lbx)
        {
            foreach (object o in lbx.Items)
                LogBox.Items.Add(o);
        }

        private void LogBox_DoubleClick(object sender, EventArgs e)
        {
            if (LogBox.SelectedItem != null)
                SquadronContext.Info(LogBox.SelectedItem.ToString());
        }
    }
}
