using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static DataTable ParametersToDataTable(ProcessParameterArray procParams, DataGridViewColumnCollection cols)
        {

            DataTable table = new DataTable();
            for (int i = 0; i < cols.Count; i++)
            {
                table.Columns.Add(cols[i].Name);
            }

            foreach (ProcessParameter pr in procParams)
            {
                DataRow dtrow;
                dtrow = table.NewRow();
                dtrow["Id"] = pr.Id.ToString();
                if (pr.Name != null) { dtrow["ParameterName"] = pr.Name.ToString(); }
                if (pr.Description != null) { dtrow["Description"] = pr.Description.ToString(); }
                if (pr.ContextLabel != null) { dtrow["ContextLabel"] = pr.ContextLabel.ToString(); }
                if (pr.OutlineQueueName != null) { dtrow["OutlineQueueName"] = pr.OutlineQueueName.ToString(); }
                if (pr.OutlineParameterName != null) { dtrow["OutlineParameterName"] = pr.OutlineParameterName.ToString(); }
                if (pr.DataTypeName != null) { dtrow["DataTypeName"] = pr.DataTypeName.ToString(); }
                if (pr.DataElementPath != null) { dtrow["DataElementPath"] = pr.DataElementPath.ToString(); }
                if (pr.DataFormatName != null) { dtrow["DataFormatName"] = pr.DataFormatName.ToString(); }
                if (pr.ParameterRoleName != null) { dtrow["ParameterRoleName"] = pr.ParameterRoleName.ToString(); }
                if (pr.DisplayUnit != null) { dtrow["DisplayUnit"] = pr.DisplayUnit.ToString(); }
                if (pr.Mandatory != null) { dtrow["Mandatory"] = pr.Mandatory.ToString(); }
                table.Rows.Add(dtrow);
            }
            return table;
        }

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
