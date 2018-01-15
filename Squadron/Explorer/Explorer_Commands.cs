using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.Command;
using Windows8LookNFeel;
using Squadron;
using System.Diagnostics;

namespace SquadronAddIns.Default.Explorer
{
    partial class ExplorerControl
    {
        private IList<BaseCommand> _commands = new List<BaseCommand>();

        private void InitCommands()
        {
            if (_commands.Count == 0)
            {
                _commands.Add(new EnsureUserCommand());
                _commands.Add(new CheckoutCommand());
                _commands.Add(new UndoCheckoutCommand());
                _commands.Add(new PowerShellCodeCommand());

                if (Debugger.IsAttached)
                {
                    _commands.Add(new ExportSiteCommand());
                    _commands.Add(new ImportSiteCommand());
                    _commands.Add(new CopySiteCommand());
                    _commands.Add(new EditCommand());
                }

                _commands.Add(new DeleteCommand());
            }
        }

        private void EnableCommands(object selectedObject)
        {
            InitCommands();
            ClearCommandButtons();
            CreateCommandButtons(selectedObject);
        }

        private void CreateCommandButtons(object selectedObject)
        {
            Type type = selectedObject.GetType();

            foreach (BaseCommand c in GetFilteredCommands(type))
            {
                Windows8LookNFeel.Windows8Button b = new Windows8LookNFeel.Windows8Button();
                b.DrawingColor = Windows8DrawingColor.DefaultColor;
                b.Caption = c.Text;
                b.Width = 120;
                b.Height = 20;
                b.Tag = new CommandAndObject() { Command = c, SharePointObject = selectedObject };
                tooltip.SetToolTip(b, c.TooltipText);
                flowPanel.Controls.Add(b);

                b.Click += new EventHandler(b_Click);
            }

            SquadronHelper.Instance.WidgetManager.InitializeControls(flowPanel);
        }

        void b_Click(object sender, EventArgs e)
        {
            CommandAndObject cando = (sender as Windows8LookNFeel.Windows8Button).Tag as CommandAndObject;
            cando.Command.SafePerform(cando.SharePointObject, this);
        }

        private IEnumerable<BaseCommand> GetFilteredCommands(Type type)
        {
            foreach (BaseCommand c in _commands)
                if (c.GetSupportedTypes().Any(t => t == type))
                    yield return c;
        }

        private void ClearCommandButtons()
        {
            flowPanel.Controls.Clear();
        }
    }

    public class CommandAndObject
    {
        public BaseCommand Command;
        public object SharePointObject;
    }
}
