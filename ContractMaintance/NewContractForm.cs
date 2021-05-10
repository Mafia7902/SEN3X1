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
    public partial class NewContractForm : Form
    {
        public NewContractForm()
        {
            InitializeComponent();
            
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            ContractMaintance contract = new ContractMaintance();
            contract.Show();
            this.Close();
        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {
            if (txtContractID.Text != null || txtDescription.Text != null || txtDeviceID.Text != null || txtPrice.Text != null || cmbActive.Text != null || CombContractType.Text != null)
            {
                int Active = int.Parse(cmbActive.Text);
                float Price = float.Parse(txtPrice.Text);
                var _contract = new BusinessLogic.Contract();
                _contract.contractInsert(txtContractID.Text, CombContractType.Text, txtDescription.Text, Price, txtDeviceID.Text, Active);
            }
            else
            {
                MessageBox.Show("Please Fill In All Fields ");
            }
        }
    }
}
