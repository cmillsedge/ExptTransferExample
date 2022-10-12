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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtURL.Text.TrimEnd('/');
                SessionsApi s = new SessionsApi(url + "/api/v6");
                Session key = s.Login(txtUser.Text, txtPass.Text);
                Console.WriteLine(key.SessionId);
                using (frmGetTasks frmGetTasks = new frmGetTasks(key, url + "/api/v6"))
                {
                    frmGetTasks.Location = this.Location;
                    this.Hide();
                    frmGetTasks.ShowDialog();

                }
                this.Show();
                //frmSel closed re-display logon
                this.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
