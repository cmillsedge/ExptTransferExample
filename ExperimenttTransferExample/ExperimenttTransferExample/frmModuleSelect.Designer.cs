namespace ExperimenttTransferExample
{
    partial class frmModuleSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModuleSelect));
            this.lblCreateTask = new System.Windows.Forms.Label();
            this.btnGetTasks = new System.Windows.Forms.Button();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.lblFindTasks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreateTask
            // 
            this.lblCreateTask.AutoSize = true;
            this.lblCreateTask.Location = new System.Drawing.Point(13, 89);
            this.lblCreateTask.Name = "lblCreateTask";
            this.lblCreateTask.Size = new System.Drawing.Size(104, 13);
            this.lblCreateTask.TabIndex = 1;
            this.lblCreateTask.Text = "Create Task Via WS";
            // 
            // btnGetTasks
            // 
            this.btnGetTasks.Image = global::ExperimenttTransferExample.Properties.Resources.report;
            this.btnGetTasks.Location = new System.Drawing.Point(262, 12);
            this.btnGetTasks.Name = "btnGetTasks";
            this.btnGetTasks.Size = new System.Drawing.Size(92, 65);
            this.btnGetTasks.TabIndex = 2;
            this.btnGetTasks.UseVisualStyleBackColor = true;
            this.btnGetTasks.Click += new System.EventHandler(this.btnGetTasks_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Image = global::ExperimenttTransferExample.Properties.Resources.task;
            this.btnCreateTask.Location = new System.Drawing.Point(16, 16);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(92, 65);
            this.btnCreateTask.TabIndex = 0;
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // lblFindTasks
            // 
            this.lblFindTasks.AutoSize = true;
            this.lblFindTasks.Location = new System.Drawing.Point(256, 89);
            this.lblFindTasks.Name = "lblFindTasks";
            this.lblFindTasks.Size = new System.Drawing.Size(98, 13);
            this.lblFindTasks.TabIndex = 3;
            this.lblFindTasks.Text = "Find Tasks Via WS";
            // 
            // frmModuleSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 114);
            this.Controls.Add(this.lblFindTasks);
            this.Controls.Add(this.btnGetTasks);
            this.Controls.Add(this.lblCreateTask);
            this.Controls.Add(this.btnCreateTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModuleSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Choose Functionality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Label lblCreateTask;
        private System.Windows.Forms.Button btnGetTasks;
        private System.Windows.Forms.Label lblFindTasks;
    }
}