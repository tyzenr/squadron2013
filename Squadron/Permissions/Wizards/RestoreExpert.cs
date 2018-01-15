using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SquadronAddIns.Default.Permissions.Entity;
using SquadronAddIns.Default.Permissions.Wizards;
using SquadronAddIns.Default.Utility;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Squadron;

namespace SquadronAddIns.Default.Permissions.Wizards
{
    public class RestoreExpert
    {
        public int TotalRows;
        public int TotalSecurableObjects;

        public void AnalyzeTable(DataTable table)
        {
            TotalRows = table.Rows.Count;
            TotalSecurableObjects = table.Rows.Cast<DataRow>().Where(r => r["Url"].ToString().Trim().Length > 0).Count();
        }

        public IList<PermissionEntity> GetPermissionEntities(DataTable table)
        {
            IList<PermissionEntity> list = new List<PermissionEntity>();

            int r = 0;
            foreach (DataRow row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["Title"].ToString().Trim()))
                {
                    PermissionEntity tp = new PermissionEntity();
                    tp.Title = row["Title"].ToString();
                    tp.Type = row["Type"].ToString();
                    tp.Url = row["Url"].ToString();
                    tp.PermissionType = row["PermissionType"].ToString();

                    if (tp.PermissionType == "Unique")
                    {
                        AddRoles(tp, r, table);
                    }

                    list.Add(tp);
                }

                r++;
            }

