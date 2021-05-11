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
                        //ContractMaintance.Form1 f1 = new ContractMaintance.Form1();
                        // f1.Show();
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
