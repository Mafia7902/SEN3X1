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
                            if (txtEmail.Text.Length > 0)
                            {
                                if (txtStreetAddress.Text.Length > 0)
                                {
                                    if (txtPostCode.Text.Length > 0)
                                    {
                                        if (txtProvince.Text.Length > 0)
                                        {
                                            if (txtBankName.Text.Length > 0)
                                            {
                                                if (txtBranchNum.Text.Length > 0)
                                                {
                                                    if (txtPaymentType.Text.Length > 0)
                                                    {
                                                        Random random = new Random();
                                                        int bankID = random.Next(10000);
                                                        BankDetails bank = new BankDetails();
                                                        Client client = new Client();
                                                        

                                                        string caseSwitch = txtContractType.Text;
                                                        switch (caseSwitch) {
                                                            case "Platinum":
                                                             
                                                                bank.AddBankDetails("BankID" + bankID.ToString(), txtPaymentType.Text, txtBranchNum.Text,
                                                                            txtBankName.Text, txtAccountNum.Text);

                                                                client.AddNewClient(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text,
                                                                            txtStreetAddress.Text, txtSuburb.Text, txtPostCode.Text, txtProvince.Text,
                                                                            "2021AA694065", 1, "BankID" + bankID.ToString(), txtUnitNum.Text);
                                                                break;
                                                            case "Gold":

                                                                bank.AddBankDetails("BankID" + bankID.ToString(), txtPaymentType.Text, txtBranchNum.Text,
                                                                            txtBankName.Text, txtAccountNum.Text);

                                                                client.AddNewClient(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text,
                                                                            txtStreetAddress.Text, txtSuburb.Text, txtPostCode.Text, txtProvince.Text,
                                                                             "2021BB434447", 1, "BankID" + bankID.ToString(), txtUnitNum.Text);
                                                                break;
                                                            case "Silver":

                                                                bank.AddBankDetails("BankID" + bankID.ToString(), txtPaymentType.Text, txtBranchNum.Text,
                                                                            txtBankName.Text, txtAccountNum.Text);

                                                                client.AddNewClient(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text,
                                                                            txtStreetAddress.Text, txtSuburb.Text, txtPostCode.Text, txtProvince.Text,
                                                                             "contractID", 1, "BankID" + bankID.ToString(), txtUnitNum.Text);
                                                                break;
                                                            case "Bronze":

                                                                bank.AddBankDetails("BankID" + bankID.ToString(), txtPaymentType.Text, txtBranchNum.Text,
                                                                            txtBankName.Text, txtAccountNum.Text);

                                                                client.AddNewClient(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text,
                                                                            txtStreetAddress.Text, txtSuburb.Text, txtPostCode.Text, txtProvince.Text,
                                                                             "contractID", 1, "BankID" + bankID.ToString(), txtUnitNum.Text);
                                                                break;

                                                        }
                                                       


                                                        


                                                        ContractSellection sellection = new ContractSellection();
                                                        MessageBox.Show("New user has been added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                        sellection.Show();
                                                        this.Hide();

                                                    
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Enter Payment Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Enter Branch Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Bank Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter Your Province", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter Your Postal Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter Your Street Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Your account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