            return list;
        }

        private void AddRoles(PermissionEntity tp, int rowIndex, DataTable table)
        {
            tp.Roles.Clear();

            for (int r = rowIndex + 1; r < table.Rows.Count; r++)
            {
                DataRow row = table.Rows[r];

                if (!string.IsNullOrEmpty(row["Title"].ToString().Trim()))
                    return;

                RoleEntity role = new RoleEntity();
                role.AssignmentName = row["RoleAssignments"].ToString();
                role.RoleType = row["RoleType"].ToString();
                role.Owner = row["Owner"].ToString();

                string rawUsersInGroup = row["UsersInGroup"].ToString();
                foreach (string s in rawUsersInGroup.Split(';'))
                    if (!string.IsNullOrEmpty(s.Trim()))
                        role.Users.Add(s.Trim());

                string rawPermissionLevels = row["PermissionLevels"].ToString();
                foreach (string s in rawPermissionLevels.Split(';'))
                    if (!string.IsNullOrEmpty(s.Trim()))
                        role.PermissionLevels.Add(s.Trim());

                if (!string.IsNullOrEmpty(role.AssignmentName))
                {
                    tp.Roles.Add(role);
                }
            }
        }

        public int MatchPermissions(IList<PermissionEntity> entityList, IList<SecurableObject> securableObjectList)
        {
            int count = 0;

            foreach (PermissionEntity entity in entityList)
                foreach (SecurableObject so in securableObjectList)
                    if (entity.Url == so.Url)
                    {
                        entity.Matches.Add(so);
                        count++;
                    }

            return count;
        }

        #region "Apply Permissions"

        public void ApplyPermissions(IList<PermissionEntity> permissionEntities)
        {
            foreach (PermissionEntity pentity in permissionEntities)
            {
                foreach (SecurableObject so in pentity.Matches)
                {
                    if (so.InternalObject is SPWeb)
                        ApplyPermissionForWeb(pentity, (so.InternalObject as SPWeb));

                    else if (so.InternalObject is SPList)
                        ApplyPermissionForList(pentity, (so.InternalObject as SPList));

                    else
                        ApplyPermissionForListItem(pentity, (so.InternalObject as SPListItem));
                }
            }
        }

        private void ApplyPermissionForListItem(PermissionEntity pentity, SPListItem item)
        {
            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPUtility.ValidateFormDigest();

                    using (SPSite elevatedSite = new SPSite(item.ParentList.ParentWeb.Site.ID))
                    {
                        using (SPWeb elevatedWeb = elevatedSite.OpenWeb(item.ParentList.ParentWeb.ID))
                        {
                            elevatedWeb.AllowUnsafeUpdates = true;

                            SPList elevatedList = elevatedWeb.Lists[item.ParentList.Title];
                            SPListItem elevatedListItem = elevatedList.GetItemById(item.ID);
                            if (pentity.PermissionType == "Inherit")
                            {
                                elevatedListItem.ResetRoleInheritance();
                            }

                            else if (pentity.PermissionType == "Unique")
                            {
                                elevatedListItem.BreakRoleInheritance(false);

                                ClearPermissions(elevatedListItem);

                                foreach (RoleEntity rentity in pentity.Roles)
                                {
                                    if (rentity.Type == RoleTypeEnum.SharePointGroup)
                                    {
                                        // Do not delete as parents may use it, DeleteGroup(list.ParentWeb, rentity.AssignmentName);
                                        CreateGroup(elevatedListItem.ParentList.ParentWeb, rentity.AssignmentName, rentity.Owner);
                                        AddUsersToGroup(elevatedListItem.ParentList.ParentWeb, rentity.AssignmentName, rentity.Users);

                                        AssignPermissionLevels(elevatedListItem, rentity.AssignmentName, rentity.PermissionLevels);
                                    }

                                    else if ((rentity.Type == RoleTypeEnum.DomainGroup)
                                        || (rentity.Type == RoleTypeEnum.User))
                                    {
                                        AssignPermissionLevelsToNonSharePointGroup(elevatedListItem, rentity.AssignmentName, rentity.PermissionLevels);
                                    }
                                }
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }
        }

        private void AssignPermissionLevels(SPListItem item, string name, IList<string> levels)
        {
            foreach (string level in levels)
            {
                if (level == "Limited Access")
                    continue;

                SPRoleAssignment roleAssignment = new SPRoleAssignment(item.ParentList.ParentWeb.SiteGroups[name]);
                roleAssignment.RoleDefinitionBindings.Add(item.ParentList.ParentWeb.RoleDefinitions[level]);
                item.RoleAssignments.Add(roleAssignment);
            }
        }

        private void ClearPermissions(SPListItem item)
        {
            int count = item.RoleAssignments.Count;

            for (int i = 0; i < count; i++)
                item.RoleAssignments.Remove(0);
        }

        private void ApplyPermissionForList(PermissionEntity pentity, SPList list)
        {
            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPUtility.ValidateFormDigest();

                    using (SPSite elevatedSite = new SPSite(list.ParentWeb.Site.ID))
                    {
                        using (SPWeb elevatedWeb = elevatedSite.OpenWeb(list.ParentWeb.ID))
                        {
                            elevatedWeb.AllowUnsafeUpdates = true;

                            SPList elevatedList = elevatedWeb.Lists[list.Title];

                            if (pentity.PermissionType == "Inherit")
                            {
                                elevatedList.ResetRoleInheritance();
                            }

                            else if (pentity.PermissionType == "Unique")
                            {
                                elevatedList.BreakRoleInheritance(false);

                                ClearPermissions(elevatedList);

                                foreach (RoleEntity rentity in pentity.Roles)
                                {
                                    if (rentity.Type == RoleTypeEnum.SharePointGroup)
                                    {
                                        CreateGroup(elevatedList.ParentWeb, rentity.AssignmentName, rentity.Owner);
                                        AddUsersToGroup(elevatedList.ParentWeb, rentity.AssignmentName, rentity.Users);

                                        AssignPermissionLevels(elevatedList, rentity.AssignmentName, rentity.PermissionLevels);
                                    }

                                    else if ((rentity.Type == RoleTypeEnum.DomainGroup)
                                        || (rentity.Type == RoleTypeEnum.User))
                                    {
                                        AssignPermissionLevelsToNonSharePointGroup(elevatedList, rentity.AssignmentName, rentity.PermissionLevels);
                                    }
                                }
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }
        }

        private PermissionUtility _permissionUtility = new PermissionUtility();

        private void ApplyPermissionForWeb(PermissionEntity pentity, SPWeb web)
        {
            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                    {
                        SPUtility.ValidateFormDigest();

                        using (SPSite elevatedSite = new SPSite(web.Site.ID))
                        {
                            using (SPWeb elevatedWeb = elevatedSite.OpenWeb(web.ID))
                            {
                                if (pentity.PermissionType == "Inherit")
                                {
                                    if (!elevatedWeb.IsRootWeb)
                                        elevatedWeb.ResetRoleInheritance();
                                }

                                else if (pentity.PermissionType == "Unique")
                                {
                                    if (!elevatedWeb.IsRootWeb)
                                        elevatedWeb.BreakRoleInheritance(false);

                                    ClearPermissions(elevatedWeb);
                                    DeleteAllGroupsAndUsers(elevatedWeb);

                                    foreach (RoleEntity rentity in pentity.Roles)
                                    {
                                        if (rentity.Type == RoleTypeEnum.SharePointGroup)
                                        {
                                            DeleteGroup(elevatedWeb, rentity.AssignmentName);
                                            CreateGroup(elevatedWeb, rentity.AssignmentName, rentity.Owner);
                                            AddUsersToGroup(elevatedWeb, rentity.AssignmentName, rentity.Users);

                                            AssignPermissionLevels(elevatedWeb, rentity.AssignmentName, rentity.PermissionLevels);
                                        }


                                        else if ((rentity.Type == RoleTypeEnum.DomainGroup)
                                            || (rentity.Type == RoleTypeEnum.User))
                                        {
                                            AssignPermissionLevelsToNonSharePointGroup(elevatedWeb, rentity.AssignmentName, rentity.PermissionLevels);
                                        }
                                    }
                                }
                            }
                        }
                    });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }
        }

        private void DeleteAllGroupsAndUsers(SPWeb web)
        {
            // Groups
            var groups = web.SiteGroups.Cast<SPGroup>().ToList();

            foreach (SPGroup group in groups)
                try
                {
                    web.SiteGroups.Remove(group.Name);
                }
                catch
                {
                }

            // Users
            var users = web.SiteUsers.Cast<SPUser>().ToList();

            foreach (SPUser user in users)
                try
                {
                    web.SiteUsers.Remove(user.Name);
                }
                catch
                {
                }
        }

        private void CreateGroup(SPWeb web, string name, string owner)
        {
            SPMember member = null;
            bool ownerIsDummy = false;

            try
            {
                member = web.EnsureUser(owner);
            }
            catch
            {
            }

            if (member == null)
            {
                ownerIsDummy = true;

                member = web.EnsureUser("SHAREPOINT\\system");
            }

            if (!web.SiteGroups.Cast<SPGroup>().Any(g => g.Name == name))
                web.SiteGroups.Add(name, member, null, string.Empty);

            if (ownerIsDummy)
            {
                SPGroup group = web.SiteGroups[name];

                if (web.SiteGroups.Cast<SPGroup>().Any(g => g.Name == owner))
                {
                    group.Owner = web.SiteGroups[owner];

                    group.Update();
                }
            }
        }

        private void DeleteGroup(SPWeb web, string name)
        {
            if (web.SiteGroups.Cast<SPGroup>().Any(g => g.Name == name))
                web.SiteGroups.Remove(name);
        }

        public void AddUsersToGroup(SPWeb web, string name, IList<string> users)
        {
            foreach (string user in users)
            {
                SPUser spuser = null;

                try
                {
                    spuser = web.EnsureUser(user);
                }
                catch
                {
                    Errors += "ERROR: During find user: " + user + Environment.NewLine;
                }

                if (!web.SiteGroups[name].Users.Cast<SPUser>().Any(u => u.LoginName == user))
                {
                    try
                    {
                        web.SiteGroups[name].AddUser(spuser);

                        web.Update();
                    }
                    catch
                    {
                        Errors += "ERROR: During add user: " + user + Environment.NewLine;
                    }
                }
            }
        }

        private void AssignPermissionLevels(SPWeb web, string name, IList<string> levels)
        {
            foreach (string level in levels)
            {
                if (level == "Limited Access")
                    continue;

                SPRoleAssignment roleAssignment = new SPRoleAssignment(web.SiteGroups[name]);
                roleAssignment.RoleDefinitionBindings.Add(web.RoleDefinitions[level]);
                web.RoleAssignments.Add(roleAssignment);
            }
        }

        private void AssignPermissionLevelsToNonSharePointGroup(SPWeb web, string name, IList<string> levels)
        {
            foreach (string level in levels)
            {
                if (level == "Limited Access")
                    continue;

                try
                {
                    SPUser user = web.EnsureUser(name);
                    SPRoleAssignment roleAssignment = new SPRoleAssignment(user);
                    roleAssignment.RoleDefinitionBindings.Add(web.RoleDefinitions[level]);
                    web.RoleAssignments.Add(roleAssignment);
                }
                catch
                {
                }
            }
        }

        private void AssignPermissionLevelsToNonSharePointGroup(SPList list, string name, IList<string> levels)
        {
            foreach (string level in levels)
            {
                if (level == "Limited Access")
                    continue;

                try
                {
                    SPUser user = list.ParentWeb.EnsureUser(name);
                    SPRoleAssignment roleAssignment = new SPRoleAssignment(user);
                    roleAssignment.RoleDefinitionBindings.Add(list.ParentWeb.RoleDefinitions[level]);
                    list.RoleAssignments.Add(roleAssignment);
                }
                catch
                {
                }
            }
        }

        private void AssignPermissionLevelsToNonSharePointGroup(SPListItem item, string name, IList<string> levels)
        {
            foreach (string level in levels)
            {
                if (level == "Limited Access")
                    continue;

                try
                {
                    SPUser user = item.ParentList.ParentWeb.EnsureUser(name);
                    SPRoleAssignment roleAssignment = new SPRoleAssignment(user);
                    roleAssignment.RoleDefinitionBindings.Add(item.ParentList.ParentWeb.RoleDefinitions[level]);
                    item.RoleAssignments.Add(roleAssignment);
                }
                catch
                {
                }
            }
        }

        private void AssignPermissionLevels(SPList list, string name, IList<string> levels)
        {
            foreach (string level in levels)
            {
                if (level == "Limited Access")
                    continue;

                SPRoleAssignment roleAssignment = new SPRoleAssignment(list.ParentWeb.SiteGroups[name]);
                roleAssignment.RoleDefinitionBindings.Add(list.ParentWeb.RoleDefinitions[level]);
                list.RoleAssignments.Add(roleAssignment);
            }
        }

        private void ClearPermissions(SPWeb web)
        {
            int count = web.RoleAssignments.Count;

            for (int i = 0; i < count; i++)
                web.RoleAssignments.Remove(0);
        }

        private void ClearPermissions(SPList list)
        {
            int count = list.RoleAssignments.Count;

            for (int i = 0; i < count; i++)
                list.RoleAssignments.Remove(0);
        }

        public string Errors { get; set; }

        #endregion
    }
}
