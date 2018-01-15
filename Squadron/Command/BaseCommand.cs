using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;
using SquadronAddIns.Default.Explorer;

namespace SquadronAddIns.Default.Command
{
    public class BaseCommand
    {
        public virtual string Text
        {
            get { return string.Empty; }
        }

        public virtual string TooltipText
        {
            get { return string.Empty; }
        }

        public virtual IEnumerable<Type> GetSupportedTypes()
        {
            IEnumerable<Type> types = new List<Type>();

            return types;
        }

        public virtual void Perform(object o, IExplorer explorer)
        {
        }

        protected void ThrowInvalidOperation()
        {
            throw new ApplicationException("Invalid Operation!");
        }

        public void SafePerform(object o, IExplorer explorer)
        {
            try
            {
                Perform(o, explorer);

                SquadronContext.WriteMessage(this.Text + " operation completed!");
            }
            catch (Exception ex)
            {
                SquadronContext.Errr(ex.ToString());
            }
        }
    }
}
