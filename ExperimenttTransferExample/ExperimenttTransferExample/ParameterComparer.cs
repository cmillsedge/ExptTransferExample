using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimenttTransferExample
{
    public static class StringComparer
    {
        public static bool ParametersSame(string fileParameter, string processParameter)
        {
            bool result = false;
            string colName = "";
            if (fileParameter.Contains(" "))
            {
                colName = fileParameter.ToLower().Substring(0, fileParameter.IndexOf(" "));
            }
            else
            {
                colName = fileParameter.ToString().ToLower();
            }

            string paramName = processParameter.ToLower();
            if (paramName.Contains(" "))
            {
                paramName = processParameter.Substring(0, processParameter.IndexOf(" "));
            }

            if (paramName == colName)
            {
                result = true;
            }

            return result;
        }
    }
}
