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
            if (!txtFName.Text.Equals(null))
            {
                if (!txtLName.Text.Equals(null))
                {
                    if (!txtPhone.Text.Equals(null))
                    {
                        Client client = new Client();
                        client.AddNewClient(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text, txtStreetAddress.Text, txtSuburb.Text, txtPostCode.Text, txtProvince.Text, "conID", 1, "bankDetails", txtUnitNum.Text);

                        Random random = new Random();
                        int bankID = random.Next(10000);
                        if (!txtAccountNum.Text.Equals(null))
                        {
                            BankDetails bank = new BankDetails();
                            bank.AddBankDetails(bankID.ToString(), txtAccountNum.Text, txtBranchNum.Text, txtBankName.Text, txtAccountNum.Text);
                            MessageBox.Show("User have been added");
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

            ContractSellection sellection = new ContractSellection();
            sellection.Show();
            this.Hide();
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
