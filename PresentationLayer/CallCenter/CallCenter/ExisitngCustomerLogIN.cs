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

namespace CallCenter
{
    public partial class ExisitngCustomerLogIN : Form
    {
        public ExisitngCustomerLogIN()
        {
            InitializeComponent();
        }

        private void ExisitngCustomerLogIN_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtEmailSearch.Text.Length > 0 && txtEmailSearch.Text.Contains("@"))
            {
                Client client = new Client();
                DataTable dt = client.searchClient(txtEmailSearch.Text.ToString());
                if (dt.Rows.Count > 0)
                {
                    ClientChoiceForm choiceForm = new ClientChoiceForm(txtEmailSearch.Text.Trim());
                    MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    choiceForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Enter a valid email!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
