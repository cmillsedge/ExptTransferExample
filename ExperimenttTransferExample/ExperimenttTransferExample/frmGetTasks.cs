using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioRails.Core.Api;
using BioRails.Core.Client;
using BioRails.Core.Model;

namespace ExperimenttTransferExample
{
    public partial class frmGetTasks : Form
    {
        Session _session;
        string _url;
        public frmGetTasks(Session wsSession, string url)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
        }

        private void btnCheckTasks_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResults.AllowUserToAddRows = true;
                //instantiate a new query API object
                BioRailsQueryAPI queryOps = new BioRailsQueryAPI(_session, _url);
                //Return an array of query based on their names
                NamedArray queries = queryOps.GetQueriesByFilter("Labsys Completed Tasks");
                int maxrows = 100;
                int offset = 0;
                //Pull back the query columns to describe the data
                QueryColumnArray columns = queryOps.GetQueryColumns(queries[0].Id);
                //Pull back the query results
                QueryResults results = queryOps.GetQueryResults(queries[0].Id, maxrows, offset);
                //Convert the query results to a data table
                DataTable dt = DataTableConverter.ResultsToDataTable(results, columns);
                //Bind the data table to a datagridview
                dgvResults.DataSource = dt;
                dgvResults.AllowUserToAddRows = false;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetTask_Click(object sender, EventArgs e)
        {
            string taskName = GetTaskPropertyFromGridRow(dgvResults.SelectedRows, "project_element_path");
            try
            {
                using (frmTaskResults frmTaskResults = new frmTaskResults(_session, _url, taskName))
                {
                    frmTaskResults.Location = this.Location;
                    this.Hide();
                    frmTaskResults.ShowDialog();

                }
                this.Show();
                //frmSel closed re-display logon;
                //this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string GetTaskPropertyFromGridRow(DataGridViewSelectedRowCollection drs, string property)
        {
            string path = "";
            if (drs.Count == 0)
            {
                path = "Error: Please select one row in the grid before clicking GetHighlightedTask button";
            }
            else if (drs.Count > 1)
            {
                path = "Error: You have multiple rows selected. Please select only one row in the grid before clicking GetHighlightedTask button";
            }
            else //count is 1
            {
                DataGridViewRow dr = drs[0];
                //note the string "property" is the "Name" value of the query column and not the "Label" value of the query column
                path = dr.Cells[property].Value.ToString();
            }
            return path;

        }
    }
}
