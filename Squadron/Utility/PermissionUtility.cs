using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using e = SquadronAddIns.Default.Utility.Entity;
using Microsoft.SharePoint;
using System.Diagnostics;
using Squadron;
using Microsoft.SharePoint.Utilities;
using Squadron.Components;

namespace SquadronAddIns.Default.Utility
{
    public class PermissionUtility
    {
        private SecurableObjectEnumerator _securableObjectEnumerator = new SecurableObjectEnumerator();

        public IList<e.Permission> GetPermissions(string searchLoginName, IList<SPSecurableObject> securableObjects)
        {
            IList<e.Permission> result = new List<e.Permission>();

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                foreach (SPSecurableObject so in securableObjects)
                {
                    if (so.HasUniqueRoleAssignments)
                    {
                        CheckAndAddUsers(result, so, searchLoginName, false, true, false);
                    }
                }
            });

            return result;
        }

        public IList<e.Permission> GetPermissions(string searchLoginName, string searchUrl, ScopeEnum scope, bool exactMatch, bool checkGroup, bool checkDisplayName)
        {
            IList<e.Permission> result = new List<e.Permission>();

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                var securableObjects = _securableObjectEnumerator.GetSecurableObjects(searchUrl, scope, true, true, true, true, false);
                foreach (SecurableObject so in securableObjects)
                {
                    if (so.InternalObject is SPWeb)
                    {
                        SPWeb web = (so.InternalObject as SPWeb);

                        if (web.HasUniqueRoleAssignments)
                        {
                            CheckAndAddUsers(result, web, searchLoginName, exactMatch, checkGroup, checkDisplayName);
                        }
                    }

                    else if (so.InternalObject is SPList)
                    {
                        SPList list = (so.InternalObject as SPList);

                        if (list.HasUniqueRoleAssignments)
                        {
                            CheckAndAddUsers(result, list, searchLoginName, exactMatch, checkGroup, checkDisplayName);
                        }
                    }

                    else if (so.InternalObject is SPListItem)
                    {
                        SPListItem item = (so.InternalObject as SPListItem);

                        if (item.HasUniqueRoleAssignments)
                        {
                            CheckAndAddUsers(result, item, searchLoginName, exactMatch, checkGroup, checkDisplayName);
                        }
                    }
                }
            });

            return result;
        }

        private void CheckAndAddUsers(IList<e.Permission> result, SPSecurableObject so, string searchLoginName, bool exactMatch, bool checkGroupNames, bool checkDisplayName)
        {
            foreach (SPRoleAssignment ra in so.RoleAssignments)
            {
                if (ra.Member is SPGroup)
                {
                    foreach (SPUser user in (ra.Member as SPGroup).Users)
                        CheckAndAddUser(result, so, user, ra.Member as SPGroup,  searchLoginName, exactMatch, checkDisplayName);

                    // Checking in group names (Find screen)
                    if (checkGroupNames)
                    {
                        if (IsMatch(searchLoginName, (ra.Member as SPGroup).LoginName, exactMatch))
                            result.Add(
                                new e.Permission()
                                {
                                    SecurableObject = so,
                                    PermissionLevels = GetPermissionLevels(so, (ra.Member as SPGroup), null),
                                    SharePointGroup = (ra.Member as SPGroup),
                                    DisplayName = (ra.Member as SPGroup).LoginName
                                });
                    }
                }

                else if (ra.Member is SPUser)
                {
                    CheckAndAddUser(result, so, ra.Member as SPUser, null, searchLoginName, exactMatch, checkDisplayName);
                }
            }
        }

        private void CheckAndAddUser(IList<e.Permission> result, SPSecurableObject so, SPUser user, SPGroup group, string searchLoginName, bool exactMatch, bool checkDisplayName)
        {
            bool found = false;

            if (IsMatch(searchLoginName, user.LoginName, exactMatch))
            {
                result.Add(
                    new e.Permission()
                    {
                        SecurableObject = so,
                        PermissionLevels = GetPermissionLevels(so, group, user),
                        SharePointGroup = group,
                        DisplayName = user.LoginName,
                        LoginName = user.LoginName
                    });

                found = true;
            }

            if (!found && checkDisplayName)
                if (IsMatch(searchLoginName, user.Name, exactMatch))
                {
                    result.Add(
                        new e.Permission()
                        {
                            SecurableObject = so,
                            PermissionLevels = GetPermissionLevels(so, group, user),
                            SharePointGroup = null,
                            DisplayName = user.Name,
                            LoginName = user.LoginName
                        });

                    found = true;
                }
        }

        private bool IsMatch(string searchName, string name, bool exactMatch)
        {
            if (exactMatch)
                return (name.ToLower() == searchName.ToLower());

            return (name.ToLower().Contains(searchName.ToLower()));
        }

        private void IfMatchAddGroup(SPGroupCollection groups, string loginName, bool exactMatch, SPSecurableObject securableObject, IList<e.Permission> result)
        {
            foreach (SPGroup group in groups)
                if (exactMatch && (group.LoginName.ToLower() == loginName.ToLower()))
                    result.Add(new e.Permission() { SecurableObject = securableObject, PermissionLevels = GetPermissionLevels(securableObject, group, null), SharePointGroup = null, DisplayName = group.LoginName });

                else if (group.LoginName.ToLower().Contains(loginName.ToLower()))
                    result.Add(new e.Permission() { SecurableObject = securableObject, PermissionLevels = GetPermissionLevels(securableObject, group, null), SharePointGroup = null, DisplayName = group.LoginName });
        }

        private void IfMatchAddUser(SPUserCollection userCollection, string loginName, bool exactMatch, bool checkDisplayName, SPSecurableObject securableObject, SPGroup group, IList<e.Permission> result)
        {
            foreach (SPUser user in userCollection)
            {
                bool found = false;

                if (!string.IsNullOrEmpty(user.LoginName))
                {
                    if (exactMatch && (user.LoginName.ToLower() == loginName.ToLower()))
                    {
                        result.Add(new e.Permission() { SecurableObject = securableObject, PermissionLevels = GetPermissionLevels(securableObject, group, user), SharePointGroup = group, LoginName = user.LoginName, DisplayName = user.Name });
                        found = true;
                    }

                    else if (user.LoginName.ToLower().Contains(loginName.ToLower()))
                    {
                        result.Add(new e.Permission() { SecurableObject = securableObject, PermissionLevels = GetPermissionLevels(securableObject, group, user), SharePointGroup = group, LoginName = user.LoginName, DisplayName = user.Name });
                        found = true;
                    }
                }

                if (!found)
                    if (checkDisplayName)
                        if (!string.IsNullOrEmpty(user.Name))
                        {
                            if (exactMatch && (user.Name.ToLower() == loginName.ToLower()))
                            {
                                result.Add(new e.Permission() { SecurableObject = securableObject, PermissionLevels = GetPermissionLevels(securableObject, group, user), SharePointGroup = group, LoginName = user.LoginName, DisplayName = user.Name });
                                found = true;
                            }

                            else if (user.Name.ToLower().Contains(loginName.ToLower()))
                            {
                                result.Add(new e.Permission() { SecurableObject = securableObject, PermissionLevels = GetPermissionLevels(securableObject, group, user), SharePointGroup = group, LoginName = user.LoginName, DisplayName = user.Name });
                                found = true;
                            }
                        }
            }
        }

        private string GetPermissionLevels(SPSecurableObject securableObject, SPGroup group, SPUser user)
        {
            string result = string.Empty;

            if (group != null)
            {
                foreach (SPRoleAssignment ra in securableObject.RoleAssignments)
                    if (ra.Member.LoginName == group.LoginName)
                        foreach (SPRoleDefinition rd in ra.RoleDefinitionBindings)
                            result += rd.Name + "; ";
            }
            else
            {
                foreach (SPRoleAssignment ra in securableObject.RoleAssignments)
                    if (ra.Member.LoginName == user.LoginName)
                        foreach (SPRoleDefinition rd in ra.RoleDefinitionBindings)
                            result += rd.Name + "; ";
            }

            if (result != string.Empty)
                result = result.Remove(result.Length - 2, 2).Trim();

            return result;
        }

        public bool SkippedPermissions;

        public void SetPermissions(string loginName, IList<e.Permission> permissions)
        {
            SkippedPermissions = false;

            foreach (e.Permission p in permissions)
            {
                if (p.SecurableObject is SPWeb)
                {
                    SetPermissionsForWeb(loginName, p, (p.SecurableObject as SPWeb));
                }

                else if (p.SecurableObject is SPList)
                {
                    SetPermissionsForList(loginName, p, (p.SecurableObject as SPList));
                }

                else if (p.SecurableObject is SPListItem)
                {
                    SetPermissionsForListItem(loginName, p, (p.SecurableObject as SPListItem));
                }

            }
        }

        private void SetPermissionsForWeb(string loginName, e.Permission p, SPWeb web)
        {
            using (SPSite esite = new SPSite(web.Site.ID))
            {
                using (SPWeb eweb = esite.OpenWeb(web.ID))
                {
                    eweb.AllowUnsafeUpdates = true;

                    SPUser user = eweb.EnsureUser(loginName);
                    if (p.SharePointGroup == null)
                    {
                        SPRoleAssignment ra = new SPRoleAssignment(user);

                        foreach (string level in p.PermissionLevels.Split(';'))
                            if (level == "Limited Access")
                                SkippedPermissions = true;
                            else
                                ra.RoleDefinitionBindings.Add(eweb.RoleDefinitions[level.Trim()]);

                        if (ra.RoleDefinitionBindings.Count > 0)
                            eweb.RoleAssignments.Add(ra);
                    }
                    else
                    {
                        eweb.Groups[p.SharePointGroup.Name].AddUser(user);
                    }

                    eweb.AllowUnsafeUpdates = false;
                    eweb.Update();
                }
            }
        }

        private void SetPermissionsForList(string loginName, e.Permission p, SPList list)
        {
            using (SPSite esite = new SPSite(list.ParentWeb.Site.ID))
            {
                using (SPWeb eweb = esite.OpenWeb(list.ParentWeb.ID))
                {
                    SPList elist = eweb.Lists[list.ID];

                    eweb.AllowUnsafeUpdates = true;
                    SPUser user = eweb.EnsureUser(loginName);

                    if (p.SharePointGroup == null)
                    {
                        SPRoleAssignment ra = new SPRoleAssignment(user);

                        foreach (string level in p.PermissionLevels.Split(';'))
                            if (level == "Limited Access")
                                SkippedPermissions = true;
                            else
                                ra.RoleDefinitionBindings.Add(eweb.RoleDefinitions[level.Trim()]);

                        if (ra.RoleDefinitionBindings.Count > 0)
                            elist.RoleAssignments.Add(ra);
                    }
                    else
                    {
                        eweb.Groups[p.SharePointGroup.Name].AddUser(user);
                    }

                    eweb.AllowUnsafeUpdates = false;
                    eweb.Update();
                }
            }
        }

        private void SetPermissionsForListItem(string loginName, e.Permission p, SPListItem listItem)
        {
            using (SPSite esite = new SPSite(listItem.ParentList.ParentWeb.Site.ID))
            {
                using (SPWeb eweb = esite.OpenWeb(listItem.ParentList.ParentWeb.ID))
                {
                    SPList elist = eweb.Lists[listItem.ParentList.ID];
                    SPListItem elistItem = elist.GetItemById(listItem.ID);

                    eweb.AllowUnsafeUpdates = true;
                    SPUser user = eweb.EnsureUser(loginName);

                    if (p.SharePointGroup == null)
                    {
                        SPRoleAssignment ra = new SPRoleAssignment(user);

                        foreach (string level in p.PermissionLevels.Split(';'))
                            if (level == "Limited Access")
                                SkippedPermissions = true;
                            else
                                ra.RoleDefinitionBindings.Add(eweb.RoleDefinitions[level.Trim()]);

                        if (ra.RoleDefinitionBindings.Count > 0)
                            elistItem.RoleAssignments.Add(ra);
                    }
                    else
                    {
                        eweb.Groups[p.SharePointGroup.Name].AddUser(user);
                    }

                    eweb.AllowUnsafeUpdates = false;
                    eweb.Update();
                }
            }
        }

        public bool ResetToInherit(SPSecurableObject so)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
               {
                   SPUtility.ValidateFormDigest();

                   try
                   {
                       if (so is SPWeb)
                       {
                           ResetWebInheritance(so as SPWeb, true);
                       }

                       else if (so is SPList)
                       {
                           ResetListInheritance(so as SPList, true);
                       }

                       else if (so is SPListItem)
                       {
                           ResetItemInheritance(so as SPListItem, true);
                       }
                   }
                   catch (Exception ex)
                   {
                       SquadronContext.HandleException(ex);
                   }
               });

            return true;
        }

        private void ResetItemInheritance(SPListItem listItem, bool makeInherit)
        {
            SPWeb elevatedWeb = null;
            SPList elevatedList = null;
            SPListItem elevatedListItem = null;

            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPUtility.ValidateFormDigest();

                    using (SPSite elevatedSite = new SPSite(listItem.ParentList.ParentWeb.Site.ID))
                    {
                        using (elevatedWeb = elevatedSite.OpenWeb(listItem.ParentList.ParentWeb.ID))
                        {
                            elevatedWeb.AllowUnsafeUpdates = true;

                            elevatedList = elevatedWeb.Lists[listItem.ParentList.Title];
                            elevatedListItem = elevatedList.GetItemById(listItem.ID);

                            if (makeInherit)
                                elevatedListItem.ResetRoleInheritance();
                            else
                                elevatedListItem.BreakRoleInheritance(false);

                            elevatedListItem.Update();

                            elevatedWeb.AllowUnsafeUpdates = false;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            finally
            {
                if (elevatedWeb != null)
                    elevatedWeb.Dispose();
            }
        }

        private void ResetWebInheritance(SPWeb web, bool makeInherit)
        {
            SPWeb elevatedWeb = null;

            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPUtility.ValidateFormDigest();

                    using (SPSite elevatedSite = new SPSite(web.Site.ID))
                    {
                        using (elevatedWeb = elevatedSite.OpenWeb(web.ID))
                        {
                            elevatedWeb.AllowUnsafeUpdates = true;

                            if (makeInherit)
                                elevatedWeb.ResetRoleInheritance();
                            else
                                elevatedWeb.BreakRoleInheritance(false);

                            elevatedWeb.Update();

                            elevatedWeb.AllowUnsafeUpdates = false;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            finally
            {
                if (elevatedWeb != null)
                    elevatedWeb.Dispose();
            }
        }

        private void ResetListInheritance(SPList list, bool makeInherit)
        {
            SPWeb elevatedWeb = null;
            SPList elevatedList = null;

            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPUtility.ValidateFormDigest();

                    using (SPSite elevatedSite = new SPSite(list.ParentWeb.Site.ID))
                    {
                        using (elevatedWeb = elevatedSite.OpenWeb(list.ParentWeb.ID))
                        {
                            elevatedWeb.AllowUnsafeUpdates = true;

                            elevatedList = elevatedWeb.Lists[list.Title];

                            if (makeInherit)
                                elevatedList.ResetRoleInheritance();
                            else
                                elevatedList.BreakRoleInheritance(false);

                            elevatedList.Update();

                            elevatedWeb.AllowUnsafeUpdates = false;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            finally
            {
                if (elevatedWeb != null)
                    elevatedWeb.Dispose();
            }
        }

        private SPWeb GetNewWeb(SPWeb web)
        {
            SPSite site = new SPSite(web.Site.Url);
            foreach (SPWeb w in site.AllWebs)
                if (w.Url == web.Url)
                    return w;

            return null;
        }

        private IList<SPWeb> _webs = new List<SPWeb>();

        private void SafeUpdate(SPWeb web)
        {
            try
            {
                _webs.Add(web);
                web.Update();
            }
            catch
            {
                // No handling
            }
        }

        public bool BreakInheritance(SPSecurableObject so)
        {
            try
            {
                if (so is SPWeb)
                {
                    SafeUpdate(so as SPWeb);

                    (so as SPWeb).AllowUnsafeUpdates = true;

                    so.BreakRoleInheritance(true);

                    SafeUpdate(so as SPWeb);
                }

                else if (so is SPList)
                {
                    ResetListInheritance(so as SPList, false);
                }

                else if (so is SPListItem)
                {
                    SafeUpdate((so as SPListItem).ParentList.ParentWeb);

                    (so as SPListItem).ParentList.ParentWeb.AllowUnsafeUpdates = true;
                    so.BreakRoleInheritance(true);
                }
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            return true;
        }
    }
}
