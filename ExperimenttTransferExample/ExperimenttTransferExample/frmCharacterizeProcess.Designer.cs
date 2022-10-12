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
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Name,
            this.Description,
            this.ContextLabel,
            this.OutlineQueueName,
            this.OutlineParameterName,
            this.DataTypeName,
            this.DataElementPath,
            this.DataFormatName,
            this.ParameterTypeName,
            this.ParameterRoleName,
            this.DisplayUnit});
            this.dgvParameters.Location = new System.Drawing.Point(12, 25);
            this.dgvParameters.Name = "dgvParameters";
            this.dgvParameters.Size = new System.Drawing.Size(1348, 488);
            this.dgvParameters.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
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
            // frmCharacterizeProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 591);
            this.Controls.Add(this.dgvParameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCharacterizeProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Process Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
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
    }
}