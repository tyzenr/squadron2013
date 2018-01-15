using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Squadron;

namespace SquadronAddIns.Default.Utility.Entity
{
    public class SizeEntity
    {
        public string Title
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        [Browsable(false)]
        public object InternalObject
        {
            get;
            set;
        }

        [Browsable(false)]
        public long SizeLong
        {
            get;
            set;
        }

        [Browsable(false)]
        public DateTime ModifiedDate
        {
            get;
            set;
        }

        public bool IsSizeInGB;

        public string Size
        {
            get 
            {
                if (IsSizeInGB)
                    return Helper.Instance.FormatDouble(Helper.Instance.ConvertBytesToGigabytes(SizeLong)) + " GB";
                else
                    return Helper.Instance.FormatDouble(Helper.Instance.ConvertBytesToMegabytes(SizeLong)) + " MB";
            }
        }

        public string ModifiedOn
        {
            get { return ModifiedDate.ToShortDateString(); }
        }
    }
}
