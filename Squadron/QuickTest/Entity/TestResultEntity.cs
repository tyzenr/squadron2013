using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Squadron;
using SquadronAddIns.Default.QuickTest.Core;

namespace SquadronAddIns.Default.QuickTest
{
    public class TestResultEntity
    {
        [DisplayName("Request")]
        public string TestName
        {
            get;
            set;
        }

        [Browsable(false)]
        public double ResponseTime
        {
            get;
            set;
        }

        [DisplayName("Response Time")]
        public string ResponseTimeFx
        {
            get { return Helper.Instance.FormatDouble(ResponseTime) + " second(s)"; }
        }

        [Browsable(false)]
        public bool Success
        {
            get
            {
                return (Exception == null);
            }
        }

        [Browsable(false)]
        public Exception Exception
        {
            get;
            set;
        }

        public QuickTestConstants.QuickTestStatus Status
        {
            get
            {
                string d = string.Empty;
                var result = QuickTestLogic.GetStatus(Exception, ResponseTime, out d);
                Description = d;

                return result;
            }
        }

        public string Description
        {
            get;
            set;
        }
    }
}
