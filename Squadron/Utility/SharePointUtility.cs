using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Squadron;
using SquadronAddIns.Default.Utility.Entity;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Utilities;
using System.Collections.ObjectModel;

namespace SquadronAddIns.Default.Utility
{
    public class SharePointUtility
    {
        public Collection<SPWebApplication> GetAllWebApplications()
        {
            Collection<SPWebApplication> result = new Collection<SPWebApplication>();

            SPServiceCollection services = SPFarm.Local.Services;

            foreach (SPService s in services)
            {
                if (s is SPWebService)
                {
                    SPWebService webService = (SPWebService)s;

                    foreach (SPWebApplication webApp in webService.WebApplications)
                    {
                        result.Add(webApp);
                    }
                }
            }

            return result;
        }

        public IList<object> GetSharePointObjects(string url)
        {
            IList<object> result = GetSharePointObjects(url, true, true, true, true, true, string.Empty);

            return result;
        }

        public IList<object> GetSharePointObjects(
            string url,
            bool webapp,
            bool sitecollection,
            bool website,
            bool listNLibrary,
            bool itemNdocument,
            string siteCollectionFilterUrl
            )
        {
            IList<object> result = new List<object>();

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPWebApplication webApplication = SPWebApplication.Lookup(new Uri(url));

                if (webApplication != null)
                {
                    if (webapp)
                        result.Add(webApplication);

                    if (sitecollection || website || listNLibrary || itemNdocument)
                        foreach (SPSite site in webApplication.Sites)
                        {
                            if (!IsFilterValid(site.Url, siteCollectionFilterUrl))
                                continue;

                            if (sitecollection)
                                result.Add(site);

                            if (website || listNLibrary || itemNdocument)
                                foreach (SPWeb web in site.AllWebs)
                                {
                                    try
                                    {
                                        if (website)
                                            result.Add(web);

                                        if (listNLibrary || itemNdocument)
                                            foreach (SPList list in web.Lists)
                                            {
                                                try
                                                {
                                                    if (list.Hidden)
                                                        continue;

                                                    if (listNLibrary)
                                                        result.Add(list);

                                                    if (itemNdocument)
                                                        foreach (SPListItem item in list.Items)
                                                        {
                                                            if (itemNdocument)
                                                                result.Add(item);
                                                        }
                                                }
                                                catch (Exception ex)
                                                {
                                                    SquadronContext.HandleException(list, ex);
                                                }
                                            }
                                    }
                                    catch (Exception ex)
                                    {
                                        SquadronContext.HandleException(web, ex);
                                    }
                                }
                        }
                }
            });

