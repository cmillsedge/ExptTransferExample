using BioRails.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimenttTransferExample
{
    public static class TaskEditor
    {
        public static BioRails.Core.Model.Task SetTaskParameter(BioRails.Core.Model.Task task, string parameterName, string parameterValue)
        {
            foreach(TaskRow taskRow in task.Rows)
            {
                taskRow.Values.Add(parameterName, parameterValue);
            }
            return task;
        }
    }
}
