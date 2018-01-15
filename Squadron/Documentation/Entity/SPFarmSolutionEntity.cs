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
    public class SPFarmSolutionEntity
    {
        private SPSolution _underlyingObject;

        public SPFarmSolutionEntity(SPSolution solution)
        {
            _underlyingObject = solution;
        }

        public Guid Id
        {
            get { return _underlyingObject.Id; }
        }

        public string Name
        {
            get { return _underlyingObject.Name; }
        }

        public SPObjectStatus Status
        {
            get { return _underlyingObject.Status; }
        }

        public string DeployedWebApplications
        {
            get 
            {
                try
                {
                    string result = string.Empty;

                    foreach (SPWebApplication wa in _underlyingObject.DeployedWebApplications)
                        result += wa.DisplayName + ", ";

                    if (!string.IsNullOrEmpty(result))
                        result = result.Substring(0, result.Length - 2);

                    return result;
                }
                catch (Exception ex)
                {
                    return "(exception)";
                }
            }
        }
    }
}
