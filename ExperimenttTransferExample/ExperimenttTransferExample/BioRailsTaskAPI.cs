using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioRails.Core.Api;
using BioRails.Core.Client;
using BioRails.Core.Model;

namespace ExperimenttTransferExample
{
    public class BioRailsTaskAPI
    {
        private Session _session;
        private string _url;
        public BioRailsTaskAPI(Session session, string url)
        {
            _session = session;
            _url = url;
        }
    

        public BioRails.Core.Model.Task GetTaskByPath(string path)
        {
            BioRails.Core.Model.Task task = new BioRails.Core.Model.Task();
            try
            {
                TasksApi tasksApi = new TasksApi(_url);
                task = tasksApi.TaskFind(_session.SessionId, path);
                return task;
            }
            catch (Exception ex)
            {
                return task;
            }
        }
    }
}
