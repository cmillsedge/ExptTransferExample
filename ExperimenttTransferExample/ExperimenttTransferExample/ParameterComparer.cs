using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimenttTransferExample
{
    public static class ParameterComparer
    {
        //This method is simply being used to see if headers in the data file and process parameters are the same while excluding any units in the names
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
