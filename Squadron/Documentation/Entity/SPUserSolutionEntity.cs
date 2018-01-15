using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Utilities;
using Squadron;
using SquadronAddIns.Default.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquadronAddIns.Default.Documentation
{
    public class SPUserSolutionEntity
    {
        private SPUserSolution _underlyingObject;

        public SPUserSolutionEntity(SPUserSolution solution)
        {
            _underlyingObject = solution;
        }

        public Guid SolutionId
        {
            get { return _underlyingObject.SolutionId; }
        }

        public string Name
        {
            get { return _underlyingObject.Name; }
        }

        public SPUserSolutionStatus Status
        {
            get { return _underlyingObject.Status; }
        }

        public string DeployedSiteCollectionUrl
        {
            get;
            set;
        }
    }
}
