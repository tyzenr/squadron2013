using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddIns.Default.Size.Entity
{
    public class DbSizeEntity
    {
        public string Name
        {
            get;
            set;
        }

        [Browsable(false)]
        public ulong Size
        {
            get;
            set;
        }

        [DisplayName("Size (MB)")]
        public string SizeInMB
        {
            get
            {
                if (Size > 0)
                    return Math.Round((decimal)(Size / (1024 * 1024))).ToString() + " MB";

                return string.Empty;
            }
        }

        [DisplayName("Size (GB)")]
        public string SizeInGB
        {
            get
            {
                if (Size > 0)
                    return Helper.Instance.FormatDouble(((double) Size / (1024 * 1024 * 1024))) + " GB";

                return string.Empty;
            }
        }
    }
}
