using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron;
using Hx.General.HTML;

namespace SquadronAddIns.Default.Documentation.Controls
{
    public partial class GridPanel : UserControl
    {
        public GridPanel()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return HeaderPanel.Caption; }
            set { HeaderPanel.Caption = value; }
        }

        private IList<string> _gridColumns;

        public IList<string> GridColumns
        {
            get
            {
                return _gridColumns;
            }
            set
            {
                _gridColumns = value;
                OnGridColumnsChanged();
            }
        }

        private void OnGridColumnsChanged()
        {
            grid.Columns.Clear();
            grid.AutoGenerateColumns = false;

            foreach (string c in _gridColumns)
                grid.Columns.Add(new DataGridViewColumn() { Name = c, DataPropertyName = c, CellTemplate = new DataGridViewTextBoxCell() });

            Helper.Instance.ResizeRowsToFit(grid);
        }

        public object GridDataSource
        {
            get { return grid.DataSource; }
            set { grid.DataSource = value; }
        }

        private HTMLStyler _htmlStyler = new HTMLStyler();

        public string GetHTMLContent()
        {
            string result = _htmlStyler.GetH3HTMLText(HeaderPanel.Text);
            
            result += _htmlStyler.GetGridHTMLText(grid);

            return result;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Invalidate();
        }
    }
}
