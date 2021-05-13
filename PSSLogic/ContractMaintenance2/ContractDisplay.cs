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
    public partial class ContractDisplay : Form
    {
        public ContractDisplay()
        {
            InitializeComponent();
        }

        private void ContractDisplay_Load(object sender, EventArgs e)
        {
            var _getContracts = new BusinessLogic.Contract();
            dgvViewContracts.DataSource = _getContracts.selectAllContracts();
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            var _getNewContracts = new BusinessLogic.Contract();
            dgvViewContracts.DataSource = _getNewContracts.SelectcontractType(cmbContractType.Text);
        }
    }
}