            return result;
        }

        private bool IsFilterValid(string url, string filterUrl)
        {
            if (!string.IsNullOrEmpty(filterUrl))
                if (!url.ToLower().StartsWith(filterUrl.ToLower()))
                    return false;

            return true;
        }

        public string GetDisplayNameOnly(object o)
        {
            if (o is SPWebApplication)
                return (o as SPWebApplication).DisplayName;

            else if (o is SPSite)
                return (o as SPSite).RootWeb.Title;

            else if (o is SPWeb)
                return (o as SPWeb).Title;

            else if (o is SPDocumentLibrary)
                return (o as SPDocumentLibrary).Title;

            else if (o is SPList)
                return (o as SPList).Title;

            else if (o is SPListItem)
            {
                if ((o as SPListItem).Folder == null)
                    return (o as SPListItem).DisplayName;
                else
                    return (o as SPListItem).DisplayName;
            }

            return "Unknown";
        }

        public string GetSharePointType(object o)
        {
            if (o is SPWebApplication)
                return "Web Application";

            else if (o is SPSite)
                return "Site Collection";

            else if (o is SPWeb)
                return "Site";

            else if (o is SPDocumentLibrary)
                return "Library";

            else if (o is SPList)
                return "List";

            else if (o is SPListItem)
            {
                if ((o as SPListItem).Folder == null)
                    if ((o as SPListItem).ParentList is SPDocumentLibrary)
                        return "Document";
                    else
                        return "Item";
                else
                    return "Folder";
            }

            return "Unknown";
        }

        public string GetDisplayName(object o)
        {
            if (o is SPWebApplication)
                return "[Web Application]" + " " + (o as SPWebApplication).DisplayName;

            else if (o is SPSite)
                return "[Site Collection]" + " " + (o as SPSite).RootWeb.Title;

            else if (o is SPWeb)
                return "[Site]" + " " + (o as SPWeb).Title;

            else if (o is SPDocumentLibrary)
                return "[Library]" + " " + (o as SPDocumentLibrary).Title;

            else if (o is SPList)
                return "[List]" + " " + (o as SPList).Title;

            else if (o is SPListItem)
            {
                if ((o as SPListItem).Folder == null)
                    return "[Item]" + " " + (o as SPListItem).DisplayName;
                else
                    return "[Folder]" + " " + (o as SPListItem).DisplayName;
            }

            return "Unknown";
        }

        public string GetSimpleDisplayName(object o)
        {
            if (o is SPWebApplication)
                return (o as SPWebApplication).DisplayName;

            else if (o is SPSite)
                return (o as SPSite).RootWeb.Title;

            else if (o is SPWeb)
                return (o as SPWeb).Title;

            else if (o is SPDocumentLibrary)
                return (o as SPDocumentLibrary).Title;

            else if (o is SPList)
                return (o as SPList).Title;

            else if (o is SPListItem)
            {
                if ((o as SPListItem).Folder == null)
                    return (o as SPListItem).DisplayName;
                else
                    return (o as SPListItem).DisplayName;
            }

            return "Unknown";
        }

        public string GetDisplayName(object o, bool includeUrl)
        {
            string result = "Unknown";
            
            if (o != null)
            {
                result = GetDisplayName(o);

                if (includeUrl)
                    result += " " + GetUrl(o);
            }

            return result;
        }

        public bool IsInternalUser(Microsoft.SharePoint.SPUser user)
        {
            string loginName = user.LoginName.ToUpper();

            bool result = (loginName == "NT AUTHORITY\\LOCAL SERVICE") ||
                (loginName == "NT AUTHORITY\\SYSTEM") ||
                (loginName == "SHAREPOINT\\SYSTEM");

            return result;
        }

        public void RemoveUserFromWeb(SPWeb web, SPUser user)
        {
            bool old = web.AllowUnsafeUpdates;
            web.AllowUnsafeUpdates = true;
            web.Update();

            try
            {
                web.Users.Remove(user.LoginName);
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            foreach (SPGroup g in web.SiteGroups)
            {
                try
                {
                    g.RemoveUser(user);
                }
                catch (Exception ex)
                {
                    SquadronContext.HandleException(g, ex);
                }
            }

            web.AllowUnsafeUpdates = old;
            web.Update();
        }

        private IList<SharePointObject> _objectsList;

        public IList<SharePointObject> GetAllObjectsUnder(object parentObject)
        {
            _objectsList = new List<SharePointObject>();

            InternalGetAllObjectsUnder(parentObject);

            return _objectsList;
        }

        private void InternalGetAllObjectsUnder(object parentObject)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                if (parentObject is SPWebApplication)
                    foreach (SPSite site in (parentObject as SPWebApplication).Sites)
                    {
                        _objectsList.Add(new SharePointObject() { InternalObject = site });
                        InternalGetAllObjectsUnder(site);
                    }

                if (parentObject is SPSite)
                    foreach (SPWeb web in (parentObject as SPSite).AllWebs)
                    {
                        _objectsList.Add(new SharePointObject() { InternalObject = web });
                        InternalGetAllObjectsUnder(web);
                    }

                if (parentObject is SPWeb)
                    foreach (SPList list in (parentObject as SPWeb).Lists)
                    {
                        _objectsList.Add(new SharePointObject() { InternalObject = list });
                        InternalGetAllObjectsUnder(list);
                    }

                if (parentObject is SPList)
                    foreach (SPListItem item in (parentObject as SPList).Items)
                    {
                        _objectsList.Add(new SharePointObject() { InternalObject = item });
                        InternalGetAllObjectsUnder(item);
                    }
            });
        }

        public string GetUrl(object o)
        {
            string result = string.Empty;

            if (o is SPWebApplication)
                result = (o as SPWebApplication).OfficialFileUrl.ToString();

            else if (o is SPSite)
                result = (o as SPSite).Url;

            else if (o is SPWeb)
                result = (o as SPWeb).Url;

            else if (o is SPDocumentLibrary)
                result = SPUtility.GetFullUrl((o as SPDocumentLibrary).ParentWeb.Site, (o as SPDocumentLibrary).DefaultViewUrl);

            else if (o is SPList)
                result = SPUtility.GetFullUrl((o as SPList).ParentWeb.Site, (o as SPList).DefaultViewUrl);

            else if (o is SPListItem)
                result = (o as SPListItem)[SPBuiltInFieldId.EncodedAbsUrl].ToString();

            else
                throw new ApplicationException("Invalid type!");

            return result;
        }

        private IList<object> _internalList;

        public IList<object> RefreshSharePointObjects(IList<object> objects)
        {
            SquadronHelper.Instance.StartAnimation();

            IList<object> result = new List<object>();
            _internalList = new List<object>();

            try
            {
                foreach (object o in objects)
                {
                    try
                    {
                        if (o is SPWebApplication)
                            result.Add(GetNewWebApplication(o as SPWebApplication));

                        else if (o is SPSite)
                            result.Add(GetNewSite(o as SPSite));

                        else if (o is SPWeb)
                            result.Add(GetNewWeb(o as SPWeb));

                        else if (o is SPList)
                            result.Add(GetNewList(o as SPList));

                        else if (o is SPListItem)
                            result.Add(GetNewListItem(o as SPListItem));

                        else
                            throw new ApplicationException("Invalid type!");
                    }
                    catch (Exception ex)
                    {
                        SquadronContext.HandleException(o, ex);
                    }
                }
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }

            return result;
        }

        private object GetNewListItem(SPListItem item)
        {
            object result = _internalList.OfType<SPListItem>().FirstOrDefault(w => w.ID == item.ID);

            if (result == null)
            {
                result = (GetNewList(item.ParentList) as SPList).GetItemById(item.ID);
                _internalList.Add(result);
            }

            return result;
        }

        private object GetNewList(SPList list)
        {
            object result = _internalList.OfType<SPList>().FirstOrDefault(w => w.ID == list.ID);

            if (result == null)
            {
                result = (GetNewWeb(list.ParentWeb) as SPWeb).Lists[list.ID];
                _internalList.Add(result);
            }

            return result;
        }

        private object GetNewWeb(SPWeb web)
        {
            object result = _internalList.OfType<SPSite>().FirstOrDefault(w => w.ID == web.ID);

            if (result == null)
            {
                result = (GetNewSite(web.Site) as SPSite).AllWebs[web.ID];
                _internalList.Add(result);
            }

            return result;
        }

        private object GetNewSite(SPSite site)
        {
            object result = _internalList.OfType<SPSite>().FirstOrDefault(w => w.Url == site.Url);

            if (result == null)
            {
                result = new SPSite(site.Url);
                _internalList.Add(result);
            }

            return result;
        }

        private object GetNewWebApplication(SPWebApplication webapp)
        {
            object result = _internalList.OfType<SPWebApplication>().FirstOrDefault(w => w.OfficialFileUrl == webapp.OfficialFileUrl);

            if (result == null)
            {
                result = SPWebApplication.Lookup(new Uri(SquadronContext.Url));
                _internalList.Add(result);
            }

            return result;
        }

        public DateTime GetLastModifiedDate(object o)
        {
            if (o is SPSite)
                return (o as SPSite).LastContentModifiedDate;

            else if (o is SPWeb)
                return (o as SPWeb).LastItemModifiedDate;

            else if (o is SPList)
                return (o as SPList).LastItemModifiedDate;

            return DateTime.MinValue;
        }

        private IList<SPWeb> _result = new List<SPWeb>();

        public IList<SPWeb> GetWebsRecursively(SPWeb web)
        {
            _result.Clear();
            InternalGetWebsRecursively(web);

            return _result;
        }

        private void InternalGetWebsRecursively(SPWeb web)
        {
            foreach (SPWeb w in web.Webs)
                _result.Add(w);

            foreach (SPWeb w in web.Webs)
                InternalGetWebsRecursively(w);
        }
    }
}
