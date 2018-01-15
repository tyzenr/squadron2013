using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using System.ComponentModel;

namespace SquadronAddIns.Default.Utility.Entity
{
    public class SolutionEntity
    {
        public string Name
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string SolutionId
        {
            get { return this.SolutionGuid.ToString(); }
        }

        public string Status
        {
            get;
            set;
        }

        public string Site
        {
            get;
            set;
        }

        [Browsable(false)]
        public object InternalObject
        {
            get;
            set;
        }

        [Browsable(false)]
        public SPSite SPSite { get; set; }

        [Browsable(false)]
        public Guid SolutionGuid { get; set; }
    }
}
