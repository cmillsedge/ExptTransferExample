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
                //get the base URL from the login form's textbox
                string url = txtURL.Text.TrimEnd('/');
                //add the api extension to the URL and instantiate a new session api object
                SessionsApi s = new SessionsApi(url + "/api/v6");
                //use the sessionapi to get a valid session by passing in the username and password
                Session session = s.Login(txtUser.Text, txtPass.Text);
                //open a new form and pass in the session and the URL so we can use other API endpoints downstream
                using (frmModuleSelect frmModuleSelect = new frmModuleSelect(session, url + "/api/v6"))
                {
                    frmModuleSelect.Location = this.Location;
                    this.Hide();
                    frmModuleSelect.ShowDialog();

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
