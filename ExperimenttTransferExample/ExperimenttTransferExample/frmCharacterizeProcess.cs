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
    public partial class frmCharacterizeProcess : Form
    {
        Session _session;
        string _url;
        public frmCharacterizeProcess(Session wsSession, string url, BioRails.Core.Model.Task task)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
            BioRailsProcessAPI processOps = new BioRailsProcessAPI(_session, _url);
            Process process = processOps.GetProcessByPath(task.ProcessPath);
            ShowProcessParams(process);
        }

        private void ShowProcessParams(Process process)
        {
            DataTable dt = DataTableConverter.ParametersToDataTable(process.Parameters,dgvParameters.Columns);
            dgvParameters.Columns.Clear();
            dgvParameters.DataSource = dt;
            Console.WriteLine("BreakHere");
        }

        private void btnGetBasicData_Click(object sender, EventArgs e)
        {
            string myfile = SelectFile("C:\\");
            lblDataFile.Text = myfile;
        }

        private void btnGetMSFile_Click(object sender, EventArgs e)
        {
            string myfile = SelectFile("C:\\");
            lblMSFile.Text = myfile;
        }

        private void btnCreateNewTask_Click(object sender, EventArgs e)
        {

        }

        private string SelectFile(string initialDirectory)
        {
            //simple method to open a file browse dialog restricted to Excel files for use with the import plate method 
            //See supporting files folder in this project for the only supported file format. 
            OpenFileDialog dialog = new OpenFileDialog();

            try
            {
                //dialog.Filter = "Comma Seperated Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                dialog.Filter = "New Excel(*.xlsx)|*.xlsx";
                dialog.InitialDirectory = initialDirectory;
                dialog.Title = "Select an Excel File ..";
                dialog.FileName = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    //sStartPath = System.IO.Path.GetDirectoryName(dialog.FileName);
                    return (dialog.FileName);
                }
                else
                {
                    return (string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return (string.Empty);
            }

        }
    }
}
