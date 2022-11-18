using BioRails.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimenttTransferExample
{
    public partial class frmTaskResults : Form
    {
        Session _session;
        string _url;
        string _taskPath;
        public frmTaskResults(Session wsSession, string url, string taskPath)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
            _taskPath = taskPath;
            string taskName = taskPath.Split('/')[taskPath.Split('/').Length - 1];
            LoadData(taskName);
        }

        private void LoadData(string taskName)
        {
            try
            {
                dgvResults.AllowUserToAddRows = true;
                //instantiate a query API
                BioRailsQueryAPI queryOps = new BioRailsQueryAPI(_session, _url);
                //Pull back the query based on its name
                NamedArray queries = queryOps.GetQueriesByFilter("process_definition_11943_results");
                int maxrows = 100;
                int offset = 0;
                //Create a filter array
                FilterArray filters = new FilterArray();
                //Add a filter to the array with the column name, operator and a list of one or more values , in this case the task name
                Filter filter1 = new Filter("task_name", "=", new List<string>() { taskName });
                //Add the filter to the array
                filters.Add(filter1);
                //Get the columns to describe the query results with
                QueryColumnArray columns = queryOps.GetQueryColumns(queries[0].Id);
                //Run the query using the same parameters we used for the tasks query but with the addition of a filters array to limit the data returned.
                QueryResults results = queryOps.GetQueryResults(queries[0].Id, maxrows, offset, filters);
                //Convert the results into a data table
                DataTable dt = DataTableConverter.ResultsToDataTable(results, columns);
                //Bind the data table to the data grid view
                dgvResults.DataSource = dt;
                dgvResults.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnPublish_Click(object sender, EventArgs e)
        {
            //instantiate a folder API object
            BioRailsFoldersAPI folderOps = new BioRailsFoldersAPI(_session, _url);
            //Call a method to update the folder state to Published
            FolderArray folders = folderOps.UpdateFolderState(_taskPath, "Published");
            //Show the outcome
            MessageBox.Show(folders[0].Name + " updated to state " + folders[0].StateName);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
