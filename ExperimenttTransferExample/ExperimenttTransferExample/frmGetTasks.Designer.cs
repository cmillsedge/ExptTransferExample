namespace ExperimenttTransferExample
{
    partial class frmGetTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetTasks));
            this.btnCheckTasks = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnGetTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckTasks
            // 
            this.btnCheckTasks.Location = new System.Drawing.Point(13, 13);
            this.btnCheckTasks.Name = "btnCheckTasks";
            this.btnCheckTasks.Size = new System.Drawing.Size(113, 23);
            this.btnCheckTasks.TabIndex = 0;
            this.btnCheckTasks.Text = "Get Pending Tasks";
            this.btnCheckTasks.UseVisualStyleBackColor = true;
            this.btnCheckTasks.Click += new System.EventHandler(this.btnCheckTasks_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(13, 53);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(775, 337);
            this.dgvResults.TabIndex = 1;
            // 
            // btnGetTask
            // 
            this.btnGetTask.Location = new System.Drawing.Point(670, 406);
            this.btnGetTask.Name = "btnGetTask";
            this.btnGetTask.Size = new System.Drawing.Size(118, 23);
            this.btnGetTask.TabIndex = 2;
            this.btnGetTask.Text = "Get Highlighted Task";
            this.btnGetTask.UseVisualStyleBackColor = true;
            this.btnGetTask.Click += new System.EventHandler(this.btnGetTask_Click);
            // 
            // frmGetTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetTask);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnCheckTasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGetTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GetTasks";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckTasks;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnGetTask;
    }
}