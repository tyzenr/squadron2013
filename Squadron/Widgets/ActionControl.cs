using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Windows8LookNFeel;

namespace Squadron.Widgets
{
    public partial class ActionControl : FlowLayoutPanel
    {
        public ActionControl()
        {
            InitializeComponent();

            BackColor = Color.WhiteSmoke;
            AutoScroll = true;
            _tooltip = new ToolTip();
        }

        private ToolTip _tooltip;

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);

            foreach (Control control in this.Controls)
                control.Width = this.Width;
        }

        public void Add(ActionGroup group)
        {
            ActionRowControl header = new ActionRowControl() { Caption = string.Empty, Width = this.Width, BackColor = Color.Chartreuse, ActionGroup = group, Height = 20, BorderStyle = System.Windows.Forms.BorderStyle.None };
            Windows8CheckBox chk = new Windows8CheckBox() { Dock = DockStyle.Left, Text = group.Name, ForeColor = Color.WhiteSmoke, BackColor = Color.Transparent, Padding = new Padding(5, 0, 0, 0), Width = 180, Font = new Font(Font.Name, Font.Size, FontStyle.Bold) };
            chk.CheckedChanged += new EventHandler(chk_CheckedChanged);
            header.Controls.Add(chk);

            this.Controls.Add(header);
        }

        void chk_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Windows8Panel panel in GetActionPanelsForGroup(((sender as CheckBox).Parent as ActionRowControl).ActionGroup))
                (panel.Controls[0] as CheckBox).Checked = (sender as CheckBox).Checked;
        }

        private IEnumerable<Windows8Panel> GetActionPanelsForGroup(ActionGroup group)
        {
            int startIndex = -1;

            foreach (ActionRowControl rc in this.Controls)
                if (object.ReferenceEquals(rc.ActionGroup, group))
                {
                    startIndex = this.Controls.IndexOf(rc) + 1;
                    break;
                }

            if (startIndex > -1)
                if (startIndex < this.Controls.Count)
                    for (int i = startIndex; i < Controls.Count; i++)
                        if (this.Controls[i] is ActionRowControl)
                            if ((this.Controls[i] as ActionRowControl).Action != null)
                                yield return this.Controls[i] as Windows8LookNFeel.Windows8Panel;
                            else
                                break;
        }

        public void Add(Action action)
        {
            ActionRowControl container = new ActionRowControl() { Caption = string.Empty, Width = this.Width, BackColor = Color.WhiteSmoke, Action = action, Height = 22, BorderStyle = System.Windows.Forms.BorderStyle.None };

            Windows8CheckBox checkbox = new Windows8CheckBox()
            {
                Tag = action,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Text = action.Name,
                ForeColor = Color.Gray,
                BackColor = Color.Transparent,
                Padding = new Padding(25, 0, 0, 0),
                Width = 200,
                Left = 20
            };
            _tooltip.SetToolTip(checkbox, action.Description);
            container.Controls.Add(checkbox);

            Windows8Button button = new Windows8Button() { Left = container.Controls[0].Width + 24, Top = 2, DrawingColor = Windows8DrawingColor.AlternativeColor, Caption = "Execute", Width = 55, Height = 22 };
            button.Click += new EventHandler(button_Click);
            container.Controls.Add(button);

            Windows8Panel progressPanel = new Windows8Panel() { BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle, Visible = false, Top = 5, Left = container.Controls[1].Left + container.Controls[1].Width + 6, Text = string.Empty, Width = 120, Height = 14 };
            container.Controls.Add(progressPanel);

            LinkLabel linkLabel = new LinkLabel() { Visible = false, Top = 2, Left = container.Controls[2].Left + container.Controls[2].Width + 4, Text = "Details", AutoSize = true };
            linkLabel.Click += new EventHandler(linkLabel_Click);
            linkLabel.Tag = action;
            container.Controls.Add(linkLabel);

            action.HeaderPanel = container;

            action.Container = container;

            this.Controls.Add(container);
        }

        void linkLabel_Click(object sender, EventArgs e)
        {
            Action action = (sender as LinkLabel).Tag as Action;

            MessageDialog dialog = new MessageDialog();
            dialog.Text = "Details";
            dialog.Width *= 2;
            dialog.Height *= 2;
            dialog.MessageText.ScrollBars = ScrollBars.Both;

            if (action.DetailsList.Count > 0)
                dialog.ExecuteDialog(action.DetailsList);
            else
                dialog.ExecuteDialog(GetDetailsFx(action));
        }

        private string GetDetailsFx(Action action)
        {
            if (string.IsNullOrEmpty(action.Details))
                return "No Details!";

            return action.Details;
        }

        public delegate void BeforeExecuteEventHandler(Action action);
        public event BeforeExecuteEventHandler BeforeExecute;

        void button_Click(object sender, EventArgs e)
        {
            Action action = ((sender as Windows8Button).Parent as ActionRowControl).Action;

            action.Execute();
        }

        public void CheckAll()
        {
            foreach (Control control in this.Controls)
                if (control is Windows8Panel)
                    ((control as Windows8Panel).Controls[0] as CheckBox).Checked = true;
        }

        public void UncheckAll()
        {
            foreach (Control control in this.Controls)
                if (control is Windows8Panel)
                    ((control as Windows8Panel).Controls[0] as CheckBox).Checked = false;
        }

        public IList<Action> GetCheckedActions()
        {
            IList<Action> result = new List<Action>();

            foreach (ActionRowControl rc in this.Controls)
                if (rc.Action != null)
                    if (rc.CheckBox.Checked)
                        result.Add(rc.Action);

            return result;
        }

        public IList<Action> GetAllActions()
        {
            IList<Action> result = new List<Action>();

            foreach (ActionRowControl rc in this.Controls)
                if (rc.Action != null)
                    result.Add(rc.Action);

            return result;
        }

        public class ActionRowControl : Windows8Panel
        {
            public ActionGroup ActionGroup;
            public Action Action;

            public ActionRowControl()
            {
                BorderStyle = System.Windows.Forms.BorderStyle.None;
                HasBorder = false;
            }

            public void BeforeExecute(Action action)
            {
                if ((this.Parent as ActionControl).BeforeExecute != null)
                    (this.Parent as ActionControl).BeforeExecute(action);
            }

            public CheckBox CheckBox
            {
                get { return this.Controls[0] as CheckBox; }
            }

            public Windows8Button ExecuteButton
            {
                get { return this.Controls[1] as Windows8Button; }
            }

            public Windows8Panel ProgressPanel
            {
                get { return this.Controls[2] as Windows8Panel; }
            }

            public LinkLabel DetailsLink
            {
                get { return this.Controls[3] as LinkLabel; }
            }

            public void OnStatusChanged(Action action)
            {
                if (action.Status == ActionStatusEnum.None)
                {
                    action.Container.ProgressPanel.Hide();
                    action.Container.DetailsLink.Hide();
                }
                else
                {
                    if (action.Status == ActionStatusEnum.Executing)
                    {
                        action.Container.ProgressPanel.BackColor = Color.Blue;
                    }

                    else if (action.Status == ActionStatusEnum.Green)
                    {
                        action.Container.ProgressPanel.BackColor = Color.Lime;
                    }

                    else if (action.Status == ActionStatusEnum.Red)
                    {
                        action.Container.ProgressPanel.BackColor = Color.Red;
                    }

                    action.Container.ProgressPanel.Show();
                    action.Container.DetailsLink.Show();
                }
            }
        }

        public class Action
        {
            public virtual string Name
            {
                get;
                set;
            }

            public virtual string Description
            {
                get;
                set;
            }

            public string Details;
            public IList<object> DetailsList = new List<object>();

            public bool Execute()
            {
                this.Container.BeforeExecute(this);

                Status = ActionStatusEnum.Executing;
                Details = string.Empty;
                DetailsList.Clear();

                Application.DoEvents();

                bool result = InternalExecute();

                Application.DoEvents();

                return result;
            }

            protected virtual bool InternalExecute()
            {
                Thread.Sleep(300);

                Status = ActionStatusEnum.Green;

                return true;
            }

            public IList<object> SharePointObjects
            {
                get;
                set;
            }

            public Windows8Panel HeaderPanel { get; set; }

            private ActionStatusEnum _status = ActionStatusEnum.None;

            public ActionStatusEnum Status
            {
                get
                {
                    return _status;
                }

                set
                {
                    _status = value;

                    Container.OnStatusChanged(this);
                }
            }

            public ActionRowControl Container;

            protected bool DisplayResult(bool isGreen)
            {
                if (isGreen)
                    Status = ActionControl.ActionStatusEnum.Green;

                else
                    Status = ActionControl.ActionStatusEnum.Red;

                return isGreen;
            }

            public virtual string HelpUrl
            {
                get { return string.Empty; }
            }
        }

        public enum ActionStatusEnum
        {
            None,
            Executing,
            Green,
            Yellow,
            Red
        }

        public class ActionGroup
        {
            public string Name
            {
                get;
                set;
            }
        }
    }
}
