using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices.AccountManagement;
using System.Net;
using System.DirectoryServices;
using Squadron;
using System.Security.Principal;
using SquadronAddIns.Default.Utility.Entity;

namespace SquadronAddIns.Default.Utility
{
    public class ActiveDirectoryUtility
    {
        const long ADS_UF_SCRIPT = 0x0001;                          // The logon script will be executed
        const long ADS_UF_ACCOUNTDISABLE = 0x0002;                  // Disable user account
        const long ADS_UF_HOMEDIR_REQUIRED = 0x0008;                // Requires a root directory
        const long ADS_UF_LOCKOUT = 0x0010;                         // Account is locked out
        const long ADS_UF_PASSWD_NOTREQD = 0x0020;                  // No password is required
        const long ADS_UF_PASSWD_CANT_CHANGE = 0x0040;              // The user cannot change the password
        const long ADS_UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED = 0x0080; // Encrypted password allowed
        const long ADS_UF_TEMP_DUPLICATE_ACCOUNT = 0x0100;          // Local user account
        const long ADS_UF_NORMAL_ACCOUNT = 0x0200;                  // Typical user account

        public bool IsUser(string domain, string samAccountName)
        {
            samAccountName = Helper.Instance.GetStringAfter(samAccountName, "\\");
            bool result = false;

            if (_isADUserCache.Contains(samAccountName))
                return true;

            PrincipalContext context = null;

            try
            {
                if (string.IsNullOrEmpty(domain))
                    context = new PrincipalContext(ContextType.Domain);
                else
                    context = new PrincipalContext(ContextType.Domain, domain);

                UserPrincipal qbeUser = new UserPrincipal(context);
                qbeUser.SamAccountName = samAccountName;

                PrincipalSearcher searcher = new PrincipalSearcher(qbeUser);

                result = searcher.FindOne() != null;

                if (result)
                    _isADUserCache.Add(samAccountName);
            }
            catch
            {
            }

            return result;
        }

        public bool IsGroup(string domain, string samAccountName)
        {
            samAccountName = Helper.Instance.GetStringAfter(samAccountName, "\\");
            bool result = false;

            if (_isADGroupCache.Contains(samAccountName))
                return true;

            PrincipalContext context = null;

            try
            {
                if (string.IsNullOrEmpty(domain))
                    context = new PrincipalContext(ContextType.Domain);
                else
                    context = new PrincipalContext(ContextType.Domain, domain);

                GroupPrincipal qbeUser = new GroupPrincipal(context);
                qbeUser.SamAccountName = samAccountName;

                PrincipalSearcher searcher = new PrincipalSearcher(qbeUser);

                result = searcher.FindOne() != null;

                if (result)
                    _isADGroupCache.Add(samAccountName);
            }
            catch
            {
            }

            return result;
        }

        public IEnumerable<ADEntity> GetActiveUsers(string domain)
        {
            var result = GetAll(domain, false, true, false).Where(u => u.IsEnabled);

            return result;
        }

        public HashSet<ADEntity> GetAll(string domain, bool groups, bool users, bool showStatusForUser)
        {
            HashSet<ADEntity> list = new HashSet<ADEntity>();

            try
            {
                PrincipalContext context = null;

                if (string.IsNullOrEmpty(domain))
                    context = new PrincipalContext(ContextType.Domain);

                else
                    context = new PrincipalContext(ContextType.Domain, domain);

                // Security Groups
                if (groups)
                {
                    GroupPrincipal group = new GroupPrincipal(context);
                    PrincipalSearcher searcher = new PrincipalSearcher(group);

                    foreach (GroupPrincipal principal in searcher.FindAll())
                        list.Add(new ADEntity()
                        {
                            Name = principal.Name,
                            Description = principal.Description,
                            LoginName = principal.SamAccountName,
                            InternalObject = principal,
                            Type = GetGroupType(principal),
                            IsEnabled = IsEnabled(principal.GetUnderlyingObject() as DirectoryEntry)
                        });
                }

                // Users
                if (users)
                {
                    UserPrincipal userp = new UserPrincipal(context);
                    PrincipalSearcher searcher = new PrincipalSearcher(userp);

                    foreach (UserPrincipal principal in searcher.FindAll())
                        list.Add(new ADEntity()
                        {
                            Name = principal.Name, // + GetStatus(showStatusForUser, principal),
                            Description = principal.Description,
                            LoginName = principal.SamAccountName,
                            InternalObject = principal,
                            Type = "User",
                            IsEnabled = IsEnabled(principal.GetUnderlyingObject() as DirectoryEntry),
                        });
                }
            }
            catch (Exception ex)
            {
                SquadronContext.HandleException(ex);
            }

            return list;
        }

