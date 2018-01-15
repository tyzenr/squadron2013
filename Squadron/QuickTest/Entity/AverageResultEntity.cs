using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Squadron;
using SquadronAddIns.Default.QuickTest.Core;

namespace SquadronAddIns.Default.QuickTest
{
    public class AverageResultEntity
    {
        public string Name
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        [DisplayName("No. of Tests")]
        public int NumberOfTests
        {
            get;
            set;
        }

        [Browsable(false)]
        public double AverageResponseTime
        {
            get;
            set;
        }

        [DisplayName("Avg. Response Time")]
        public string AverageResponseTimeFx
        {
            get { return Helper.Instance.FormatDouble(AverageResponseTime) + " second(s)"; }
        }

        public QuickTestConstants.QuickTestStatus Status
        {
            get;
            set;
        }

         [Browsable(false)]
        public IEnumerable<TestResultEntity> TestResults
        {
            get;
            set;
        }
    }
}
