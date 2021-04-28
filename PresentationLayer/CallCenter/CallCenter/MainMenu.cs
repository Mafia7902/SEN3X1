using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenter
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
  

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            NewCustomer newCustomer = new NewCustomer();
            newCustomer.Show();
            this.Hide();
        }

       

        private void btnExistingCustomer_Click(object sender, EventArgs e)
        {
            ExisitngCustomerLogIN logIN = new ExisitngCustomerLogIN();
            logIN.Show();
            this.Hide();
        }
    }
}
