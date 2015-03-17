using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace VelosCalendarConverter
{
    /// <summary>
    /// Xls reader using ADO.Net OLEDB to read the file
    /// </summary>
    class XlsReaderAdo
    {
        public static string filename;
        public DataTable data;

        public XlsReaderAdo(string file)
        {
            filename = file;
        }

        public void openXls()
        {
            ///SEE http://www.aspsnippets.com/Articles/Read-and-Import-Excel-Sheet-using-ADO.Net-and-C.aspx
            string connectionString = "";
            if (filename[filename.Length-1].Equals('x'))
                connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties=Excel 12.0;", filename);
            else
                connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", filename);

            OleDbConnection connExcel = new OleDbConnection(connectionString);
            OleDbCommand cmdExcel = new OleDbCommand();
            cmdExcel.Connection = connExcel;

            connExcel.Open();
            DataTable dtExcelSchema;
            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            connExcel.Close();

            DataSet ds = new DataSet();
            string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
            string commandText = "SELECT * From [" + sheetName + "]";
            var adapter = new OleDbDataAdapter(commandText, connExcel);
            connExcel.Open();
            adapter.Fill(ds);
            connExcel.Close();
            //var adapter = new OleDbDataAdapter("SELECT * FROM [workSheetNameHere$]", connectionString);
            //var ds = new DataSet();

            //adapter.Fill(ds, "anyNameHere");

            //var data = ds.Tables["anyNameHere"].AsEnumerable(); --To enable using LINQ query
            data = ds.Tables[0];
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
