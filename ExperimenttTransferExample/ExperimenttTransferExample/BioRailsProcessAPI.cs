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
    public class BioRailsProcessAPI
    {
        private Session _session;
        private string _url;
        public BioRailsProcessAPI(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public BioRailsProcessAPI()
        {
        }

        public Process GetProcessByName(string name)
        {

            Process process = null;
            try
            {
                //instantiate a process API object
                OutlineProcessesApi processesApi = new OutlineProcessesApi(_url);
                //use the ProcessFind method to get a process object by name
                process = processesApi.ProcessFind(_session.SessionId, name);
                return process;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FolderArray GetProcessByPath(string path)
        {

            //instantiate folder array to hold processes
            FolderArray processes = null;
            try
            {
                
                //instantiate processAPI for process operations
                OutlineProcessesApi processesApi = new OutlineProcessesApi(_url);
                //Call process list
                processes = processesApi.ProcessList(_session.SessionId, path);
                return processes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
