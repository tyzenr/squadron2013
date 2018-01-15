using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Forms;

namespace Squadron.Export
{
    public class ExcelExport
    {
        internal class ColumnCaption
        {
            private static string[] Alphabets = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            private static ColumnCaption instance = null;
            private List<string> cellHeaders = null;
            public static ColumnCaption Instance
            {
                get
                {
                    if (instance == null)
                        return new ColumnCaption();
                    else return ColumnCaption.Instance;
                }
            }

            public ColumnCaption()
            {
                this.InitCollection();
            }

            private void InitCollection()
            {
                cellHeaders = new List<string>();

                foreach (string sItem in Alphabets)
                    cellHeaders.Add(sItem);

                foreach (string item in Alphabets)
                    foreach (string sItem in Alphabets)
                        cellHeaders.Add(item + sItem);
            }

            /// <summary>
            /// Returns the column caption for the given row & column index.
            /// </summary>
            /// <param name="rowIndex">Index of the row.</param>
            /// <param name="columnIndex">Index of the column.</param>
            /// <returns></returns>
            internal string Get(int rowIndex, int columnIndex)
            {
                return this.cellHeaders.ElementAt(columnIndex) + (rowIndex + 1).ToString();
            }
        }

        public string ExportToExcel(DataTable table, string file)
        {
            using (SpreadsheetDocument excelDoc = SpreadsheetDocument.Create(file, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
            {
                CreateExcelParts(excelDoc, table);
            }

            return file;
        }

        public string ExportToExcel(DataTable table)
        {
            string excelfile = string.Empty;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.xlsx|*.xlsx";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                excelfile = dialog.FileName;
                return ExportToExcel(table, excelfile);
            }

            return excelfile;
        }

        private void CreateExcelParts(SpreadsheetDocument spreadsheetDoc, DataTable data)
        {
            WorkbookPart workbookPart = spreadsheetDoc.AddWorkbookPart();
            CreateWorkbookPart(workbookPart);

            int workBookPartCount = 1;

            WorkbookStylesPart workbookStylesPart = workbookPart.AddNewPart<WorkbookStylesPart>("rId" + (workBookPartCount++).ToString());
            CreateWorkbookStylesPart(workbookStylesPart);

            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>("rId" + (101).ToString());
            CreateWorksheetPart(workbookPart.WorksheetParts.ElementAt(0), data);

            SharedStringTablePart sharedStringTablePart = workbookPart.AddNewPart<SharedStringTablePart>("rId" + (workBookPartCount++).ToString());
            CreateSharedStringTablePart(sharedStringTablePart, data);

            workbookPart.Workbook.Save();
        }

        /// <summary>
        /// Creates the shared string table part.
        /// </summary>
        /// <param name="sharedStringTablePart">The shared string table part.</param>
        /// <param name="sheetData">The sheet data.</param>
        private void CreateSharedStringTablePart(SharedStringTablePart sharedStringTablePart, DataTable sheetData)
        {
            UInt32Value stringCount = Convert.ToUInt32(sheetData.Rows.Count) + Convert.ToUInt32(sheetData.Columns.Count);

            SharedStringTable sharedStringTable = new SharedStringTable()
            {
                Count = stringCount,
                UniqueCount = stringCount
            };

            for (int ci = 0; ci < sheetData.Columns.Count; ci++)
            {
                SharedStringItem stringItem = new SharedStringItem();
                Text text = new Text();
                text.Text = sheetData.Columns[ci].ColumnName;
                stringItem.Append(text);
                sharedStringTable.Append(stringItem);
            }

            for (int rowIndex = 0; rowIndex < sheetData.Rows.Count; rowIndex++)
            {
                SharedStringItem sharedStringItem = new SharedStringItem();
                Text text = new Text();
                text.Text = sheetData.Rows[rowIndex][0].ToString();
                sharedStringItem.Append(text);
                sharedStringTable.Append(sharedStringItem);
            }

            sharedStringTablePart.SharedStringTable = sharedStringTable;
        }

        /// <summary>
        /// Creates the worksheet part.
        /// </summary>
        /// <param name="worksheetPart">The worksheet part.</param>
        /// <param name="data">The data.</param>
        private void CreateWorksheetPart(WorksheetPart worksheetPart, DataTable data)
        {
            Worksheet worksheet = new Worksheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
            worksheet.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");


            SheetViews sheetViews = new SheetViews();
            SheetView sheetView = new SheetView() { WorkbookViewId = (UInt32Value)0U };
            Selection selection = new Selection() { ActiveCell = "A1" };
            sheetView.Append(selection);
            sheetViews.Append(sheetView);

            PageMargins pageMargins = new PageMargins()
            {
                Left = 0.7D,
                Right = 0.7D,
                Top = 0.75D,
                Bottom = 0.75D,
                Header = 0.3D,
                Footer = 0.3D
            };

            SheetFormatProperties sheetFormatPr = new SheetFormatProperties()
            {
                DefaultRowHeight = 15D,
                DyDescent = 0.25D
            };

            SheetData sheetData = new SheetData();

            UInt32Value rowIndex = 1U;

            Row row1 = new Row()
            {
                RowIndex = rowIndex++,
                Spans = new ListValue<StringValue>() { InnerText = "1:3" },
                DyDescent = 0.25D
            };

            for (int columnIndex = 0; columnIndex < data.Columns.Count; columnIndex++)
            {
                Cell cell = new Cell() { CellReference = ColumnCaption.Instance.Get((Convert.ToInt32((UInt32)rowIndex) - 2), columnIndex), DataType = CellValues.String };
                CellValue cellValue = new CellValue();
                cellValue.Text = data.Columns[columnIndex].ColumnName.ToString().FormatCode();
                cell.Append(cellValue);

                row1.Append(cell);
            }
            sheetData.Append(row1);

            for (int rIndex = 0; rIndex < data.Rows.Count; rIndex++)
            {
                Row row = new Row()
                {
                    RowIndex = rowIndex++,
                    Spans = new ListValue<StringValue>() { InnerText = "1:3" },
                    DyDescent = 0.25D
                };

                for (int cIndex = 0; cIndex < data.Columns.Count; cIndex++)
                {
                    if (cIndex == 0)
                    {
                        Cell cell = new Cell() { CellReference = ColumnCaption.Instance.Get((Convert.ToInt32((UInt32)rowIndex) - 2), cIndex), DataType = CellValues.String };
                        CellValue cellValue = new CellValue();
                        cellValue.Text = data.Rows[rIndex][cIndex].ToString();
                        cell.Append(cellValue);

                        row.Append(cell);
                    }
                    else
                    {
                        Cell cell = new Cell() { CellReference = ColumnCaption.Instance.Get((Convert.ToInt32((UInt32)rowIndex) - 2), cIndex), DataType = CellValues.String };
                        CellValue cellValue = new CellValue();
                        cellValue.Text = data.Rows[rIndex][cIndex].ToString();
                        cell.Append(cellValue);

                        row.Append(cell);
                    }
                }
                sheetData.Append(row);
            }

            worksheet.Append(sheetViews);
            worksheet.Append(sheetFormatPr);
            worksheet.Append(sheetData);
            worksheet.Append(pageMargins);
            worksheetPart.Worksheet = worksheet;
        }

        /// <summary>
        /// Creates the workbook styles part.
        /// </summary>
        /// <param name="workbookStylesPart">The workbook styles part.</param>
        private void CreateWorkbookStylesPart(WorkbookStylesPart workbookStylesPart)
        {
            Stylesheet stylesheet = new Stylesheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
            stylesheet.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            stylesheet.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");

            StylesheetExtensionList stylesheetExtensionList = new StylesheetExtensionList();
            StylesheetExtension stylesheetExtension = new StylesheetExtension() { Uri = "{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}" };
            stylesheetExtension.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            DocumentFormat.OpenXml.Office2010.Excel.SlicerStyles slicerStyles = new DocumentFormat.OpenXml.Office2010.Excel.SlicerStyles() { DefaultSlicerStyle = "SlicerStyleLight1" };
            stylesheetExtension.Append(slicerStyles);
            stylesheetExtensionList.Append(stylesheetExtension);

            stylesheet.Append(stylesheetExtensionList);

            workbookStylesPart.Stylesheet = stylesheet;
        }

        /// <summary>
        /// Creates the workbook part.
        /// </summary>
        /// <param name="workbookPart">The workbook part.</param>
        private void CreateWorkbookPart(WorkbookPart workbookPart)
        {
            Workbook workbook = new Workbook();
            Sheets sheets = new Sheets();

            Sheet sheet = new Sheet()
            {
                Name = "Book" + 1,
                SheetId = Convert.ToUInt32(101),
                Id = "rId" + (101).ToString()
            };
            sheets.Append(sheet);

            CalculationProperties calculationProperties = new CalculationProperties()
            {
                CalculationId = (UInt32Value)123456U  // some default Int32Value
            };

            workbook.Append(sheets);
            workbook.Append(calculationProperties);

            workbookPart.Workbook = workbook;
        }

        public DataTable GetDataTable(string xlsxFilePath)
        {
            string value;
            DataTable dt = new DataTable();
            using (SpreadsheetDocument myWorkbook = SpreadsheetDocument.Open(xlsxFilePath, true))
            {
                //Access the main Workbook part, which contains dataWorkbookPart 
                WorkbookPart workbookPart = myWorkbook.WorkbookPart;

                WorksheetPart worksheetPart = null;
                {
                    Sheet ss = workbookPart.Workbook.Descendants<Sheet>().FirstOrDefault();
                    worksheetPart = workbookPart.WorksheetParts.FirstOrDefault();
                    SharedStringTablePart stringTablePart = workbookPart.SharedStringTablePart;

                    if (worksheetPart != null)
                    {
                        Row lastRow = worksheetPart.Worksheet.Descendants<Row>().LastOrDefault();

                        Row firstRow = worksheetPart.Worksheet.Descendants<Row>().FirstOrDefault();
                        if (firstRow != null)
                        {

                            foreach (Cell c in firstRow.ChildElements)
                            {
                                value = GetValue(c, stringTablePart); dt.Columns.Add(value);
                            }
                        }

                        if (lastRow != null)
                        {
                            for (int i = 2; i <= lastRow.RowIndex; i++)
                            {
                                DataRow dr = dt.NewRow();
                                bool empty = true;
                                Row row = worksheetPart.Worksheet.Descendants<Row>().Where(r => i == r.RowIndex).FirstOrDefault();
                                int j = 0;
                                if (row != null)
                                {
                                    foreach (Cell c in row.ChildElements)
                                    {
                                        //Get cell value
                                        value = GetValue(c, stringTablePart);
                                        if (value != null && value != string.Empty && value != "")
                                        {
                                            empty = false;
                                        }

                                        // Special Condition for Empty Cell conversion
                                        if (value == ".")
                                            value = string.Empty;

                                        dr[j] = value;
                                        j++;
                                        if (j == dt.Columns.Count)
                                        {
                                            break;
                                        }
                                    }
                                    if (empty)
                                    {
                                        break;
                                    }
                                    dt.Rows.Add(dr);
                                }
                            }
                        }
                    }
                }

                myWorkbook.Close();
            }

            return dt;
        }

        public string GetValue(Cell cell, SharedStringTablePart stringTablePart)
        {
            if (cell.ChildElements.Count == 0)
            {
                return null;
            }

            //get cell value
            string value = cell.ElementAt(0).InnerText;//CellValue.InnerText;
            //Look up real value from shared string table
            if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))
            {
                value = stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            return value;
        }
    }

    public static class Extensions
    {
        public static string FormatCode(this string sourceString)
        {
            if (sourceString.Contains("<"))
                sourceString = sourceString.Replace("<", "&lt;");

            if (sourceString.Contains(">"))
                sourceString = sourceString.Replace(">", "&gt;");

            return sourceString;
        }
    }
}
