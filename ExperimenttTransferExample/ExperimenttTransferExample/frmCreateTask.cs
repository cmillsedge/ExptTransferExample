using BioRails.Core.Model;
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
using System.Collections;
using System.IO;

namespace ExperimenttTransferExample
{
    public partial class frmCreateTask : Form
    {
        Session _session;
        string _url;
        DataTable _params;
        public frmCreateTask(Session wsSession, string url)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
            PopulateOutlineCombo();
        }

        private void PopulateOutlineCombo()
        {
            //instantiate a class to deal with calls to the outlines api
            BioRailsOutlineAPI outlineAPI = new BioRailsOutlineAPI(_session, _url);
            //instantiate a folderarray object to hold a list of outlines
            FolderArray outlines = outlineAPI.GetAllOutlines();
            //fill a combo with the outline names
            foreach(Folder folder in outlines)
            {
                cmbOutlines.Items.Add(folder.Name);
            }
        }
        private void cmbOutlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            //instantiate a class to deal with calls to the processes api
            BioRailsProcessAPI processAPI = new BioRailsProcessAPI(_session, _url);
            //instantiate a folderarray object to hold a list of process version
            FolderArray processes = processAPI.GetProcessByPath(cmbOutlines.Text);
            //sort the folder array
            processes.Sort((x, y) => x.Name.CompareTo(y.Name));
            //fill the combo
            foreach (Folder folder in processes)
            {
                cmbProcesVersions.Items.Add(folder.Name);
            }
        }

        private void cmbProcesVersions_SelectedIndexChanged(object sender, EventArgs e)
        {

            //instantiate a class to deal with calls to the processes api
            BioRailsProcessAPI processOps = new BioRailsProcessAPI(_session, _url);
            //Retrieve a process object via the API
            Process process = processOps.GetProcessByName(cmbOutlines.Text + "/" + cmbProcesVersions.Text);
            //Call a method to display the process parameters in a data grid
            ShowProcessParams(process);
        }

        private void ShowProcessParams(Process process)
        {
            //Call a static method to convert a process's parameters into a data table and bind it to a datagridview
            _params = DataTableConverter.ParametersToDataTable(process.Parameters, dgvParameters.Columns);
            dgvParameters.Columns.Clear();
            dgvParameters.DataSource = _params;
        }

        private void btnGetBasicData_Click(object sender, EventArgs e)
        {
            //open a file browser - this is the file representing the task details from LabSys
            string myfile = SelectFile("C:\\");
            //set a label with the selected file
            lblDataFile.Text = myfile;
        }

        private void btnGetMSFile_Click(object sender, EventArgs e)
        {
            //open a file browser - this is the file representing the MS data file from LabSys
            string myfile = SelectFile("C:\\");
            // set a label with the selected file
            lblMSFile.Text = myfile;
        }

        private void btnCreateNewTask_Click(object sender, EventArgs e)
        {
            lblTaskStatus.Text = "Creating Task";
            //instantiate a class to deal with process API calls
            BioRailsProcessAPI processOps = new BioRailsProcessAPI(_session, _url);
            //retrieve the process so we can access the process path
            Process process = processOps.GetProcessByName(cmbOutlines.Text + "/" + cmbProcesVersions.Text);
            //build a set of taskRows based on the data file we selected earlier
            TaskRowArray taskRows = FileToTaskRowArray.ConvertExcelToTaskRowArray(lblDataFile.Text, _params);
            //Call a method to build the task
            BioRails.Core.Model.Task newTask = CreateTaskObject(taskRows, process);
            //instantiate a class to deal with process API calls
            BioRailsTaskAPI taskOps = new BioRailsTaskAPI(_session, _url);
            //call a method to upload the task and return the background job object
            JobReport job = taskOps.CreateTask(newTask);
            //wait for the background job to complete or fail and return the job when it is complete
            JobReport polledJob = BioRailsJobHandler.pollJob(job, _session.SessionId, _url);
            //Output job status 
            MessageBox.Show(polledJob.Status.ToString());
            //pull back the task (without any result data) we created based on information in the job
            BioRails.Core.Model.Task createdTask = GetTaskFromJob(polledJob);
            lblTaskStatus.Text = "Task Created";
            //use a label to store the task path as we will want this later
            lblTaskPath.Text = createdTask.Path;
            //upload a data file underneath the newly created task
            AddDataFilesUnderTask(createdTask);
        }

        private BioRails.Core.Model.Task CreateTaskObject(TaskRowArray taskRows, Process process)
        {
            //build a task name
            string taskName = "LABSYS-" + DateTime.Now.ToString().Replace('/', '_');
            //create a new task object with all the properties set including the task rows (which is where the parameters are stored
            BioRails.Core.Model.Task newTask = new BioRails.Core.Model.Task(Name: taskName,
                                                                            Description: "Task From WS Example App",
                                                                            StateName: "pending",
                                                                            ElementTypeName: "Task",
                                                                            ProcessPath: process.Path,
                                                                            MembershipPath: "All/Chris Mills", //this is "team.name/user.name"
                                                                            StartedAt: new DateTime(2025, 4, 4),
                                                                            ExpectedAt: new DateTime(2026, 6, 4),
                                                                            CustomProperties: null,
                                                                            Rows: null
                                                                            );
            newTask.Rows = taskRows;
            return newTask;
        }

        private BioRails.Core.Model.Task GetTaskFromJob(JobReport polledJob)
        {
            //polledjob.Results is a NamedArray of id, name, path of things which were created by job. 
            //We know this is only task so we will just grab the first one
            string taskPath = polledJob.Results[0].Path;
            //instantiate a class to handle task operations
            BioRailsTaskAPI taskOps = new BioRailsTaskAPI(_session, _url);
            //pull back the task with none of the data (this is faster than pulling back the full task)
            BioRails.Core.Model.Task newTask = taskOps.GetTaskNoRows(taskPath);
            return newTask;
        }

        private void AddDataFilesUnderTask(BioRails.Core.Model.Task task)
        {
            //instantiate a class to handle folder operations
            BioRailsFoldersAPI folderOps = new BioRailsFoldersAPI(_session, _url);
            //create a folder under our task to hold data files
            Folder newFolder = folderOps.CreateFolder(task.Path);
            //create a file under our new folder
            Folder newFile = folderOps.CreateFile(task.Path + "/" + "DataFiles", lblMSFile.Text);
        }

        private void btnUpdateTaskFile_Click(object sender, EventArgs e)
        {
            lblTaskStatus.Text = "Editing Task";
            //Instantiate api class for folder operations
            BioRailsFoldersAPI folderOps = new BioRailsFoldersAPI(_session, _url);
            //List all the folders and files under a given path - use the task path from the label we captured earlier
            FolderArray folders = folderOps.ListFolders(lblTaskPath.Text);
            //Pick the data file out of all the files and folders returned
            string filePath = GetDataFilePath(folders);
            //Now we want to edit the task and the first step is to retrieve it
            //Instantiate a task API class
            BioRailsTaskAPI taskOps = new BioRailsTaskAPI(_session, _url);
            //Retrieve the task object
            BioRails.Core.Model.Task task = taskOps.GetTaskByPath(lblTaskPath.Text);
            //Use a class to add a parameter and its value to all the rows in a task
            task = TaskEditor.SetTaskParameter(task, "FilePath", filePath);
            //Upload the edited task and return the background job into an object
            JobReport job = taskOps.EditTask(task);
            //Wait for the job to finish
            JobReport polledJob = BioRailsJobHandler.pollJob(job, _session.SessionId, _url);
            //Output job status 
            MessageBox.Show(polledJob.Status.ToString());
            lblTaskStatus.Text = "Task Edited";

        }

        private string GetDataFilePath(FolderArray folders)
        {
            string result = "";
            //look for a path which contains DataFiles and ends with xlsx
            foreach (Folder folder in folders)
            {
                if(folder.Path.Contains("DataFiles") && folder.Path.EndsWith("xlsx"))
                {
                    result = folder.Path;
                }
            }
            return result;
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
