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
           
            if (!txtEmailSearch.Text.Equals(null))
            {
                Client client = new Client();
                client.searchClient(txtEmailSearch.Text);

                    ProblemeDesc probleme = new ProblemeDesc();
                    probleme.Show();
                    this.Hide();

            }
            else
            {
                MessageBox.Show("Enter an email!");
            }

           
        }
    }
}
