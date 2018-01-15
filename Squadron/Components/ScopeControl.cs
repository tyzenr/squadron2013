using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squadron.Components
{
    public partial class ScopeControl : UserControl
    {
        public ScopeControl()
        {
            InitializeComponent();
        }

        public ScopeEnum Scope
        {
            get
            {
                if (WebApplicationRadio.Checked)
                    return ScopeEnum.WebApplication;

                else if (SiteCollectionRadio.Checked)
                    return ScopeEnum.SiteCollection;

                else if (SiteRadio.Checked)
                    return ScopeEnum.Site;

                return ScopeEnum.None;
            }
        }
    }

    public enum ScopeEnum
    {
        None,
        WebApplication,
        SiteCollection,
        Site
    }
}
