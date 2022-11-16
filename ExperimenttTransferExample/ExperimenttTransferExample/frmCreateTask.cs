﻿using BioRails.Core.Model;
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
            BioRailsOutlineAPI outlineAPI = new BioRailsOutlineAPI(_session, _url);
            FolderArray outlines = outlineAPI.GetAllOutlines();
            foreach(Folder folder in outlines)
            {
                cmbOutlines.Items.Add(folder.Name);
            }
        }
        private void cmbOutlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            BioRailsProcessAPI processAPI = new BioRailsProcessAPI(_session, _url);
            FolderArray processes = processAPI.GetProcessByName(cmbOutlines.Text);
            processes.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Folder folder in processes)
            {
                cmbProcesVersions.Items.Add(folder.Name);
            }
        }

        private void cmbProcesVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            BioRailsProcessAPI processOps = new BioRailsProcessAPI(_session, _url);
            Process process = processOps.GetProcessByPath(cmbOutlines.Text + "/" + cmbProcesVersions.Text);
            ShowProcessParams(process);
        }

        private void ShowProcessParams(Process process)
        {
            _params = DataTableConverter.ParametersToDataTable(process.Parameters, dgvParameters.Columns);
            dgvParameters.Columns.Clear();
            dgvParameters.DataSource = _params;
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
            lblTaskStatus.Text = "Creating Task";
            BioRailsProcessAPI processOps = new BioRailsProcessAPI(_session, _url);
            Process process = processOps.GetProcessByPath(cmbOutlines.Text + "/" + cmbProcesVersions.Text);
            TaskRowArray taskRows = FileToTaskRowArray.ConvertExcelToTaskRowArray(lblDataFile.Text, _params);
            BioRails.Core.Model.Task newTask = CreateTaskObject(taskRows, process);
            BioRailsTaskAPI taskOps = new BioRailsTaskAPI(_session, _url);
            JobReport job = taskOps.CreateTask(newTask);
            JobReport polledJob = BioRailsJobHandler.pollJob(job, _session.SessionId, _url);
            BioRails.Core.Model.Task createdTask = GetTaskFromJob(polledJob);
            lblTaskStatus.Text = "Task Created";
            lblTaskPath.Text = createdTask.Path;
            AddDataFilesUnderTask(createdTask);
        }

        private BioRails.Core.Model.Task CreateTaskObject(TaskRowArray taskRows, Process process)
        {
            Guid g = Guid.NewGuid();
            string suffix = g.ToString().Replace('-', '_');
            BioRails.Core.Model.Task newTask = new BioRails.Core.Model.Task(Name: lblDataFile.Text.Replace('\\', '_') + suffix,
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
            BioRailsTaskAPI taskOps = new BioRailsTaskAPI(_session, _url);
            BioRails.Core.Model.Task newTask = taskOps.GetTaskNoRows(taskPath);
            return newTask;
        }

        private void AddDataFilesUnderTask(BioRails.Core.Model.Task task)
        {
            BioRailsFoldersAPI folderOps = new BioRailsFoldersAPI(_session, _url);
            Folder newFolder = folderOps.CreateFolder(task.Path);
            Folder newFile = folderOps.CreateFile(task.Path + "/" + "DataFiles", lblMSFile.Text);
            Console.WriteLine("Hello");
        }

        private void btnUpdateTaskFile_Click(object sender, EventArgs e)
        {
            lblTaskStatus.Text = "Editing Task";
            //GetPathToDataFile
            BioRailsFoldersAPI folderOps = new BioRailsFoldersAPI(_session, _url);
            FolderArray folders = folderOps.ListFolders(lblTaskPath.Text);
            string filePath = GetDataFilePath(folders);
            //EditTask
            //GetTask
            BioRailsTaskAPI taskOps = new BioRailsTaskAPI(_session, _url);
            BioRails.Core.Model.Task task = taskOps.GetTaskByPath(lblTaskPath.Text);
            //SetFilePath
            task = TaskEditor.SetTaskParameter(task, "FilePath", filePath);
            //UploadEditedTask
            JobReport job = taskOps.EditTask(task);
            JobReport polledJob = BioRailsJobHandler.pollJob(job, _session.SessionId, _url);
            lblTaskStatus.Text = "Task Edited";

        }

        private string GetDataFilePath(FolderArray folders)
        {
            string result = "";
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