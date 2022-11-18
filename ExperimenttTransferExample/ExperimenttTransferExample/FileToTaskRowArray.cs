using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioRails.Core.Model;
using System.Data;
using System.Data.OleDb;

namespace ExperimenttTransferExample
{
    public static class FileToTaskRowArray
    {
        public static TaskRowArray ConvertExcelToTaskRowArray(string filePath, DataTable parameters)
        {
            //convert file to dataset 
            DataSet fileRows = Parse(filePath);
            TaskRowArray trows = MapHeaders(fileRows, parameters);
            //convert dataset to TaskRowArray based on process params
            return trows;
        }

        public static TaskRowArray MapHeaders(DataSet fileRows, DataTable parameters)
        {
            TaskRowArray trows = new TaskRowArray();
            int i = 1;
            foreach (DataRow row in fileRows.Tables[0].Rows)
            {
                Console.WriteLine("New File Row");
                TaskRow rowTask = new TaskRow();
                rowTask.Label = parameters.Rows[0]["ContextLabel"].ToString() + "." + i.ToString();
                rowTask.Parent = null;
                Dictionary<string, string> rowVals = new Dictionary<string, string>();
                foreach (DataColumn col in fileRows.Tables[0].Columns)
                {
                    foreach (DataRow paramNames in parameters.Rows)
                    {
                        if (ParameterComparer.ParametersSame(col.ToString(), paramNames["ParameterName"].ToString()))
                        {
                            rowVals.Add(paramNames["ParameterName"].ToString(), row[col].ToString());
                        }
                    }  
                }
                rowTask.Values = rowVals;
                i++;
                trows.Add(rowTask);
            }
            return trows;
        }
            static public DataSet Parse(string fileName)
        {
            //Vreate an OLEDB connection string for the file
            string connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1\";", fileName);


            DataSet data = new DataSet();

            //Create a data table in a dataset for each sheet in the Excel workbook.
            foreach (var sheetName in GetExcelSheetNames(connectionString))
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    var dataTable = new DataTable();
                    string query = string.Format("SELECT * FROM [{0}]", sheetName);
                    con.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    adapter.Fill(dataTable);
                    data.Tables.Add(dataTable);
                }
            }

            return data;
        }

        static string[] GetExcelSheetNames(string connectionString)
        {
            //Simple method to loop through the sheets in a workbook and return the sheet names as a string array
            OleDbConnection con = null;
            DataTable dt = null;
            con = new OleDbConnection(connectionString);
            con.Open();
            dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            if (dt == null)
            {
                return null;
            }

            String[] excelSheetNames = new String[dt.Rows.Count];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                excelSheetNames[i] = row["TABLE_NAME"].ToString();
                i++;
            }

            return excelSheetNames;
        }
    }

}
