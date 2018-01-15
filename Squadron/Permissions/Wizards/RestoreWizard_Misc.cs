using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.Permissions.Entity;
using System.Windows.Forms;
using SquadronAddIns.Default.Utility;

namespace SquadronAddIns.Default.Permissions.Wizards
{
    partial class RestoreWizard
    {
        private void DisplayToTreeview(IList<Entity.PermissionEntity> permissionEntities)
        {
            tvMatch.Nodes.Clear();

            foreach (PermissionEntity entity in permissionEntities)
            {
                TreeNode pnode = tvMatch.Nodes.Add("[Source] " + entity.Type + " " + entity.Url);

                string match = "Matches (" + entity.Matches.Count.ToString() + ")";
                TreeNode mnode = pnode.Nodes.Add(match);

                foreach (SecurableObject so in entity.Matches)
                    mnode.Nodes.Add("[Destination] " + so.Type + " " + so.Url);
            }

            tvMatch.ExpandAll();
        }
    }
}
