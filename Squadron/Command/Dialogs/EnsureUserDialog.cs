using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;
using Microsoft.SharePoint;
using Squadron;

namespace SquadronAddIns.Default.Command.Dialogs
{
    public partial class EnsureUserDialog : Windows8LookNFeel.Windows8Form
    {
        public EnsureUserDialog()
        {
            InitializeComponent();
        }

        public bool ExecuteDialog(IList<SPWeb> list)
        {
            RefreshData(list);

            return ExecuteDialog();
        }

        private void RefreshData(IList<SPWeb> list)
        {
            WebList.Items.Clear();

            foreach (SPWeb web in list)
                WebList.Items.Add(web, true);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            EnsureUsers();
        }

        private void EnsureUsers()
        {
            foreach (string user in UsersText.Lines)
            {   
                if (string.IsNullOrEmpty(user))
                    continue;

                foreach (int i in WebList.CheckedIndices)
                {
                    SPWeb web = WebList.Items[i] as SPWeb;
                   
                    try 
                    {
                        web.EnsureUser(user.Trim());

                        SquadronContext.WriteMessage("Success: " + web.ToString() + " " + user);
                    }
                    catch (Exception ex)
                    {
                        SquadronContext.WriteMessage("Failure: " + web.ToString() + " " + user + " " + ex.ToString());
                    }
                }
            }

            SquadronContext.Info("Operation Completed.. Please check the log for details.");
        }
    }
}
