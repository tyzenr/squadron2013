using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using System.Data.SqlClient;
using Squadron.Core;

namespace Squadron.Addins.SqlServer.CopyTables
{
    public partial class CopyTablesControl : UserControl
    {
        public CopyTablesControl()
        {
            InitializeComponent();
        }

        private SqlConnection _connection1, _connection2;

        private void SourceButton_Click(object sender, EventArgs e)
        {
            _connection1 = null;

            DataConnectionDialog dialog = new DataConnectionDialog();
            DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
            dcs.LoadConfiguration(dialog);

            if (DataConnectionDialog.Show(dialog) == DialogResult.OK)
            {
                _connection1 = new SqlConnection(dialog.ConnectionString);
                _connection1.Open();

                RefreshTables(_connection1, lst1);

                toolTip1.SetToolTip(SourceButton, _connection1.ConnectionString);
            }
        }

        private void RefreshTables(SqlConnection cn, ListBox lbx)
        {
            DataTable table = cn.GetSchema("Tables");

            lbx.Items.Clear();
            foreach (DataRow row in table.Rows)
                lbx.Items.Add(row["TABLE_NAME"]);
        }

        private void DestButton_Click(object sender, EventArgs e)
        {
            _connection2 = null;

            DataConnectionDialog dialog = new DataConnectionDialog();
            DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
            dcs.LoadConfiguration(dialog);

            if (DataConnectionDialog.Show(dialog) == DialogResult.OK)
            {
                _connection2 = new SqlConnection(dialog.ConnectionString);
                _connection2.Open();

                toolTip1.SetToolTip(DestButton, _connection2.ConnectionString);
                RefreshTables(_connection2, lst2);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (InputsValid())
                StartCopying();
        }

        private void StartCopying()
        {
            pbr.Maximum = lst1.CheckedItems.Count;
            pbr.Value = 0;

            foreach (string table in lst1.CheckedItems)
            {
                if (!DoTableExists(table))
                    CreateTable(table);

                SetIdentityInsertOn(table);
                Copy(table);

                pbr.Value++;
            }

            SquadronContext.WriteMessage("Operation completed");
        }

        private void SetIdentityInsertOn(string table)
        {
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT " + table + " ON", _connection1);
            cmd.ExecuteNonQuery();
        }

        private bool DoTableExists(string table)
        {
            return true;
        }

        private void CreateTable(string table)
        {

        }

        private void Copy(string table)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table, _connection1);
            SqlDataReader rdr = cmd.ExecuteReader();

            SqlBulkCopy sbc = new SqlBulkCopy(_connection2);
            sbc.DestinationTableName = table;
            sbc.WriteToServer(rdr);

            sbc.Close();
            rdr.Close();
        }

        private bool InputsValid()
        {
            if ((_connection1 == null) || (_connection2 == null) || (_connection1.State != ConnectionState.Open) || (_connection2.State != ConnectionState.Open))
            {
                SquadronContext.Info("Please ensure source/destination connections!");
                return false;
            }

            if (lst1.CheckedIndices.Count == 0)
            {
                SquadronContext.Info("Please select atleast one source table!");
                return false;
            }

            foreach (string table in lst1.CheckedItems)
            {
                bool found = false;
                foreach (DataRow row in _connection2.GetSchema("Tables").Rows)
                    if (row["TABLE_NAME"].ToString() == table)
                    {
                        found = true;
                        break;
                    }

                if (!found)
                {
                    SquadronContext.Info(string.Format("Table {0} do not exists in destination server.  Copy cannot continue!", table));
                    return false;
                }
            }

            return true;
        }
    }
}
