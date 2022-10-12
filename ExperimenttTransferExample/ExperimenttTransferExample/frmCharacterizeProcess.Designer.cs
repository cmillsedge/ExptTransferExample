namespace ExperimenttTransferExample
{
    partial class frmCharacterizeProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCharacterizeProcess));
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
            this.btnGetBasicData = new System.Windows.Forms.Button();
            this.btnGetMSFile = new System.Windows.Forms.Button();
            this.btnCreateNewTask = new System.Windows.Forms.Button();
            this.lblDataFile = new System.Windows.Forms.Label();
            this.lblMSFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).BeginInit();
            this.SuspendLayout();
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
            this.dgvParameters.Location = new System.Drawing.Point(12, 25);
            this.dgvParameters.Name = "dgvParameters";
            this.dgvParameters.Size = new System.Drawing.Size(1348, 341);
            this.dgvParameters.TabIndex = 0;
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
            // btnGetBasicData
            // 
            this.btnGetBasicData.Location = new System.Drawing.Point(12, 382);
            this.btnGetBasicData.Name = "btnGetBasicData";
            this.btnGetBasicData.Size = new System.Drawing.Size(173, 25);
            this.btnGetBasicData.TabIndex = 1;
            this.btnGetBasicData.Text = "Get Basic Task Info From File";
            this.btnGetBasicData.UseVisualStyleBackColor = true;
            this.btnGetBasicData.Click += new System.EventHandler(this.btnGetBasicData_Click);
            // 
            // btnGetMSFile
            // 
            this.btnGetMSFile.Location = new System.Drawing.Point(12, 413);
            this.btnGetMSFile.Name = "btnGetMSFile";
            this.btnGetMSFile.Size = new System.Drawing.Size(173, 23);
            this.btnGetMSFile.TabIndex = 2;
            this.btnGetMSFile.Text = "Get MS File";
            this.btnGetMSFile.UseVisualStyleBackColor = true;
            this.btnGetMSFile.Click += new System.EventHandler(this.btnGetMSFile_Click);
            // 
            // btnCreateNewTask
            // 
            this.btnCreateNewTask.Location = new System.Drawing.Point(12, 442);
            this.btnCreateNewTask.Name = "btnCreateNewTask";
            this.btnCreateNewTask.Size = new System.Drawing.Size(173, 23);
            this.btnCreateNewTask.TabIndex = 3;
            this.btnCreateNewTask.Text = "Create Task From Files";
            this.btnCreateNewTask.UseVisualStyleBackColor = true;
            this.btnCreateNewTask.Click += new System.EventHandler(this.btnCreateNewTask_Click);
            // 
            // lblDataFile
            // 
            this.lblDataFile.AutoSize = true;
            this.lblDataFile.Location = new System.Drawing.Point(203, 388);
            this.lblDataFile.Name = "lblDataFile";
            this.lblDataFile.Size = new System.Drawing.Size(62, 13);
            this.lblDataFile.TabIndex = 4;
            this.lblDataFile.Text = "Select a file";
            // 
            // lblMSFile
            // 
            this.lblMSFile.AutoSize = true;
            this.lblMSFile.Location = new System.Drawing.Point(203, 418);
            this.lblMSFile.Name = "lblMSFile";
            this.lblMSFile.Size = new System.Drawing.Size(62, 13);
            this.lblMSFile.TabIndex = 5;
            this.lblMSFile.Text = "Select a file";
            // 
            // frmCharacterizeProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 591);
            this.Controls.Add(this.lblMSFile);
            this.Controls.Add(this.lblDataFile);
            this.Controls.Add(this.btnCreateNewTask);
            this.Controls.Add(this.btnGetMSFile);
            this.Controls.Add(this.btnGetBasicData);
            this.Controls.Add(this.dgvParameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCharacterizeProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Process Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnGetBasicData;
        private System.Windows.Forms.Button btnGetMSFile;
        private System.Windows.Forms.Button btnCreateNewTask;
        private System.Windows.Forms.Label lblDataFile;
        private System.Windows.Forms.Label lblMSFile;
    }
}