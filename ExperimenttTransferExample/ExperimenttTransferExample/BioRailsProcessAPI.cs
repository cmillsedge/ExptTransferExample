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

        public Process GetProcessByPath(string path)
        {

            Process process = null;
            try
            {
                OutlineProcessesApi processesApi = new OutlineProcessesApi(_url);
                process = processesApi.ProcessFind(_session.SessionId, path);
                return process;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FolderArray GetProcessByName(string name)
        {

            FolderArray processes = null;
            try
            {
                OutlineProcessesApi processesApi = new OutlineProcessesApi(_url);
                processes = processesApi.ProcessList(_session.SessionId, name);
                return processes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
