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
using BackEnd.BusinessLogic;
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
                                                    if (cboxPaymentType.Text.Length > 0)
                                                    {
                                                        if (txtContractID.Text.Length > 0)
                                                        {
                                                            Random random = new Random();
                                                            int bankID = random.Next(10000);
                                                            BankDetails bank = new BankDetails();
                                                            Client client = new Client();
                                                            ClientContract clientContract = new ClientContract();
                                                            string id = "";
                                                            string clientID = client.idChecker(id);




                                                            bank.AddBankDetails("BankID" + bankID.ToString(), cboxPaymentType.Text, txtBranchNum.Text,
                                                                        txtBankName.Text, txtAccountNum.Text);

                                                            client.AddNewClient(clientID, txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text,
                                                                        txtStreetAddress.Text, txtSuburb.Text, txtPostCode.Text, txtProvince.Text,
                                                                         1, "BankID" + bankID.ToString(), txtUnitNum.Text);


                                                            clientContract.insertClientContract(clientID, txtContractID.Text);
                                                            MessageBox.Show("New user has been added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Select a contract", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
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
      
        Contract contract = new Contract();
        private void NewCustomer_Load(object sender, EventArgs e)
        {
            txtContractID.Hide();
      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        string conID;
        private void txtContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            BindingSource bindingSource = new BindingSource();
            dt2 = contract.SelectcontractTypes(cboxContractType.Text);
            bindingSource.DataSource = dt2;
            dgvcontractSelect.DataSource = bindingSource;

        }

        private void dgvcontractSelect_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtContractID.Text = dgvcontractSelect.Rows[e.RowIndex].Cells[0].Value.ToString();
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
