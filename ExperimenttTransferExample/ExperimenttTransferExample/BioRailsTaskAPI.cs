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
            //instantiate a new task
            BioRails.Core.Model.Task task = new BioRails.Core.Model.Task();
            try
            {
                //instantiate a new API object
                TasksApi tasksApi = new TasksApi(_url);
                //Call the find method to get the 
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
                //instantiate a new API object
                TasksApi tasksApi = new TasksApi(_url);
                //instantiate a task and populate it using the find method but return no row data
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
                //instantiate a new API object
                TasksApi tasksApi = new TasksApi(_url);
                //Call the task create method by passing a parent folder and a task object
                JobReport job = tasksApi.TaskCreate(_session.SessionId, "All", myTask); //"All" is the team to create the task under
                return job;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JobReport EditTask(BioRails.Core.Model.Task myTask)
        {
            try
            {
                //instantiate a new API object
                TasksApi tasksApi = new TasksApi(_url);
                //Call the task edit method by passing a parent folder and a task object
                JobReport job = tasksApi.TaskEdit(_session.SessionId, myTask.Path, myTask); //"All" is the team to create the task under
                return job;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
