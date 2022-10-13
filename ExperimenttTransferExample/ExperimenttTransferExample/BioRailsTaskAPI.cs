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
                throw ex;
            }
        }

        public BioRails.Core.Model.Task GetTaskNoRows(string path)
        {
            try
            {
                TasksApi tasksApi = new TasksApi(_url);
                BioRails.Core.Model.Task task = tasksApi.TaskFind(_session.SessionId, path, true); //passing true to the last argument gives you the task without the task rows which is smaller
                return task;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobReport CreateTask(BioRails.Core.Model.Task myTask)
        {
            try
            {
                TasksApi tasksApi = new TasksApi(_url);
                JobReport job = tasksApi.TaskCreate(_session.SessionId, "All", myTask); //"All" is the team to create the task under
                return job;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
