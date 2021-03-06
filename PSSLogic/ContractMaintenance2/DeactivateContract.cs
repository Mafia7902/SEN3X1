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
    public partial class DeactivateContract : Form
    {
        public DeactivateContract()
        {
            InitializeComponent();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            ContractMaintenance contractMaintance = new ContractMaintenance();
            contractMaintance.Show();
            this.Close();
        }

        private void bntDeactivate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == null)
            {
                MessageBox.Show("Please Enter The Contract ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtID.Text != null)
            {
                int Active = int.Parse(cmbState.Text);
                var _newState = new BusinessLogic.Contract();
                _newState.newStates(Active, txtID.Text);
                MessageBox.Show("The contract state has changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
