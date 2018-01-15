using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron.Components;

namespace SquadronAddIns.Default
{
    public class ScopeDropDownControl : ComboBox
    {
        public ScopeDropDownControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public ScopeEnum Scope
        {
            get
            {
                if (SelectedIndex == 0)
                    return ScopeEnum.WebApplication;

                else if (SelectedIndex == 1)
                    return ScopeEnum.SiteCollection;

                else if (SelectedIndex == 2)
                    return ScopeEnum.Site;

                return ScopeEnum.None;
            }
        }
    }
}
