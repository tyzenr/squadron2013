using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squadron
{
    public abstract class SquadronAddin
    {
        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract Type UserControlType { get; }

        private Control _UserControlInstance;

        public Control UserControlInstance
        {
            get
            {
                if (_UserControlInstance == null)
                    _UserControlInstance = Activator.CreateInstance(UserControlType) as UserControl;

                return _UserControlInstance;
            }
        }

        public Control DataControl { get; set; }

        public virtual string AuthorInfo
        {
            get { return string.Empty; }
        }

        public virtual string Group
        {
            get { return string.Empty; }
        }

        public virtual int Order
        {
            get { return 1000; }
        }

        public virtual int GroupOrder
        {
            get { return 1000; }
        }

        public virtual string HelpUrl
        {
            get { return string.Empty; }
        }

        public virtual bool IsEnabled
        {
            get { return true; }
        }

        public virtual void OnChange()
        {
        }
    }
}
