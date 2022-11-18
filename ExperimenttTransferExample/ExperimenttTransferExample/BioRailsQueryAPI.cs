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
                //Create a filter object based on the name column, with a like operator, and a filter string with a wildcard
                Filter filter = new Filter("name", "like", new List<string>() { filterstring + "%" });
                //Add the filter to a filter array object
                FilterArray filters = new FilterArray { filter };
                //Instantiate a new query API
                QueriesApi queriesApi = new QueriesApi(_url);
                //Use the queries search method to return all the queries based on that filter
                queries = queriesApi.QueriesSearch(_session.SessionId, 100, filters);
                return queries;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public QueryResults GetQueryResults(string queryId, int maxrows, int offset)
        {

            //instantiate a query results object
            QueryResults results = new QueryResults { };
            try
            {
                //instantiate a query API
                QueriesApi queriesApi = new QueriesApi(_url);
                //Use the queries run method to populate the query results object
                //we are passing in the session id, the query id, the BioRails filter name,
                //the maximum number of rows to return and the offset from row 0 for those max number of rows (this is for pagination)
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

            //instantiate a new query object
            Query query = new Query { };
            //instantiate a query column arrary
            QueryColumnArray columns = new QueryColumnArray { };
            try
            {
                //instantiate a query api
                QueriesApi queriesApi = new QueriesApi(_url);
                //use the query get method to pull back the query based on the query id passed in
                query = queriesApi.QueryGet(_session.SessionId, queryId);
                //set the query column array equal to the query columns 
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
