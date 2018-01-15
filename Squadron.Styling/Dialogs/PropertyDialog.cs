using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron.Styling.Widgets;

namespace Squadron.Styling
{
    public partial class PropertyDialog : StylingForm
    {
        public PropertyDialog()
        {
            InitializeComponent();
        }

        public void ExecuteDialog(object selectedObject)
        {
            grid.SelectedObject = selectedObject;
            this.ShowDialog();
        }
    }
}

