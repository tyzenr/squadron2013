using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;
using Squadron;
using System.IO;
using System.Threading;
using FileLockInfo;

namespace SquadronAddins.Infra
{
    public partial class SystemControl : UserControl
    {
        public SystemControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            RefreshProcesses();
            RefreshServices();
        }

        private void RefreshServices()
        {
            IList<ServiceEntity> list = new List<ServiceEntity>();
            foreach (ServiceController s in ServiceController.GetServices())
            {
                try
                {
                    list.Add(new ServiceEntity() { Name = s.DisplayName, Status = s.Status.ToString(), InternalObject = s });
                }
                catch { }
            }

            grids.DataSource = list;
        }

        private void RefreshProcesses()
        {
            IList<ProcessEntity> list = new List<ProcessEntity>();
            foreach (Process p in Process.GetProcesses())
            {
                try
                {
                    list.Add(new ProcessEntity() { Name = p.MainModule.ModuleName, ProcessID = p.Id, FileName = p.MainModule.FileName, InternalObject = p });
                }
                catch { }
            }

            gridp.DataSource = list;
        }

        private void RefreshProcessesButton_Click(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        private void RefreshServicesButton_Click(object sender, EventArgs e)
        {
            RefreshServices();
        }

        private void gridp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pgrid.SelectedObject = (gridp.SelectedRows[0].DataBoundItem as ProcessEntity).InternalObject;
            }
            catch
            {
            }
        }

        private void grids_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pgrid.SelectedObject = (grids.SelectedRows[0].DataBoundItem as ServiceEntity).InternalObject;
            }
            catch
            {
            }
        }

        private void FileLockButton_Click(object sender, EventArgs e)
        {
            if (InputsValid())
                FindFileLock();
        }

        private FileUtility _fileUtility = new FileUtility();

        private void FindFileLock()
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                var processes = _fileUtility.GetProcessesLockingFile(FileText.Text);

                if (processes.Count > 0)
                    SquadronContext.Info(string.Format("Process '{0}' is using the file." + Environment.NewLine + processes.First().MainModule.FileName, processes.First().ProcessName));
                else
                    SquadronContext.Info("No process is currently using the file.");
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private bool InputsValid()
        {
            if (!File.Exists(FileText.Text))
            {
                SquadronContext.Warn("File do not exists!");
                return false;
            }

            return true;
        }
    }

    [Browsable(false)]
    public class ProcessEntity
    {
        public string Name
        {
            get;
            set;
        }

        public int ProcessID
        {
            get;
            set;
        }

        public string FileName
        {
            get;
            set;
        }

        [Browsable(false)]
        public object InternalObject
        {
            get;
            set;
        }
    }

    public class ServiceEntity
    {
        public string Name
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }

        [Browsable(false)]
        public object InternalObject
        {
            get;
            set;
        }
    }
}
