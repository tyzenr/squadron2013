using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using SquadronAddIns.Default.Documentation;
using SquadronAddIns.Default.Farm;
using SquadronAddIns.Default.Explorer;
using SquadronAddIns.Default.SizeInfo;
using SquadronAddins.Default.EmptyList;
using SquadronAddins.Default.VersionCleaner;
using SquadronAddIns.Default.Solutions;
using SquadronAddins.Default.MySiteInfo;
using SquadronAddIns.Default.SharePointSKU;
using SquadronAddins.Default.Stsadm;
using SquadronAddins.Default.UserProfileInfo;
using SquadronAddins.Default.WFTerminator;
using SquadronAddIns.Default.Permission;
using SquadronAddIns.Default.PermissionGroupsAD;
using Squadron.Addins.SqlServer.CopyTables;
using SquadronAddIns.Default.QuickTest;
using SquadronAddIns.Default.Diagnostics;

namespace Squadron.Core
{
    public class AddinManager
    {
        public IEnumerable<SquadronAddin> Addins
        {
            get
            {
                if (_Addins.Count == 0)
                    LoadAddins();

                return _Addins.OrderBy(a => a.Order).ThenBy(a => a.Group).ThenBy(a => a.GroupOrder);
            }
        }

        public List<SquadronAddin> _Addins = new List<SquadronAddin>();

        internal void LoadAddins()
        {
            _Addins.Add(new DocumentationAddin());
            _Addins.Add(new FarmAddIn());
            _Addins.Add(new ExplorerAddIn());
            //_Addins.Add(new SizeAddin());
            _Addins.Add(new ClearListAddin());
            _Addins.Add(new VersionCleanerAddin());
            _Addins.Add(new SolutionsAddin());

            //_Addins.Add(new MySiteInfoAddin());
            //_Addins.Add(new SharePointSKUAddin());
            _Addins.Add(new StsAdmAddin());
            _Addins.Add(new UserProfileAddin());
            _Addins.Add(new WFTerminatorAddin());
            _Addins.Add(new PermissionsAddin());

            _Addins.Add(new ActiveDirectoryAddin());
            _Addins.Add(new CopyTablesAddin());
            _Addins.Add(new QuickTestAddin());
            _Addins.Add(new DiagnosticsAddin());
        }

        //internal void LoadAddins()
        //{
        //    try
        //    {
        //        _Addins.Clear();

        //        foreach (string file in Directory.GetFiles(GetExecutionFolder(), "Squadron*.dll"))
        //        {
        //            Assembly assembly = Assembly.LoadFile(file);
        //            foreach (Type type in assembly.GetExportedTypes())
        //            {
        //                if (typeof(SquadronAddin).IsAssignableFrom(type))
        //                {
        //                    object instance = Activator.CreateInstance(type);

        //                    SquadronAddin Addin = instance as SquadronAddin;

        //                    if (Addin.IsEnabled)
        //                        if (IsAddable(Addin))
        //                        {
        //                            if (!_Addins.Any(a => (a.Name == Addin.Name) && (a.Group == Addin.Group)))
        //                                _Addins.Add(Addin);
        //                        }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        SquadronContext.HandleException(ex);
        //    }
        //}

        private bool IsAddable(SquadronAddin addin)
        {
            if (Constants.IsReducedVersion)
                if (!new string[] { "Explorer", "Permissions", "Active Directory", "Diagnostics" }.Contains(addin.Name))
                    return false;

            return true;
        }

        public static string GetExecutionFolder()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        public void InvokeOnChange()
        {
            foreach (SquadronAddin addin in Addins)
                try
                {
                    addin.OnChange();
                }
                catch (Exception ex)
                {
                    SquadronContext.HandleException(ex);
                }
        }
    }
}
