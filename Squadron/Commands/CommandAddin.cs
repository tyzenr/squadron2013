using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;

namespace SquadronAddins.Default.Commands
{
    public class CommandAddin : SquadronAddin
    {
        public override string Name
        {
            get { return "Command"; }
        }

        public override string Description
        {
            get { return @"Execute Operating System Commands (%windir%\system32\cmd.exe)"; }
        }

        public override Type UserControlType
        {
            get { return typeof(CommandControl); }
        }

        public override bool IsEnabled
        {
            get
            {
                return false;
            }
        }
    }
}
