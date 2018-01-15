using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data;

namespace Squadron.Export
{
    public class CSVExport
    {
        public void ExportToCSV(Control control, IList<string> selectedColumns, bool launch)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.csv|*.csv";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                    File.Delete(dialog.FileName);

                if (control is ListBox)
                {
                    WriteListBoxToCSV(dialog.FileName, control as ListBox);
                }

                else if (control is DataGridView)
                {
                    WriteGridToCSV(dialog.FileName, control as DataGridView, selectedColumns);
                }

                if (launch)
                {
                    try
                    {
                        Process.Start(dialog.FileName);
                    }
                    catch
                    { }
                }
            }
        }

        private void WriteGridToCSV(string filename, DataGridView grid, IList<string> selectedColumns)
        {
            int count = 0;

            WriteHeaderToFile(filename, grid, selectedColumns);

            for (int r = 0; r < grid.Rows.Count; r++)
            {
                string line = string.Empty;
                for (int c = 0; c < grid.Columns.Count; c++)
                {
                    if ((selectedColumns == null) || selectedColumns.Contains(grid.Columns[c].Name))
                    {
                        if (grid[c, r].Value != null)
                            line += grid[c, r].Value.ToString();

                        line += ",";
                    }
                }

                if (line.Length > 0)
                    line = line.Substring(0, line.Length - 1);

                WriteTextToFile(filename, line);

                count++;
            }
        }

        private void WriteListBoxToCSV(string filename, ListBox lbx)
        {
            foreach (object o in lbx.Items)
            {
                WriteTextToFile(filename, o.ToString());
            }
        }


        private void WriteHeaderToFile(string filename, DataGridView grid, IList<string> selectedColumns)
        {
            if (selectedColumns == null)
            {
                selectedColumns = new List<string>();
                foreach (DataGridViewColumn column in grid.Columns)
                    selectedColumns.Add(column.Name);
            }

            string line = string.Empty;
            foreach (string c in selectedColumns)
            {
                if (grid.DataSource is DataTable)
                    line += (grid.DataSource as DataTable).Columns[c].ColumnName + ",";
                else
                    line += grid.Columns[c].Name + ",";
            }

            if (line.Length > 0)
                line = line.Substring(0, line.Length - 1);

            WriteTextToFile(filename, line);
        }

        private static void WriteTextToFile(string filename, string line)
        {
            StreamWriter writer = File.AppendText(filename);
            writer.WriteLine(line);
            writer.Dispose();
        }

        public void ImportFromCSV(Control control)
        {
            if (control is DataGridView)
            {
                DataGridView grid = (control as DataGridView);

                DataTable table = GetDataTableFromCSVFile();
                if (table != null)
                    grid.DataSource = table;
            }

            else if (control is ListBox)
            {
            }
        }

        public DataTable GetDataTableFromCSVFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.csv|*.csv";

            DataTable table = null;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(dialog.FileName);

                if (lines.Count() > 0)
                {
                    table = new DataTable();

                    foreach (string c in lines[0].Split(','))
                        table.Columns.Add(c, typeof(string));

                    for (int i = 1; i < lines.Count(); i++)
                    {
                        DataRow row = table.NewRow();
                        int ix = 0;
                        foreach (string c in lines[i].Split(','))
                        {
                            if (ix >= table.Columns.Count)
                            {
                                table.Columns.Add("New Column " + Guid.NewGuid().ToString(), typeof(string));
                                SquadronContext.WriteMessage("Invalid column generated! (data value contains ',')");
                            }

                            row[ix] = c;

                            ix++;
                        }

                        table.Rows.Add(row);
                    }
                }
            }

            return table;
        }

    }
}
