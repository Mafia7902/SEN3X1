using BusinessLogic;
using ContractMaintenance2;
using System;
using System.Windows.Forms;

namespace LoginV2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeLogin el = new EmployeeLogin();
            el.VerifyUser(textBox1.Text, textBox2.Text);
            string jobID = BusinessLogic.EmployeeLogin.JobID;
            switch (jobID)
            {
                case "2":
                    {
                        TechnicianFORM.Technician f1 = new TechnicianFORM.Technician();
                        f1.Show();
                        break;
                    }
                case "3":
                    {
                        CallCenter.MainMenu f2 = new CallCenter.MainMenu();
                        f2.Show();
                        break;
                    }
                case "5":
                    {
                        var frm = new ContractMaintenance();
                        frm.Show();
                        this.Hide();
                        break;
                    }
                case "6":
                    {
                        TechnicianFORM.ClientMaintanance f1 = new TechnicianFORM.ClientMaintanance();
                        f1.Show();
                        break;

                    }

                default:
                    {
                        MessageBox.Show("an error has occured");
                        break;
                    }
            }
        }
    }
}
