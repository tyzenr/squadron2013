using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Squadron;
using System.Net;
using System.Collections;
using Windows8LookNFeel;
using SquadronAddIns.Default.QuickTest.Dialogs;
using SquadronAddIns.Default.Utility;
using Microsoft.SharePoint;
using System.Threading;
using Squadron.Widgets;

namespace SquadronAddIns.Default.QuickTest
{
    public partial class QuickTestControl : UserControl
    {
        public QuickTestControl()
        {
            InitializeComponent();

            UrlText.Text = SquadronContext.Url;
            UrlOnlyCheck.Checked = true;
        }

        private int _testCount;
        private List<TestResultEntity> _testList = new List<TestResultEntity>();

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            SquadronHelper.Instance.StartAnimation();
            List<AverageResultEntity> averageList = new List<AverageResultEntity>();
            int count = (int)CountText.Value;
            _testCount = 0;
            int rc = 0;

            SquadronContext.ClearMessages();
            var urls = GetUrls();
            SquadronContext.WriteMessage("Starting Testing: " + urls.Count().ToString() + " URL(s) found..");
            bool firstTestDone = false;

            try
            {
                foreach (string url in urls)
                {
                    if (!firstTestDone)
                    {
                        CheckResponse(url); // First test
                        firstTestDone = true;
                    }

                    _testList.Clear();

                    for (int i = 1; i <= count; i++)
                    {
                        CheckResponseAddEntity(new ThreadParam() { Url = url, Index = i });
                    }

                    averageList.Add(GetAverageResultEntity(_testList, url, count));

                    grid.DataSource = null;
                    grid.DataSource = averageList;

                    if (rc++ > 10)
                        Application.DoEvents();
                }

                grid.DataSource = null;
                grid.DataSource = averageList;
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
                ShowAverageResultSummary("Simple Test", averageList);
            }
        }

        private void CheckResponseAddEntity(object o)
        {
            string url = string.Empty;
            int i = 0;

            if (o != null)
            {
                url = (o as ThreadParam).Url;
                i = (o as ThreadParam).Index;
            }

            TestResultEntity entity = new TestResultEntity();
            entity.TestName = "Request " + i.ToString();

            DateTime startTime = DateTime.Now;
            try
            {
                CheckResponse(url);
            }
            catch (Exception ex)
            {
                entity.Exception = ex;
                SquadronContext.WriteMessage(ex.ToString());
            }

            TimeSpan span = DateTime.Now - startTime;
            if (entity.Success)
            {
                entity.ResponseTime = span.TotalSeconds;
            }
            else
            {
                entity.TestName += " (Exception)";
            }

            lock (this)
            {
                _testList.Add(entity);
            }
        }

        private IEnumerable<string> GetUrls()
        {
            IList<string> result = new List<string>();

            if (UrlOnlyCheck.Checked)
                result.Add(UrlText.Text);

            if (SubSiteCheck.Checked)
                foreach (string url in GetSubSiteUrls(UrlText.Text))
                    if (!result.Contains(url))
                        result.Add(url);

            if (AllLibraryAndListCheck.Checked)
                foreach (string url in GetLibraryAndListUrls(UrlText.Text))
                    if (!result.Contains(url))
                        result.Add(url);

            return result;
        }

        private IEnumerable<string> GetLibraryAndListUrls(string url)
        {
            foreach (object o in _utility.GetSharePointObjects(url, false, false, true, true, false, string.Empty))
                if (o is SPWeb)
                    yield return (o as SPWeb).Url;

                else if (o is SPList)
                    yield return _utility.GetUrl(o);
        }

        private SharePointUtility _utility = new SharePointUtility();

        private IEnumerable<string> GetSubSiteUrls(string url)
        {
            foreach (SPWeb web in _utility.GetSharePointObjects(url, false, false, true, false, false, string.Empty))
                yield return web.Url;
        }

        private AverageResultEntity GetAverageResultEntity(List<TestResultEntity> testList, string url, int count)
        {
            AverageResultEntity result = new AverageResultEntity();
            result.Name = "Test " + (++_testCount).ToString();
            result.Url = url;
            result.NumberOfTests = count;
            result.Type = "Read";
            result.TestResults = testList;

            double average = 0;
            foreach (TestResultEntity t in result.TestResults)
                average += t.ResponseTime;

            result.AverageResponseTime = average / result.TestResults.Count();
            result.Status = QuickTestLogic.GetStatus(result.TestResults);

            return result;
        }

