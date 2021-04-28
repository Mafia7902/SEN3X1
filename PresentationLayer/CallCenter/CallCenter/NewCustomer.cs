using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;


namespace CallCenter
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu LoginForm = new MainMenu();
            LoginForm.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*To be updated later - Stefan*/
            if (txtFName.Text.Length > 0)
            {
                if (txtLName.Text.Length > 0)
                {
                    if (txtPhone.Text.Length > 0)
                    {
                        if (txtAccountNum.Text.Length > 0)
                        {
                            Random random = new Random();
                            int bankID = random.Next(10000);
                            BankDetails bank = new BankDetails();
                            bank.AddBankDetails(bankID.ToString(), txtAccountNum.Text.ToString(), txtBranchNum.Text.ToString(), txtBankName.Text.ToString(), txtAccountNum.Text.ToString());
                            Client client = new Client();
                            client.AddNewClient(txtFName.Text.ToString(), txtLName.Text.ToString(), txtPhone.Text.ToString(), txtEmail.Text.ToString(), txtStreetAddress.Text.ToString(), txtSuburb.Text.ToString(), txtPostCode.Text.ToString(), txtProvince.Text.ToString(), "conID", 1, "bankDetails", txtUnitNum.Text.ToString());
                            ContractSellection sellection = new ContractSellection();
                            MessageBox.Show("New user has been added");
                            sellection.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Enter Your account Number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Phone Number");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Surname");
                }
            }
            else
            {
                MessageBox.Show("Enter Name");

            }


        }


        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
