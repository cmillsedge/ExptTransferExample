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
    public class BioRailsQueryAPI
    {
        private Session _session;
        private string _url;
        public BioRailsQueryAPI(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public BioRailsQueryAPI()
        {
        }

        public NamedArray GetQueriesByFilter(string filterstring)
        {

            NamedArray queries = new NamedArray { };
            try
            {
                Filter filter = new Filter("name", "like", new List<string>() { filterstring + "%" });
                FilterArray filters = new FilterArray { filter };
                QueriesApi queriesApi = new QueriesApi(_url);
                queries = queriesApi.QueriesSearch(_session.SessionId, 100, filters);
                foreach (Named query in queries)
                {
                    Console.WriteLine(query.Name);
                }
                return queries;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public QueryResults GetQueryResults(string queryId, int maxrows, int offset)
        {

            QueryResults results = new QueryResults { };
            try
            {
                QueriesApi queriesApi = new QueriesApi(_url);
                results = queriesApi.QueriesRun(_session.SessionId, queryId, "All", maxrows, offset);
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public QueryResults GetQueryResults(string queryId, int maxrows, int offset, FilterArray filters)
        {

            QueryResults results = new QueryResults { };
            try
            {
                QueriesApi queriesApi = new QueriesApi(_url);
                results = queriesApi.QueriesRun(_session.SessionId, queryId, "All", maxrows, offset, filters);
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public QueryColumnArray GetQueryColumns(string queryId)
        {

            Query query = new Query { };
            QueryColumnArray columns = new QueryColumnArray { };
            try
            {
                QueriesApi queriesApi = new QueriesApi(_url);
                query = queriesApi.QueryGet(_session.SessionId, queryId);
                columns = query.Columns;
                return columns;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
