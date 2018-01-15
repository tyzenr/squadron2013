using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.Utility.Entity;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Squadron;
using System.Collections.ObjectModel;

namespace SquadronAddIns.Default.Utility
{
    public class SolutionUtility
    {
        private SharePointUtility _utility = new SharePointUtility();

        public IList<SolutionEntity> GetSolutions(string url)
        {
            IList<SolutionEntity> result = new List<SolutionEntity>();

            GetSandboxedSolutions(url, result);
            GetFarmSolutions(url, result);

            return result;
        }

        private void GetSandboxedSolutions(string url, IList<SolutionEntity> result)
        {
            foreach (SPSite site in _utility.GetSharePointObjects(url).OfType<SPSite>())
                foreach (SPUserSolution s in site.Solutions)
                {
                    SolutionEntity entity = new SolutionEntity();
                    entity.Name = s.Name;
                    entity.Type = "Sandbox Solution";
                    entity.SolutionGuid = s.SolutionId;
                    entity.Status = s.Status.ToString();
                    entity.SPSite = site;
                    entity.Site = _utility.GetDisplayName(site, true);
                    entity.InternalObject = s;

                    result.Add(entity);
                }
        }

        private void GetFarmSolutions(string url, IList<SolutionEntity> result)
        {
            foreach (SPSolution s in SPFarm.Local.Solutions)
            {
                SolutionEntity entity = new SolutionEntity();
                entity.Name = s.Name;
                entity.Type = "Farm Solution";
                entity.SolutionGuid = s.Id;
                entity.Status = s.Status.ToString();
                entity.InternalObject = s;
                entity.Site = "(none)";

                result.Add(entity);
            }
        }

        public void RemoveSolution(SolutionEntity solution)
        {
            if (solution.Type == "Farm Solution")
            {
                var apps = _utility.GetAllWebApplications();

                (solution.InternalObject as SPSolution).RetractLocal(apps);
            }
        }

        public void DeleteSolution(SolutionEntity solution)
        {
            try
            {
                if (solution.Type == "Sandbox Solution")
                {
                    solution.SPSite.Solutions.Remove(solution.InternalObject as SPUserSolution);
                }

                else if (solution.Type == "Farm Solution")
                {
                    SPFarm.Local.Solutions.Remove(solution.SolutionGuid);
                }
            }
            catch (Exception ex)
            {
                SquadronContext.Errr(ex.ToString());
            }
        }
    }
}
