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
    public partial class frmCharacterizeProcess : Form
    {
        Session _session;
        string _url;
        public frmCharacterizeProcess(Session wsSession, string url, BioRails.Core.Model.Task task)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
            BioRailsProcessAPI processOps = new BioRailsProcessAPI(_session, _url);
            Process process = processOps.GetProcessByPath(task.ProcessPath);
            Console.WriteLine("BreakHere");
        }
    }
}
