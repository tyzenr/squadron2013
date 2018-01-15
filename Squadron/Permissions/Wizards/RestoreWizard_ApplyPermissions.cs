using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.Permissions.Entity;
using SquadronAddIns.Default.Utility;
using Microsoft.SharePoint;
using Squadron;

namespace SquadronAddIns.Default.Permissions.Wizards
{
    partial class RestoreWizard
    {
        public void ApplyPermissions()
        {
            SquadronHelper.Instance.StartAnimation(true);

            try
            {
                _restoreExpert.ApplyPermissions(_permissionEntities);
            }
            finally
            {
                ErrorsText.Text = SquadronHelper.Instance.StopAnimation(true);
            }
        }
    }
}
