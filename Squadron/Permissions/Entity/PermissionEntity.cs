using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquadronAddIns.Default.Utility;

namespace SquadronAddIns.Default.Permissions.Entity
{
    public class PermissionEntity
    {
        public string Title
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public string PermissionType
        {
            get;
            set;
        }

        public IList<RoleEntity> Roles = new List<RoleEntity>();

        public IList<SecurableObject> Matches = new List<SecurableObject>();
    }

    public class RoleEntity
    {
        public string AssignmentName
        {
            get;
            set;
        }

        public string RoleType
        {
            get;
            set;
        }

        public string Owner
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public RoleTypeEnum Type
        {
            get
            {
                if (RoleType == "User")
                    return RoleTypeEnum.User;

                else if (RoleType == "System Account")
                    return RoleTypeEnum.SystemAccount;

                else if (RoleType == "Domain Group")
                    return RoleTypeEnum.DomainGroup;

                else if (RoleType == "SharePoint Group")
                    return RoleTypeEnum.SharePointGroup;

                else if (RoleType == string.Empty)
                    return RoleTypeEnum.None;

                throw new ApplicationException("Invalid Role Type: " + this.RoleType);
            }
        }

        public IList<string> Users = new List<string>();

        public IList<string> PermissionLevels = new List<string>();
    }

    public enum RoleTypeEnum
    {
        None,
        SystemAccount,
        DomainGroup,
        User,
        SharePointGroup
    }
}
