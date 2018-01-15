using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron;
using Windows8LookNFeel;

namespace SquadronAddIns.Default.QuickTest.Dialogs
{
    public partial class TestInfoForm : Windows8LookNFeel.Windows8Form
    {
        public TestInfoForm()
        {
            InitializeComponent();
        }

        protected override void FormInit()
        {
            base.FormInit();

            if (_parameter != null)
                if (_parameter is List<TestResultEntity>)
                    grid.DataSource = (_parameter as List<TestResultEntity>);
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.DataSource != null)
                if (grid.DataSource is List<TestResultEntity>)
                {
                    List<TestResultEntity> list = grid.DataSource as List<TestResultEntity>;
                    if (e.RowIndex < list.Count)
                        if (list[e.RowIndex].Exception != null)
                            SquadronContext.Info(list[e.RowIndex].Exception.ToString());
                }
        }
    }
}
