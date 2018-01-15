using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.QuickTest.Core;

namespace SquadronAddIns.Default.QuickTest
{
    public static class QuickTestLogic
    {
        public static QuickTestConstants.QuickTestStatus GetStatus(Exception e, double responseTime, out string message)
        {
            message = string.Empty;

            if (e != null)
            {
                message = "Exception";
                return QuickTestConstants.QuickTestStatus.Bad;
            }

            if (responseTime > 5)
            {
                message = "Response Time > 5 sec.";
                return QuickTestConstants.QuickTestStatus.Bad;
            }

            if (responseTime > 3)
            {
                message = "Response Time > 3 sec.";
                return QuickTestConstants.QuickTestStatus.Average;
            }

            return QuickTestConstants.QuickTestStatus.Good;
        }

        public static QuickTestConstants.QuickTestStatus GetStatus(IEnumerable<TestResultEntity> list)
        {
            double marks = 0;

            foreach (TestResultEntity t in list)
            {
                string desc = string.Empty;
                var status = GetStatus(t.Exception, t.ResponseTime, out desc);

                if (status == QuickTestConstants.QuickTestStatus.Good)
                    marks += 1.0;

                else if (status == QuickTestConstants.QuickTestStatus.Average)
                    marks += 0.5;

                else if (status == QuickTestConstants.QuickTestStatus.Bad)
                    marks += 0;
            }

            marks = (marks / (double)list.Count() * 100.0);

            if (marks >= 90)
                return QuickTestConstants.QuickTestStatus.Good;

            else if (marks >= 80)
                return QuickTestConstants.QuickTestStatus.Average;

            return QuickTestConstants.QuickTestStatus.Bad;
        }

        public static QuickTestConstants.QuickTestStatus GetStatus(IEnumerable<AverageResultEntity> list)
        {
            double marks = 0;

            foreach (AverageResultEntity t in list)
            {
                if (t.Status == QuickTestConstants.QuickTestStatus.Good)
                    marks += 1.0;

                else if (t.Status == QuickTestConstants.QuickTestStatus.Average)
                    marks += 0.5;

                else if (t.Status == QuickTestConstants.QuickTestStatus.Bad)
                    marks += 0;
            }

            marks = (marks / (double)list.Count() * 100.0);

            if (marks >= 90)
                return QuickTestConstants.QuickTestStatus.Good;

            else if (marks >= 80)
                return QuickTestConstants.QuickTestStatus.Average;

            return QuickTestConstants.QuickTestStatus.Bad;
        }
    }
}
