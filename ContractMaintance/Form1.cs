using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractMaintance
{
    public partial class ContractMaintance : Form
    {
        public ContractMaintance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewContractForm newContract = new NewContractForm();
            newContract.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeactivateContract deactivate = new DeactivateContract();
            deactivate.Show();
            this.Hide();
        }

        private void ContractMaintance_Load(object sender, EventArgs e)
        {

        }
    }
}
