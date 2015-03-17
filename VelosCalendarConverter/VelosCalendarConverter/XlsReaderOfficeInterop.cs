using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Interop.Excel; 

namespace VelosCalendarConverter
{
    /// <summary>
    /// Xls reader using Microsoft.Office.Interop.Excel to read the file, need to check requirements for using the librairie in prod
    /// </summary>
    class XlsReaderOfficeInterop
    {
        public static string filename;
        public System.Data.DataTable data = new System.Data.DataTable();

        Application excel = null;
        Workbook workbook = null;

        public XlsReaderOfficeInterop(string file)
        {
            filename = file;
        }

        public void openXls()
        {
            //see : http://www.c-sharpcorner.com/UploadFile/17e8f6/reading-merged-cell-from-excel-using-microsoft-office-inter
            excel = new Application();
            workbook = excel.Workbooks.Open(filename);
            int workSheetCounts = workbook.Worksheets.Count;

            Worksheet workSheet = workbook.Sheets[1];
            int totalColumns = workSheet.UsedRange.Cells.Columns.Count + 1;

            for (int col = 1; col < totalColumns; col++)
            { 
                data.Columns.Add();            
            }

            Range objRange = null;
            for (int row = 2; row < workSheet.UsedRange.Cells.Rows.Count; row++)
            {
                System.Data.DataRow dr = data.NewRow();
                for (int col = 1; col < totalColumns; col++)
                {
                    objRange = workSheet.Cells[row, col];
                    
                    if (objRange.MergeCells)
                    {
                        dr[col - 1] = Convert.ToString(((Range)objRange.MergeArea[1, 1]).Text).Trim();
                    }
                    else
                    {
                        dr[col - 1] = Convert.ToString(objRange.Text).Trim();
                    }
                }
                data.Rows.Add(dr);
            }  
        }

        public string printDT()
        {
            string ret = "";
            foreach (DataRow dataRow in data.Rows)
            {
                ret += "\r\n";
                foreach (var item in dataRow.ItemArray)
                {
                    ret += " ::: " + item;
                }
            }
            return ret;
        }

    }
}
