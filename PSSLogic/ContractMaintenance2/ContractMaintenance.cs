using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractMaintenance2
{
    public partial class ContractMaintenance : Form
    {
        public ContractMaintenance()
        {
            InitializeComponent();
        }

        private void bntChangeContractState_Click(object sender, EventArgs e)
        {
            DeactivateContract deactivate = new DeactivateContract();
            deactivate.Show();
            this.Hide();
        }

        private void bntNew_Click(object sender, EventArgs e)
        {
            NewContractForm newContract = new NewContractForm();
            newContract.Show();
            this.Hide();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ContractDisplay contractDisplay = new ContractDisplay();
            contractDisplay.Show();
            this.Hide();
        }
    }
}
