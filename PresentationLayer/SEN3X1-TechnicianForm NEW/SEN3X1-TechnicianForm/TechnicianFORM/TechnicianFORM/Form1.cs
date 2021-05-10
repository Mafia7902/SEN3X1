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

namespace TechnicianFORM
{
    public partial class ClientMaintanance : Form
    {
        public ClientMaintanance()
        {
            InitializeComponent();
        }


        Client client = new Client();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0 && txtEmail.Text.Contains("@"))
            {
               
                DataTable dt = client.searchClient(txtEmail.Text.ToString());
                if (dt.Rows.Count > 0)
                {
                    BindingSource bindingSource = new BindingSource();
                   
                    dt = client.dg1(txtEmail.Text);
                    bindingSource.DataSource = dt;
                    dataGridView1.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("Client not found!");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid email!");
            }
        }

        private void ClientMaintanance_Load(object sender, EventArgs e)
        {
         
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
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            client.updateClient(txtClientID.Text, txtFirstName.Text, txtSurname.Text, txtEmail2.Text, txtSuburb.Text, txtPostalCode.Text,
               txtProvince.Text, txtAddress.Text, txtPhone.Text, txtContractID.Text, int.Parse(txtClientType.Text), txtBankDetails.Text, txtUnitNumber.Text);
        }
    }
}
