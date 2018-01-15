using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows8LookNFeel;

namespace Squadron.CanvasData
{
    public class AddinView
    {
        public SquadronAddin Addin { get; set; }

        public override string ToString()
        {
            return GetDataFormat(Addin);
        }

        private string GetDataFormat(SquadronAddin Addin)
        {
            if (Addin.UserControlType != null)
            {
                foreach (Control control in Helper.Instance.GetControlsRecursively(Addin.UserControlInstance))
                {
                    if ((control is DataGridView) && (control as DataGridView).Visible)
                    {
                        Addin.DataControl = control;

                        return Addin.Name + " (Grid with " + Helper.Instance.GetRowCount(control as DataGridView).ToString() + " rows)";
                    }
                    else if ((control is ListBox) && (control as ListBox).Visible)
                    {
                        Addin.DataControl = control;

                        return Addin.Name + " (List with " + Helper.Instance.GetRowCount(control as ListBox).ToString() + " items)";
                    }
                }
            }

            return Addin.Name + " (No Data)";
        }
    }
}
