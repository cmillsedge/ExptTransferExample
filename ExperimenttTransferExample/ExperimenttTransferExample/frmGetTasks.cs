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
                BioRailsQueryAPI queryOps = new BioRailsQueryAPI(_session, _url);
                NamedArray queries = queryOps.GetQueriesByFilter("PK_Results_Tasks");
                int maxrows = 100;
                int offset = 0;
                QueryColumnArray columns = queryOps.GetQueryColumns(queries[0].Id);
                QueryResults results = queryOps.GetQueryResults(queries[0].Id, maxrows, offset);
                DataTable dt = DataTableConverter.ResultsToDataTable(results, columns);
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
            string path = GetPathFromGridRow(dgvResults.SelectedRows);
            //Use path to get task object
            //Send task back to LIMS
            
        }

        private string GetPathFromGridRow(DataGridViewSelectedRowCollection drs)
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
                path = dr.Cells["project_element_path"].Value.ToString();
            }
            return path;

        }
    }
}
