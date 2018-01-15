using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;

namespace SquadronAddins.Default.CopyItems
{
    public partial class CopyControl : UserControl
    {
        public CopyControl()
        {
            InitializeComponent();
        }

        private int _nextTop;

        public void ClearAll()
        {
            ContainerPanel.Controls.Clear();
            _nextTop = 1;
        }

        public void AddItem(string sourceListName, SPWeb sourceWeb, SPWeb destWeb)
        {
            if (!DoesSourceListNameExists(sourceListName))
                InternalAddItem(sourceListName, sourceWeb, destWeb);
        }

        private void InternalAddItem(string sourceListName, SPWeb sourceWeb, SPWeb destWeb)
        {
            CopyItemControl control = new CopyItemControl();
            control.SourceListName = sourceListName;
            control.DestinationListName = sourceListName;
            control.SourceWeb = sourceWeb;
            control.DestinationWeb = destWeb;
            control.Calculate();

            ContainerPanel.Controls.Add(control);
            control.Parent = ContainerPanel;
            control.Left = 2;
            control.Top = _nextTop;

            _nextTop += control.Height + 1;
        }

        private Control _currentItem;

        private bool DoesSourceListNameExists(string sourceListName)
        {
            foreach (Control control in this.ContainerPanel.Controls)
                if (control is CopyItemControl)
                    if ((control as CopyItemControl).SourceListName == sourceListName)
                    {
                        _currentItem = control;
                        return true;
                    }

            return false;
        }

        public void RemoveItem(string sourceListName, SPWeb sourceWeb, SPWeb destWeb)
        {
            if (DoesSourceListNameExists(sourceListName))
            {
                _currentItem.Dispose();

                _nextTop = 1;
                foreach (Control control in this.ContainerPanel.Controls)
                {
                    control.Top = _nextTop;

                    _nextTop += control.Height + 1;
                }
            }
        }

        public IEnumerable<CopyItemControl> GetCopyControls()
        {
            foreach (CopyItemControl control in this.ContainerPanel.Controls)
                if (control.IsValid)
                    yield return control;
        }
    }
}
