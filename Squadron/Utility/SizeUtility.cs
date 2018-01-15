using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Utility.Entity;
using System.Collections;
using System.Data;

namespace SquadronAddIns.Default.Utility
{
    public class SizeUtility
    {
        private SharePointUtility _utility = new SharePointUtility();

        public IList<SizeEntity> GetSize(IEnumerable objects)
        {
            IList<SizeEntity> result = new List<SizeEntity>();

            foreach (object o in objects)
            {
                SizeEntity entity = new SizeEntity();
                entity.Title = _utility.GetDisplayNameOnly(o);
                entity.Type = _utility.GetSharePointType(o);
                entity.Url = _utility.GetUrl(o);
                entity.SizeLong = GetSizeOf(o);
                entity.ModifiedDate = _utility.GetLastModifiedDate(o);
                entity.InternalObject = o;

                result.Add(entity);
            }

            return result;
        }

        private HashSet<CacheEntity> _cache = new HashSet<CacheEntity>();

        public void ClearCache()
        {
            _cache.Clear();
        }

        public long GetSizeOf(object o)
        {
            long result = 0;

            if (o is SPSite)
            {
                result = (o as SPSite).Usage.Storage;
            }

            else if (o is SPWeb)
            {
                result = GetWebSize(o as SPWeb);
            }

            else if (o is SPList)
            {
                result = GetListSize(o as SPList);
            }

            else if (o is SPListItem)
            {
                if ((o as SPListItem).File != null)
                    result = (o as SPListItem).File.Length;
            }

            return result;
        }

        private long GetListSize(SPList list)
        {
            if (_cache.Any(c => c.ListGUID == list.ID.ToString().ToLower()))
            {
                return GetListSizeFromCache(list);
            }

            AddToCache(list.ParentWeb.Site);

            return GetListSizeFromCache(list);
        }

        private long GetListSizeFromCache(SPList list)
        {
            long result = (long)_cache.Where(c => c.ListGUID.ToLower() == list.ID.ToString().ToLower()).Sum(c => c.Size);

            return result;
        }

        private long GetWebSize(SPWeb web)
        {
            if (_cache.Any(c => c.WebGUID == web.ID.ToString().ToLower()))
            {
                return GetWebSizeFromCache(web);
            }

            AddToCache(web.Site);

            return GetWebSizeFromCache(web);
        }

        private void AddToCache(SPSite site)
        {
            // Library
            foreach (DataRow row in site.StorageManagementInformation(SPSite.StorageManagementInformationType.DocumentLibrary, SPSite.StorageManagementSortOrder.Increasing, SPSite.StorageManagementSortedOn.Size, 10000).Rows)
                _cache.Add(new CacheEntity()
                {
                    ListGUID = GetGUID(row["ListGUID"]),
                    WebGUID = GetGUID(row["WebGUID"]),
                    Size = Lng(row["Size"].ToString())
                }
                );

            // List
            foreach (DataRow row in site.StorageManagementInformation(SPSite.StorageManagementInformationType.List, SPSite.StorageManagementSortOrder.Increasing, SPSite.StorageManagementSortedOn.Size, 10000).Rows)
                _cache.Add(new CacheEntity()
                {
                    ListGUID = GetGUID(row["ListGUID"]),
                    WebGUID = GetGUID(row["WebGUID"]),
                    Size = Lng(row["Size"].ToString())
                }
                );
        }

        private string GetGUID(object guid)
        {
            return guid.ToString().ToLower().Replace("{", string.Empty).Replace("}", string.Empty);
        }

        private long GetWebSizeFromCache(SPWeb web)
        {
            long originalSize = (long)_cache.Where(c => c.WebGUID.ToLower() == web.ID.ToString().ToLower()).Sum(c => c.Size);
            long recycleSize = web.RecycleBin.Cast<SPRecycleBinItem>().Sum(r => r.Size); ;

            long result = originalSize + recycleSize;

            return result;
        }

        public long Lng(string text)
        {
            try
            {
                return long.Parse(text);
            }
            catch
            {
            }

            return 0;
        }

        class CacheEntity
        {
            public string WebGUID;

            public string ListGUID;

            public long Size;
        }
        
        private long GetSPWebSize(SPWeb web)
        {
            long result = GetSPFolderSize(web.RootFolder) + web.RecycleBin.Cast<SPRecycleBinItem>().Sum(r => r.Size);

            return result;
        }

        public long GetSPFolderSize(SPFolder folder)
        {
            long result = 0;

            foreach (SPFile file in folder.Files)
                result += file.TotalLength
                    + file.Versions.Cast<SPFileVersion>().Sum(f => f.Size);

            result += folder.SubFolders.Cast<SPFolder>().Sum(sf => GetSPFolderSize(sf));

            return result;
        }
    }
}
