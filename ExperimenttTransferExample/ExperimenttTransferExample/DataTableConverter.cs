using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BioRails.Core.Model;

namespace ExperimenttTransferExample
{
    public static class DataTableConverter
    {
        public static DataTable ResultsToDataTable(QueryResults results, QueryColumnArray columns)
        {

            DataTable table = new DataTable();
            QueryRow firstrow = results.Rows[0];

            for (int i = 0; i < columns.Count; i++)
            {
                table.Columns.Add(columns[i].Name, GetTypeFromString(columns[i].FieldType));
            }

            foreach (QueryRow row in results.Rows)
            {
                DataRow dtrow;
                dtrow = table.NewRow();
                foreach (var val in row.Values)
                {
                    if (val.Value != null && val.Key != "")
                    {
                        dtrow[val.Key] = val.Value;
                    };

                }
                table.Rows.Add(dtrow);
            }
            return table;
        }

        //public static DataTable ResultsToDataTable(QueryResults results, QueryColumnArray columns)
        //{

        //    DataTable table = new DataTable();
        //    QueryRow firstrow = results.Rows[0];

        //    for (int i = 0; i < columns.Count; i++)
        //    {
        //        table.Columns.Add(columns[i].Name, GetTypeFromString(columns[i].FieldType));
        //    }

        //    foreach (QueryRow row in results.Rows)
        //    {
        //        DataRow dtrow;
        //        dtrow = table.NewRow();
        //        foreach (var val in row.Values)
        //        {
        //            if (val.Value != null && val.Key != "")
        //            {
        //                dtrow[val.Key] = val.Value;
        //            };

        //        }
        //        table.Rows.Add(dtrow);
        //    }
        //    return table;
        //}

        public static Type GetTypeFromString(string columnType)
        {
            Type colType = System.Type.GetType("System.String");
            switch (columnType)
            {
                case "string":
                    colType = System.Type.GetType("System.String");
                    break;
                case "datetime":
                    colType = System.Type.GetType("System.DateTime");
                    break;
                case "date":
                    colType = System.Type.GetType("System.DateTime");
                    break;
                case "number":
                    colType = System.Type.GetType("System.Double");
                    break;
                case "integer":
                    colType = System.Type.GetType("System.Int32");
                    break;
                case "float":
                    colType = System.Type.GetType("System.Double");
                    break;
                case "boolean":
                    colType = System.Type.GetType("System.Boolean");
                    break;

            }

            return colType;
        }
    }
}
