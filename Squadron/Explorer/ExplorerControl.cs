using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron;
using SquadronAddIns.Exceptions;

namespace SquadronAddIns.Default.Explorer
{
    public partial class ExplorerControl : UserControl, IExplorer
    {
        public ExplorerControl()
        {
            InitializeComponent();

            RefreshData();
        }

        public void RefreshData()
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                explorer.Url = SquadronContext.Url;
            }
            catch (InvalidURLException iex)
            {
                SquadronContext.Errr(iex.Message.ToString(), "http://jeanpaulva.com/2013/04/01/squadron-invalid-url-exception-solutions/");
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void browser_OnSelect(object sender, object item)
        {
            grid.SelectedObject = item;

            EnableCommands(item);
        }

        public void DeleteSelectedNode()
        {
            explorer.DeleteSelectedNode();
        }
    }
}
