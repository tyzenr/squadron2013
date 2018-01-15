using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Squadron;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Utilities;
using Squadron.Components;

namespace SquadronAddIns.Default.Utility
{
    public class SecurableObjectEnumerator
    {
        public HashSet<SPPrincipal> GetPrincipals(string url)
        {
            HashSet<SPPrincipal> result = new HashSet<SPPrincipal>();

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(url));

                foreach (SPSite site in webApplication.Sites)
                    foreach (SPWeb web in site.AllWebs)
                        foreach (SPUser user in web.AllUsers)
                            if (!result.Any(p => p.LoginName == user.LoginName))
                                result.Add(user);
            });

            return result;
        }

        public HashSet<SPPrincipal> GetPrincipals(string url, ScopeEnum scope)
        {
            if (scope == ScopeEnum.None)
                throw new ApplicationException("Invalid Scope!");

            HashSet<SPPrincipal> result = new HashSet<SPPrincipal>();

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                if (scope == ScopeEnum.WebApplication)
                {
                    SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(url));

                    foreach (SPSite site in webApplication.Sites)
                        foreach (SPWeb web in site.AllWebs)
                            foreach (SPUser user in web.AllUsers)
                                if (!result.Any(p => p.LoginName == user.LoginName))
                                    result.Add(user);
                }

                else if (scope == ScopeEnum.SiteCollection)
                {
                    using (SPSite site = new SPSite(url))
                    {
                        foreach (SPWeb web in site.AllWebs)
                            foreach (SPUser user in web.AllUsers)
                                if (!result.Any(p => p.LoginName == user.LoginName))
                                    result.Add(user);
                    }
                }

                else if (scope == ScopeEnum.Site)
                {
                    using (SPSite site = new SPSite(url))
                    {
                        foreach (SPWeb web in site.AllWebs)
                            if (Helper.Instance.AreUrlsEqual(web.Url, url))
                                foreach (SPUser user in web.AllUsers)
                                    if (!result.Any(p => p.LoginName == user.LoginName))
                                        result.Add(user);
                    }
                }
            });

            return result;
        }

        private IList<SecurableObject> _securableObjects;

        public IList<SecurableObject> GetSecurableObjects(object o, bool includeSite, bool includeListAndLibrary, bool includeFolder, bool includeItem, bool includeInherited)
        {
            ScopeEnum scope = ScopeEnum.None;
            string url = string.Empty;

            if (o is SPWebApplication)
            {
                scope = ScopeEnum.WebApplication;
                url = SquadronContext.Url;
            }

            else if (o is SPSite)
            {
                scope = ScopeEnum.SiteCollection;
                url = (o as SPSite).Url;
            }

            else if (o is SPWeb)
            {
                scope = ScopeEnum.Site;
                url = (o as SPWeb).Url;
            }

            else
                throw new ApplicationException("Invalid Object in GetSecurableObjects!");

            return GetSecurableObjects(url, scope, includeSite, includeListAndLibrary, includeFolder, includeItem, includeInherited);
        }

        public IList<SecurableObject> GetSecurableObjects(string url, ScopeEnum scope, bool includeSite, bool includeListAndLibrary, bool includeFolder, bool includeItem, bool includeInherited)
        {
            _securableObjects = new List<SecurableObject>();

            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    if (scope == ScopeEnum.WebApplication)
                    {
                        SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(url));

                        foreach (SPSite site in webApplication.Sites)
                        {
                            // Site
                            if (includeSite)
                                GetWebSites(site, includeInherited, null);

                            // List
                            if (includeListAndLibrary)
                                GetLists(site, includeInherited);

                            // Folder
                            if (includeFolder)
                                GetFolders(site, includeInherited);

                            // List Item
                            if (includeItem)
                                GetListItems(site, includeInherited);
                        }
                    }

                    else if (scope == ScopeEnum.SiteCollection)
                    {
                        using (SPSite site = new SPSite(url))
                        {
                            // Site
                            if (includeSite)
                                GetWebSites(site, includeInherited, null);

                            // List
                            if (includeListAndLibrary)
                                GetLists(site, includeInherited);

                            // Folder
                            if (includeFolder)
                                GetFolders(site, includeInherited);

                            // List Item
                            if (includeItem)
                                GetListItems(site, includeInherited);
                        }
                    }

                    else if (scope == ScopeEnum.Site)
                    {
                        using (SPSite site = new SPSite(url))
                        {
                            foreach (SPWeb web in site.AllWebs)
                                if (Helper.Instance.AreUrlsEqual(web.Url, url))
                                {
                                    // Site
                                    if (includeSite)
                                        GetWebSites(site, includeInherited, web);

                                    // List
                                    if (includeListAndLibrary)
                                        GetLists(site, includeInherited);

                                    // Folder
                                    if (includeFolder)
                                        GetFolders(site, includeInherited);

                                    // List Item
                                    if (includeItem)
                                        GetListItems(site, includeInherited);
                                }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            return _securableObjects;
        }

        private void GetFolders(SPSite site, bool includeInherited)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                foreach (SPWeb web in site.AllWebs)
                    foreach (SPList list in web.Lists)
                        foreach (SPListItem item in list.Folders)
                        {
                            if (!item.HasUniqueRoleAssignments)
                                if (!includeInherited)
                                    continue;

                            SecurableObject so = new SecurableObject();
                            so.Title = item.DisplayName;
                            so.Url = item["EncodedAbsUrl"].ToString();
                            so.Type = "Folder";
                            so.InternalObject = item;

                            _securableObjects.Add(so);
                        }
            });
        }

        private void GetListItems(SPSite site, bool includeInherited)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    foreach (SPWeb web in site.AllWebs)
                        foreach (SPList list in web.Lists)
                            foreach (SPListItem item in list.Items)
                            {
                                if (!item.HasUniqueRoleAssignments)
                                    if (!includeInherited)
                                        continue;

                                SecurableObject so = new SecurableObject();
                                so.Title = item.DisplayName;
                                so.Url = item["EncodedAbsUrl"].ToString();
                                so.Type = "Item";
                                so.InternalObject = item;

                                _securableObjects.Add(so);
                            }
                });
        }

        private void GetLists(SPSite site, bool includeInherited)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    foreach (SPWeb web in site.AllWebs)
                        foreach (SPList list in web.Lists)
                        {
                            if (!list.HasUniqueRoleAssignments)
                                if (!includeInherited)
                                    continue;

                            SecurableObject so = new SecurableObject();
                            so.Title = list.Title;
                            so.Url = SPUtility.GetFullUrl(list.ParentWeb.Site, list.DefaultViewUrl);
                            so.InternalObject = list;
                            so.Type = "List";

                            if (list is SPDocumentLibrary)
                                so.Type = "Library";

                            _securableObjects.Add(so);
                        }
                });
        }

        private void GetWebSites(SPSite site, bool includeInherited, SPWeb filterWeb)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    foreach (SPWeb web in site.AllWebs)
                    {
                        if (!web.HasUniqueRoleAssignments)
                            if (!includeInherited)
                                continue;

                        if (filterWeb != null)
                            if (!Helper.Instance.AreUrlsEqual(filterWeb.Url, web.Url))
                                continue;

                        SecurableObject so = new SecurableObject();
                        so.Title = web.Title;
                        so.Url = web.Url;
                        so.Type = "Site";
                        so.InternalObject = web;

                        _securableObjects.Add(so);
                    }
                });
        }
    }

    public class SecurableObject
    {
        public string Title
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public object InternalObject;

        public string ToShortString()
        {
            return this.Type + ": " + this.Title;
        }

        public override string ToString()
        {
            return this.Title + " " + this.Type + " " + this.Url;
        }
    }
}
