using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Squadron.Styling.Widgets
{
    public partial class StylingForm : Form
    {
        protected StylingManager _stylingManager = new StylingManager();

        public StylingForm()
        {
            InitializeComponent();
        }

        protected bool _isModal;
        protected object _parameter;

        public bool ExecuteDialog(object parameter)
        {
            _parameter = parameter;

            return ExecuteDialog();
        }

        public bool ExecuteDialog()
        {
            _isModal = true;

            this.FormInit();

            if (IsOverlayRequrired)
                ShowOverlayForm();

            try
            {
                // Show Form
                this.ShowDialog();
            }
            finally
            {
                if (IsOverlayRequrired)
                    HideOverlayForm();
            }

            return (this.DialogResult == DialogResult.OK);
        }

        public void Execute(bool flyin)
        {
            _isModal = false;

            this.Opacity = 0.25;

            this.Execute();

            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    this.Opacity += .15;
                    Application.DoEvents();
                    Thread.Sleep(100);
                }

                this.Opacity = 1;
            }
            catch
            {
            }
        }

        public void Execute()
        {
            _isModal = false;

            this.FormInit();

            this.Show();
        }

        public void Flyout()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    this.Opacity -= 0.1;
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
            }
            catch
            {
            }
            finally
            {
                if (!IsDisposed)
                    this.Dispose();
            }
        }

        public bool IsMouseWithinForm()
        {
            if ((Cursor.Position.X >= this.Left) && (Cursor.Position.X <= (this.Left + this.Width)))
                return true;

            if ((Cursor.Position.Y >= this.Top) && (Cursor.Position.Y <= (this.Top + this.Height)))
                return true;

            return false;
        }

        private Form _overlayForm;

        protected void HideOverlayForm()
        {
            if (_overlayForm != null)
            {
                _overlayForm.Hide();
                _overlayForm.Dispose();
                _overlayForm = null;
            }
        }

        protected void ShowOverlayForm()
        {
            HideOverlayForm();

            _overlayForm = new Form();
            _overlayForm.Opacity = .9;
            _overlayForm.WindowState = FormWindowState.Maximized;
            _overlayForm.ShowInTaskbar = false;
            _overlayForm.BackColor = Color.LightGray;

            _overlayForm.Show();
        }

        protected virtual bool IsOverlayRequrired
        {
            get
            {
                return true;
            }
        }

        protected virtual void FormInit()
        {
            _stylingManager.InitializeControls(this);

            HelpButton.StartBlinking();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            this.HeaderPanel.Caption = this.Text;
            this.HeaderPanel.Invalidate();
        }

        protected virtual bool AreInputsValid()
        {
            return true;
        }

        protected virtual bool WarnIfFalse(bool condition, string message)
        {
            if (condition)
                return true;
            else
            {
                Warn(message);
                return false;
            }
        }

        protected void Warn(string message)
        {

        }

        public string HeaderText
        {
            get { return this.HeaderPanel.Text; }
            set { HeaderPanel.Text = value; }
        }

        public virtual bool IsFlyout
        {
            get;
            set;
        }

        public void PositionToMouse()
        {
            this.StartPosition = FormStartPosition.Manual;

            if ((Cursor.Position.X + this.Width) < Screen.PrimaryScreen.WorkingArea.Width)
                this.Left = Cursor.Position.X;
            else
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;

            if ((Cursor.Position.Y + this.Height) < Screen.PrimaryScreen.WorkingArea.Height)
                this.Top = Cursor.Position.Y;
            else
                this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
        }

        private void StylingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isModal)
                if (e.KeyCode == Keys.Escape)
                    if (CanCloseOnEscapeKey)
                        Close();
        }

        protected virtual bool CanCloseOnEscapeKey
        {
            get { return true; }
        }

        public bool ShowFooter
        {
            get { return this.FooterPanel.Visible; }
            set { this.FooterPanel.Visible = value; }
        }
    }
}
