using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
// using ContractMaintance;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string jobID = BackEnd.BusinessLogic.EmployeeLogin.JobID;
            switch (jobID)
            {
                case "1":
                    {
                        TechnicianFORM.Technician f1 = new TechnicianFORM.Technician();
                        f1.Show();
                        break;
                    }
                case "2":
                    {
                        CallCenter.MainMenu f2 = new CallCenter.MainMenu();
                        f2.Show();
                        break;
                    }
                case "3":
                    {
                        // ContractMaintance.Form1 f1 = new ContractMaintance.Form1();
                        // f1.Show();
                        break;
                    }
                case "4":
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

        private void txtBoxEmpID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
