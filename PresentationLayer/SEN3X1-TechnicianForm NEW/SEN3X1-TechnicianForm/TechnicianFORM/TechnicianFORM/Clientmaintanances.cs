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
using System.Data.SqlClient;

namespace TechnicianFORM
{
    public partial class ClientMaintanance : Form
    {
        public ClientMaintanance()
        {
            InitializeComponent();
        }
     
        BankDetails bankDetails = new BankDetails();
        Client client = new Client();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmailSearch.Text.Length > 0 && txtEmailSearch.Text.Contains("@"))
            {
                DataTable dt = client.searchClientDetails(txtEmailSearch.Text.ToString());
                if (dt.Rows.Count > 0)
                {
                    BindingSource bindingSource = new BindingSource();
                   
                    dt = client.dg2(txtEmailSearch.Text);
                    bindingSource.DataSource = dt;
                    dataGridView1.DataSource = bindingSource;


                    DataTable dataTable = new DataTable();

                    dataTable = client.dg4(txtEmailSearch.Text);


                    treeViewCustomer.Nodes.Clear();
                    treeViewCustomer.Nodes.Add("Client");
                 
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        
                        TreeNode treeNode = new TreeNode(dataRow["FullName"].ToString());
                        treeNode.Nodes.Add(dataRow["Email"].ToString());
                        treeNode.Nodes.Add(dataRow["Phone"].ToString());
                        treeNode.Nodes.Add(dataRow["ClientType"].ToString());
                        treeNode.Nodes.Add(dataRow["BankDetails"].ToString());
                        treeNode.Nodes.Add(dataRow["PaymentType"].ToString());
                        treeNode.Nodes.Add(dataRow["BankName"].ToString());
                        treeNode.Nodes.Add(dataRow["AccountNum"].ToString());
                        treeNode.Nodes.Add(dataRow["ContractID"].ToString());
                        treeNode.Nodes.Add(dataRow["ContractType"].ToString());
                        treeNode.Nodes.Add(dataRow["DeviceID"].ToString());
                        treeViewCustomer.Nodes.Add(treeNode);

                    }


                }
                else
                {
                    MessageBox.Show("Client not found!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        private void ClientMaintanance_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = client.dg3();


            treeViewCustomer.Nodes.Clear();
            treeViewCustomer.Nodes.Add("Client");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                
                TreeNode treeNode = new TreeNode(dataRow["FullName"].ToString());
                treeNode.Nodes.Add(dataRow["Email"].ToString());
                treeNode.Nodes.Add(dataRow["Phone"].ToString());
               // treeNode.Nodes.Add(dataRow["ClientType"].ToString());
               // treeNode.Nodes.Add(dataRow["BankDetails"].ToString());
                //treeNode.Nodes.Add(dataRow["PaymentType"].ToString());
               // treeNode.Nodes.Add(dataRow["BankName"].ToString());
               // treeNode.Nodes.Add(dataRow["AccountNum"].ToString());
               // treeNode.Nodes.Add(dataRow["ContractID"].ToString());
              //  treeNode.Nodes.Add(dataRow["ContractType"].ToString());
               // treeNode.Nodes.Add(dataRow["DeviceID"].ToString());
                treeViewCustomer.Nodes.Add(treeNode);

            }
        }
        //hotogre@myswamp.com
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {    
            txtClientID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtUnitNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSuburb.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtPostalCode.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtProvince.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtContractID.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtClientType.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtBankDetails.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtBankName.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtPaymentType.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtBranchNum.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtAccoutNum.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();

        }
       
        private void bntUpdate_Click(object sender, EventArgs e)
        {
            client.updateClient(txtClientID.Text, txtFirstName.Text, txtSurname.Text, txtEmail2.Text, txtSuburb.Text, txtPostalCode.Text,
               txtProvince.Text, txtAddress.Text, txtPhone.Text, txtContractID.Text, int.Parse(txtClientType.Text), 
               txtBankDetails.Text, txtUnitNumber.Text);

            bankDetails.updateBankDetails(txtBankDetails.Text, txtPaymentType.Text, txtBankName.Text, txtBranchNum.Text, txtAccoutNum.Text);

            MessageBox.Show("Client details updated","Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtClientID.Text = " ";
            txtFirstName.Text = " ";
            txtSurname.Text = " ";
            txtPhone.Text = " ";
            txtEmail2.Text = " ";
            txtAddress.Text = " ";
            txtUnitNumber.Text = " ";
            txtSuburb.Text = " ";
            txtPostalCode.Text = " ";
            txtProvince.Text = " ";
            txtContractID.Text = " ";
            txtClientType.Text = " ";
            txtBankDetails.Text = " ";
            txtBankName.Text = " ";
            txtPaymentType.Text = " ";
            txtBranchNum.Text = " ";
            txtAccoutNum.Text = " ";
            dataGridView1.DataSource = " ";
            txtEmailSearch.Text = " ";

        }
        
        private void bntReturn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);

        }
    }
}
