using Hx.General.HTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;
using System.Windows.Forms;
using Hx.General;
using SquadronAddIns.Default.Documentation.Controls;

namespace SquadronAddIns.Default.Documentation
{
    partial class DocumentationControl
    {
        private HTMLStyler _htmlStyler = new HTMLStyler();

        private string GetHTMLReport()
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                // Header
                string result = _htmlStyler.GetStyleHTMLText();

                result += _htmlStyler.GetH2HTMLText(Constants.ApplicationTitle + " - Documentation");

                // Grids
                foreach (GridPanel gp in ResultPanel.Controls.OfType<GridPanel>())
                    result += gp.GetHTMLContent();

                // Footer
                result += _htmlStyler.GetBreak();
                result += _htmlStyler.GetLinkHTMLText("(Report generated on " + GeneralUtils.FormatDateTime(DateTime.Now) + " with Squadron)", Constants.SquadronUrl);

                return result;
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }
    }
}
