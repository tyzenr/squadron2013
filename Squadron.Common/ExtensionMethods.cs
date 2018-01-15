using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Utilities;

namespace Squadron.Common
{
    public static class ExtensionMethods
    {
        public static string ToSPString(this object value)
        {
            return GetDisplayName(value);
        }

        public static string ToStringEx(this bool value)
        {
            return Helper.Instance.FormatBool(value);
        }

        public static long ToMB(this long value)
        {
            double dvalue = value;

            long result = (long)((dvalue / 1024) / 1024);

            return result;
        }

        public static long ToGB(this long value)
        {
            double dvalue = value;

            long result = (long)((dvalue / 1024) / 1024) / 1024;

            return result;
        }

        #region "Internal purpose methods"

        public static string GetDisplayName(object o)
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

            else if (o is SPGroup)
                return "[Group]" + " " + (o as SPGroup).Name;
            
            else if (o is SPUser)
                return "[User]" + " " + (o as SPUser).Name;

            else
                return o.ToString();
        }

        private static string GetDisplayName(object o, bool includeUrl)
        {
            if (o != null)
            {
                return GetDisplayName(o) + " " + GetUrl(o);
            }

            return "Unknown";
        }

        public static string GetUrl(object o)
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

        #endregion
    }
}
