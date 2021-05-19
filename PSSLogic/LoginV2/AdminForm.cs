using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using ContractMaintenance2;
using CallCenter;

namespace LoginV2
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            var frm = new CallCenter.MainMenu();
            frm.Show();
        }

        private void btnTechReview_Click(object sender, EventArgs e)
        {
            var frm = new TechnicianScores();
            frm.Show();
        }

        private void btnContractMain_Click(object sender, EventArgs e)
        {
            var frm = new ContractMaintenance();
            frm.Show();
        }

        private void btnTechForm_Click(object sender, EventArgs e)
        {
            var frm = new TechnicianFORM.Technician();
            frm.Show();
        }

        private void btnClinetMain_Click(object sender, EventArgs e)
        {
            var frm = new TechnicianFORM.ClientMaintanance();
            frm.Show();
        }
    }
}