        private string GetStatus(bool showStatusForUser, UserPrincipal principal)
        {
            if (showStatusForUser)
            {
                if (!IsEnabled(principal.GetUnderlyingObject() as DirectoryEntry))
                    return " " + Constants.Status_Disabled;
            }

            return string.Empty;
        }

        private string GetGroupType(GroupPrincipal principal)
        {
            if (principal.IsSecurityGroup.HasValue)
                if (principal.IsSecurityGroup.Value)
                    return "Security Group";

            return "Distribution Group";
        }

        public IList<Principal> GetGroupMembers(string domainName, string groupName)
        {
            PrincipalContext context = null;
            if (string.IsNullOrEmpty(domainName))
                context = new PrincipalContext(ContextType.Domain);
            else
                context = new PrincipalContext(ContextType.Domain, domainName);

            GroupPrincipal group = GroupPrincipal.FindByIdentity(context, IdentityType.Name, groupName);

            IList<Principal> members = new List<Principal>();

            if (group == null)
                return members;

            members = group.GetMembers(true).ToList();

            return members;
        }

        public string GetFullyQualifiedDomainName()
        {
            string result = "";

            string domainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            string hostName = Dns.GetHostName();

            if (!hostName.Contains(domainName))
                result = hostName + "." + domainName;
            else
                result = hostName;

            return result;
        }

        public string GetDomainName()
        {
            string result = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;

            if (result.Contains("."))
                result = result.Substring(0, result.IndexOf("."));

            result = result.ToUpper();

            return result;
        }

        private bool IsEnabled(DirectoryEntry de)
        {
            if (de.NativeGuid == null)
                return false;

            int flags = 0;
            if (de.Properties["userAccountControl"] != null)
                if (de.Properties["userAccountControl"].Value != null)
                    flags = (int)de.Properties["userAccountControl"].Value;

            if (!Convert.ToBoolean(flags & ADS_UF_ACCOUNTDISABLE))
                return true;

            return false;
        }

        private bool IsLocked(DirectoryEntry de)
        {
            if (de.NativeGuid == null)
                return false;

            int flags = (int)de.Properties["userAccountControl"].Value;

            if (!Convert.ToBoolean(flags & ADS_UF_LOCKOUT))
                return true;

            return false;
        }

        private HashSet<string> _isADUserCache = new HashSet<string>();
        private HashSet<string> _isADGroupCache = new HashSet<string>();

        public void ClearCache()
        {
            _isADUserCache.Clear();
            _isADGroupCache.Clear();
        }

        public bool IsWindowsUser(string samAccountName)
        {
            bool result = false;
            samAccountName = Helper.Instance.GetStringAfter(samAccountName, "\\");

            if (_isADUserCache.Contains(samAccountName))
                return true;

            PrincipalContext context = null;

            try
            {
                context = new PrincipalContext(ContextType.Machine);
                result = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, samAccountName) != null;
            }
            catch
            {
            }

            return result;
        }

        public bool IsExists(string domain, string samAccountName)
        {
            bool result = IsUser(domain, samAccountName) ||
                IsGroup(domain, samAccountName);

            return result;
        }

        public IEnumerable<ADEntity> GetDeadAccounts()
        {
            IList<ADEntity> result = new List<ADEntity>();

            foreach (ADEntity entity in GetAll(SquadronContext.DomainName, true, true, false))
                if (!IsEnabled((entity.InternalObject as Principal).GetUnderlyingObject() as DirectoryEntry))
                    result.Add(entity);

            return result;
        }
    }
}
