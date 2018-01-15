using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Exceptions
{
    public class InvalidURLException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Invalid URL!";
            }
        }
    }
}
