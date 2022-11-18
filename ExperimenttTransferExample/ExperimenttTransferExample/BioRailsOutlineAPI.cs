using BioRails.Core.Api;
using BioRails.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimenttTransferExample
{
    
    public class BioRailsOutlineAPI
    {
        private Session _session;
        private string _url;
        public BioRailsOutlineAPI(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public FolderArray GetAllOutlines()
        {
            try
            {
                //instantiate an outlines API object
                OutlinesApi outlinesApi = new OutlinesApi(_url);
                //call the list method
                FolderArray outlines = outlinesApi.OutlineList(_session.SessionId, "");
                return outlines;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
