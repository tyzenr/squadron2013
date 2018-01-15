using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.Utility;

namespace SquadronAddIns.Default.Exceptions
{
    public class ObjectException : ApplicationException
    {
        private object _object;
        private Exception _exception;

        public ObjectException(object o, Exception ex)
        { 
            _object = o;
            _exception = ex;
        }

        private SharePointUtility _utility = new SharePointUtility();

        public override string Message
        {
            get
            {
                return "Exception @ " + _utility.GetDisplayName(_utility, true) + " >> " + _exception.ToString();
            }
        }
    }
}