        private void ShowAverageResultSummary(string type, List<AverageResultEntity> list)
        {
            int exceptionsCount = 0;

            foreach (AverageResultEntity a in list)
                foreach (TestResultEntity t in a.TestResults)
                    if (t.Exception != null)
                        exceptionsCount++;

            TestTypeLabel.Text = type;
            CountLabel.Text = list.Sum(t => t.TestResults.Count()).ToString();
            ExceptionCountLabel.Text = exceptionsCount.ToString();

            StatusPanel.Status = (StatusPanel.StatusEnum)(int)QuickTestLogic.GetStatus(list);
        }

        private void ShowTestResultSummary(string type, List<TestResultEntity> list)
        {
            int testCount = (int)CountText.Value;

            int exceptionsCount = list.Where(i => i.Exception != null).Count();

            TestTypeLabel.Text = type;
            CountLabel.Text = testCount.ToString();
            ExceptionCountLabel.Text = exceptionsCount.ToString();

            if (exceptionsCount == 0)
            {
                StatusPanel.Status = StatusPanel.StatusEnum.Good;
            }
            else if ((exceptionsCount > 0) && (exceptionsCount > (testCount * 0.1)))
            {
                StatusPanel.Status = StatusPanel.StatusEnum.Bad;
            }
            else
            {
                StatusPanel.Status = StatusPanel.StatusEnum.Average;
            }
        }

        private HttpWebResponse CheckResponse(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "GET";
                request.Timeout = 10000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                return response;
            }
            catch
            {
            }

            return null;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.DataSource != null)
                if (grid.DataSource is List<AverageResultEntity>)
                {
                    List<AverageResultEntity> list = grid.DataSource as List<AverageResultEntity>;
                    new TestInfoForm().ExecuteDialog(list[e.RowIndex].TestResults);
                }
        }

        private void UrlOnlyCheck_CheckedChanged(object sender, EventArgs e)
        {
            SubSiteCheck.Checked = AllLibraryAndListCheck.Checked = !UrlOnlyCheck.Checked;
        }

        private void ThreadedTestButton_Click(object sender, EventArgs e)
        {
            SquadronHelper.Instance.StartAnimation();
            List<AverageResultEntity> averageList = new List<AverageResultEntity>();
            int count = (int)CountText.Value;
            _testCount = 0;
            int rc = 0;

            SquadronContext.ClearMessages();
            var urls = GetUrls();
            SquadronContext.WriteMessage("Starting Testing: " + urls.Count().ToString() + " URL(s) found..");
            bool firstTestDone = false;

            try
            {
                foreach (string url in urls)
                {
                    if (!firstTestDone)
                    {
                        CheckResponse(url); // First test
                        firstTestDone = true;
                    }

                    _testList.Clear();

                    IList<Thread> threadList = new List<Thread>();

                    for (int i = 1; i <= count; i++)
                    {
                        ThreadParam param = new ThreadParam()
                        {
                            Url = url,
                            Index = i
                        };

                        Thread thread = new Thread(new ParameterizedThreadStart(CheckResponseAddEntity));
                        thread.Start(param);

                        threadList.Add(thread);
                    }

                    WaitForThreadsToComplete(threadList);

                    averageList.Add(GetAverageResultEntity(_testList, url, count));

                    grid.DataSource = null;
                    grid.DataSource = averageList;

                    if (rc++ > 10)
                        Application.DoEvents();
                }

                grid.DataSource = null;
                grid.DataSource = averageList;
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
                ShowAverageResultSummary("Threaded Test", averageList);
            }
        }

        private void WaitForThreadsToComplete(IList<Thread> threadList)
        {
            while (true)
            {
                if (threadList.Count(t => t.ThreadState == ThreadState.Running) == 0)
                    break;
 
                Application.DoEvents();
            }
        }
    }

    public class ThreadParam
    {
        public string Url;
        public int Index;
    }
}


// Recommended Average Response Time is < 3 Seconds
