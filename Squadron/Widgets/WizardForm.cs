using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Squadron.Widgets
{
    public partial class WizardForm : Windows8LookNFeel.Windows8Form
    {
        private IList<Control> Pages = new List<Control>();

        public WizardForm()
        {
            InitializeComponent();
        }

        private int _pageIndex;

        public int PageIndex
        {
            get { return _pageIndex; }
            set
            {
                bool isNext = false, isPrev = false;

                if (value < Pages.Count)
                    if (value > -1)
                    {
                        if (value > _pageIndex)
                            if (CanMoveNext(_pageIndex))
                            {
                                _pageIndex = value;
                                isNext = true;
                            }

                        if (value < _pageIndex)
                            if (CanMovePrevious(_pageIndex))
                            {
                                _pageIndex = value;
                                isPrev = true;
                            }
                    }

                BeforeShowPage(_pageIndex, isNext, isPrev);

                ShowPage(_pageIndex);
                ShowHideButtons();

                try
                {
                    NextButton.Enabled = PreviousButton.Enabled = false;
                    OnPageChanged(_pageIndex, isNext, isPrev);
                }
                finally
                {
                    NextButton.Enabled = PreviousButton.Enabled = true;
                }
            }
        }

        protected virtual void BeforeShowPage(int index, bool isNext, bool isPrev)
        {
        }

        protected virtual void OnPageChanged(int index, bool isNext, bool isPrev)
        {
        }

        protected void ShowHideButtons()
        {
            if (PageIndex > 0)
                PreviousButton.Show();
            else
                PreviousButton.Hide();

            if (PageIndex < (Pages.Count - 1))
            {
                NextButton.Show();
                FinishButton.Hide();
            }
            else
            {
                NextButton.Hide();
                FinishButton.Show();
            }
        }

        protected override void FormInit()
        {
            base.FormInit();

            Pages.Clear();

            foreach (TabPage page in tabControl1.TabPages)
                if (page.Controls.Count > 0)
                    Pages.Add(page.Controls[0]);

            PageIndex = 0;
        }

        private void ShowPage(int pageIndex)
        {
            WorkareaPanel.Controls.Clear();

            if (pageIndex < Pages.Count)
                WorkareaPanel.Controls.Add(Pages[pageIndex]);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            PageIndex++;
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            PageIndex--;
        }

        public virtual bool CanMoveNext(int index)
        {
            return true;
        }

        public virtual bool CanMovePrevious(int index)
        {
            return true;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            OnFinish();
        }

        protected virtual void OnFinish()
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void WizardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }
    }
}
