namespace ExperimenttTransferExample
{
    partial class frmCreateTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateTask));
            this.lblOutlines = new System.Windows.Forms.Label();
            this.lblProcVers = new System.Windows.Forms.Label();
            this.cmbProcesVersions = new System.Windows.Forms.ComboBox();
            this.cmbOutlines = new System.Windows.Forms.ComboBox();
            this.lblMSFile = new System.Windows.Forms.Label();
            this.lblDataFile = new System.Windows.Forms.Label();
            this.btnCreateNewTask = new System.Windows.Forms.Button();
            this.btnGetMSFile = new System.Windows.Forms.Button();
            this.btnGetBasicData = new System.Windows.Forms.Button();
            this.dgvParameters = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutlineQueueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutlineParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataElementPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFormatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mandatory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProcessParams = new System.Windows.Forms.Label();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.btnUpdateTaskFile = new System.Windows.Forms.Button();
            this.lblTaskPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutlines
            // 
            this.lblOutlines.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.lblOutlines.AutoSize = true;
            this.lblOutlines.Location = new System.Drawing.Point(12, 21);
            this.lblOutlines.Name = "lblOutlines";
            this.lblOutlines.Size = new System.Drawing.Size(73, 13);
            this.lblOutlines.TabIndex = 0;
            this.lblOutlines.Text = "Select Outline";
            // 
            // lblProcVers
            // 
            this.lblProcVers.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.lblProcVers.AutoSize = true;
            this.lblProcVers.Location = new System.Drawing.Point(12, 54);
            this.lblProcVers.Name = "lblProcVers";
            this.lblProcVers.Size = new System.Drawing.Size(88, 13);
            this.lblProcVers.TabIndex = 3;
            this.lblProcVers.Text = "Process Versions";
            // 
            // cmbProcesVersions
            // 
            this.cmbProcesVersions.FormattingEnabled = true;
            this.cmbProcesVersions.Location = new System.Drawing.Point(206, 51);
            this.cmbProcesVersions.Name = "cmbProcesVersions";
            this.cmbProcesVersions.Size = new System.Drawing.Size(258, 21);
            this.cmbProcesVersions.TabIndex = 4;
            this.cmbProcesVersions.SelectedIndexChanged += new System.EventHandler(this.cmbProcesVersions_SelectedIndexChanged);
            // 
            // cmbOutlines
            // 
            this.cmbOutlines.FormattingEnabled = true;
            this.cmbOutlines.Location = new System.Drawing.Point(206, 18);
            this.cmbOutlines.Name = "cmbOutlines";
            this.cmbOutlines.Size = new System.Drawing.Size(258, 21);
            this.cmbOutlines.TabIndex = 5;
            this.cmbOutlines.SelectedIndexChanged += new System.EventHandler(this.cmbOutlines_SelectedIndexChanged);
            // 
            // lblMSFile
            // 
            this.lblMSFile.AutoSize = true;
            this.lblMSFile.Location = new System.Drawing.Point(203, 148);
            this.lblMSFile.Name = "lblMSFile";
            this.lblMSFile.Size = new System.Drawing.Size(62, 13);
            this.lblMSFile.TabIndex = 10;
            this.lblMSFile.Text = "Select a file";
            // 
            // lblDataFile
            // 
            this.lblDataFile.AutoSize = true;
            this.lblDataFile.Location = new System.Drawing.Point(203, 118);
            this.lblDataFile.Name = "lblDataFile";
            this.lblDataFile.Size = new System.Drawing.Size(62, 13);
            this.lblDataFile.TabIndex = 9;
            this.lblDataFile.Text = "Select a file";
            // 
            // btnCreateNewTask
            // 
            this.btnCreateNewTask.Location = new System.Drawing.Point(12, 172);
            this.btnCreateNewTask.Name = "btnCreateNewTask";
            this.btnCreateNewTask.Size = new System.Drawing.Size(173, 23);
            this.btnCreateNewTask.TabIndex = 8;
            this.btnCreateNewTask.Text = "Create Task From Files";
            this.btnCreateNewTask.UseVisualStyleBackColor = true;
            this.btnCreateNewTask.Click += new System.EventHandler(this.btnCreateNewTask_Click);
            // 
            // btnGetMSFile
            // 
            this.btnGetMSFile.Location = new System.Drawing.Point(12, 143);
            this.btnGetMSFile.Name = "btnGetMSFile";
            this.btnGetMSFile.Size = new System.Drawing.Size(173, 23);
            this.btnGetMSFile.TabIndex = 7;
            this.btnGetMSFile.Text = "Get MS File";
            this.btnGetMSFile.UseVisualStyleBackColor = true;
            this.btnGetMSFile.Click += new System.EventHandler(this.btnGetMSFile_Click);
            // 
            // btnGetBasicData
            // 
            this.btnGetBasicData.Location = new System.Drawing.Point(12, 112);
            this.btnGetBasicData.Name = "btnGetBasicData";
            this.btnGetBasicData.Size = new System.Drawing.Size(173, 25);
            this.btnGetBasicData.TabIndex = 6;
            this.btnGetBasicData.Text = "Get Basic Task Info From File";
            this.btnGetBasicData.UseVisualStyleBackColor = true;
            this.btnGetBasicData.Click += new System.EventHandler(this.btnGetBasicData_Click);
            // 
            // dgvParameters
            // 
            this.dgvParameters.AllowUserToAddRows = false;
            this.dgvParameters.AllowUserToDeleteRows = false;
            this.dgvParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ParameterName,
            this.Description,
            this.ContextLabel,
            this.OutlineQueueName,
            this.OutlineParameterName,
            this.DataTypeName,
            this.DataElementPath,
            this.DataFormatName,
            this.ParameterTypeName,
            this.ParameterRoleName,
            this.DisplayUnit,
            this.Mandatory});
            this.dgvParameters.Location = new System.Drawing.Point(499, 40);
            this.dgvParameters.Name = "dgvParameters";
            this.dgvParameters.Size = new System.Drawing.Size(1092, 341);
            this.dgvParameters.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ParameterName
            // 
            this.ParameterName.HeaderText = "ParameterName";
            this.ParameterName.Name = "ParameterName";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // ContextLabel
            // 
            this.ContextLabel.HeaderText = "ContextLabel";
            this.ContextLabel.Name = "ContextLabel";
            // 
            // OutlineQueueName
            // 
            this.OutlineQueueName.HeaderText = "OutlineQueueName";
            this.OutlineQueueName.Name = "OutlineQueueName";
            // 
            // OutlineParameterName
            // 
            this.OutlineParameterName.HeaderText = "OutlineParameterName";
            this.OutlineParameterName.Name = "OutlineParameterName";
            // 
            // DataTypeName
            // 
            this.DataTypeName.HeaderText = "DataTypeName";
            this.DataTypeName.Name = "DataTypeName";
            // 
            // DataElementPath
            // 
            this.DataElementPath.HeaderText = "DataElementPath";
            this.DataElementPath.Name = "DataElementPath";
            // 
            // DataFormatName
            // 
            this.DataFormatName.HeaderText = "DataFormatName";
            this.DataFormatName.Name = "DataFormatName";
            // 
            // ParameterTypeName
            // 
            this.ParameterTypeName.HeaderText = "ParameterTypeName";
            this.ParameterTypeName.Name = "ParameterTypeName";
            // 
            // ParameterRoleName
            // 
            this.ParameterRoleName.HeaderText = "ParameterRoleName";
            this.ParameterRoleName.Name = "ParameterRoleName";
            // 
            // DisplayUnit
            // 
            this.DisplayUnit.HeaderText = "DisplayUnit";
            this.DisplayUnit.Name = "DisplayUnit";
            // 
            // Mandatory
            // 
            this.Mandatory.HeaderText = "Mandatory";
            this.Mandatory.Name = "Mandatory";
            // 
            // lblProcessParams
            // 
            this.lblProcessParams.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.lblProcessParams.AutoSize = true;
            this.lblProcessParams.Location = new System.Drawing.Point(500, 20);
            this.lblProcessParams.Name = "lblProcessParams";
            this.lblProcessParams.Size = new System.Drawing.Size(131, 13);
            this.lblProcessParams.TabIndex = 12;
            this.lblProcessParams.Text = "Process Parameter Details";
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.AutoSize = true;
            this.lblTaskStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaskStatus.Location = new System.Drawing.Point(203, 177);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(61, 13);
            this.lblTaskStatus.TabIndex = 13;
            this.lblTaskStatus.Text = "Not Started";
            // 
            // btnUpdateTaskFile
            // 
            this.btnUpdateTaskFile.Location = new System.Drawing.Point(12, 201);
            this.btnUpdateTaskFile.Name = "btnUpdateTaskFile";
            this.btnUpdateTaskFile.Size = new System.Drawing.Size(173, 23);
            this.btnUpdateTaskFile.TabIndex = 14;
            this.btnUpdateTaskFile.Text = "Update File Parameter";
            this.btnUpdateTaskFile.UseVisualStyleBackColor = true;
            this.btnUpdateTaskFile.Click += new System.EventHandler(this.btnUpdateTaskFile_Click);
            // 
            // lblTaskPath
            // 
            this.lblTaskPath.AutoSize = true;
            this.lblTaskPath.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTaskPath.Location = new System.Drawing.Point(500, 395);
            this.lblTaskPath.Name = "lblTaskPath";
            this.lblTaskPath.Size = new System.Drawing.Size(61, 13);
            this.lblTaskPath.TabIndex = 15;
            this.lblTaskPath.Text = "Not Started";
            // 
            // frmCreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 450);
            this.Controls.Add(this.lblTaskPath);
            this.Controls.Add(this.btnUpdateTaskFile);
            this.Controls.Add(this.lblTaskStatus);
            this.Controls.Add(this.lblProcessParams);
            this.Controls.Add(this.dgvParameters);
            this.Controls.Add(this.lblMSFile);
            this.Controls.Add(this.lblDataFile);
            this.Controls.Add(this.btnCreateNewTask);
            this.Controls.Add(this.btnGetMSFile);
            this.Controls.Add(this.btnGetBasicData);
            this.Controls.Add(this.cmbOutlines);
            this.Controls.Add(this.cmbProcesVersions);
            this.Controls.Add(this.lblProcVers);
            this.Controls.Add(this.lblOutlines);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create Task For Process";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutlines;
        private System.Windows.Forms.Label lblProcVers;
        private System.Windows.Forms.ComboBox cmbProcesVersions;
        private System.Windows.Forms.ComboBox cmbOutlines;
        private System.Windows.Forms.Label lblMSFile;
        private System.Windows.Forms.Label lblDataFile;
        private System.Windows.Forms.Button btnCreateNewTask;
        private System.Windows.Forms.Button btnGetMSFile;
        private System.Windows.Forms.Button btnGetBasicData;
        private System.Windows.Forms.DataGridView dgvParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContextLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutlineQueueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutlineParameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataElementPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFormatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mandatory;
        private System.Windows.Forms.Label lblProcessParams;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.Button btnUpdateTaskFile;
        private System.Windows.Forms.Label lblTaskPath;
    }
}