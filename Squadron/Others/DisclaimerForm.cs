using Hx.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Squadron.Others
{
    public partial class DisclaimerForm : Form
    {
        public DisclaimerForm()
        {
            InitializeComponent();
        }

        public static void CheckAndShowDisclaimer()
        {
            if (!HasDisclaimerShown())
            {
                new DisclaimerForm().ShowDialog();
                SetDisclaimerOk();
            }
        }

        private static bool HasDisclaimerShown()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Constants.ApplicationTitle);
            object value = key.GetValue(DisclaimerName);
            key.Close();

            return (value != null);
        }

        private static string DisclaimerName
        {
            get { return "Disclaimer" + Assembly.GetEntryAssembly().GetName().Version.ToString(); }
        }

        private static void SetDisclaimerOk()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Constants.ApplicationTitle);
            key.SetValue(DisclaimerName, "Ok");
            key.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
