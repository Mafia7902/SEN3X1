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
    public partial class ClientChoiceForm : Form
    {
        private string _email;
        public ClientChoiceForm(string email)
        {
            _email = email;
            InitializeComponent();
        }

        private void bntComplant_Click(object sender, EventArgs e)
        {
            ProblemeDesc probleme = new ProblemeDesc();
            probleme.Show();
            this.Hide();
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            ContractMaintenanceForm contract = new ContractMaintenanceForm(_email); 
            contract.Show();
            this.Hide();

        }

        private void ClientChoiceForm_Load(object sender, EventArgs e)
        {
            lbClientEmail.Text = _email;
        }
    }
}
