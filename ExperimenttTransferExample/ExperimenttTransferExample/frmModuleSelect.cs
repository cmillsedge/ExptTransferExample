using BioRails.Core.Api;
using BioRails.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimenttTransferExample
{
    public partial class frmModuleSelect : Form
    {
        Session _session;
        string _url;
        public frmModuleSelect(Session wsSession, string url)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmCreateTask frmSelectProcessVersion = new frmCreateTask(_session, _url))
                {
                    frmSelectProcessVersion.Location = this.Location;
                    this.Hide();
                    frmSelectProcessVersion.ShowDialog();

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

        private void btnGetTasks_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmGetTasks frmGetTasks = new frmGetTasks(_session, _url))
                {
                    frmGetTasks.Location = this.Location;
                    this.Hide();
                    frmGetTasks.ShowDialog();

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
    }
}
