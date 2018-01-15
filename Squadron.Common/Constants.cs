using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Squadron
{
    public static class Constants
    {
        public const string ApplicationTitle = "Squadron";

        public const string Status_Disabled = "(Disabled)";
        public const string Status_Locked = "(Locked)";

        public const string SquadronUrl = "http://www.sharepointcto.com/Squadron/Default.aspx";

        public static Color Yellow = Color.FromArgb(219, 253, 85);

        // Reduced Version for ATPCO
        public static bool IsReducedVersion;
    }
}
