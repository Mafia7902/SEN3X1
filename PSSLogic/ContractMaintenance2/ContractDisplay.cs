﻿using System;
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
        BindingSource bindingsource1 = new BindingSource();
        DataTable dt1 = new DataTable();
        public ContractDisplay()
        {
            InitializeComponent();
            var _getContracts = new BusinessLogic.Contract();
            dt1 = _getContracts.selectAllContracts();
        }

        private void ContractDisplay_Load(object sender, EventArgs e)
        { 
            bindingsource1.DataSource = dt1;
            dgvViewContracts.DataSource = bindingsource1;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            var _getNewContracts = new BusinessLogic.Contract();
            dt1 = _getNewContracts.SelectcontractType(cmbContractType.Text);
            bindingsource1.DataSource = dt1;
            dgvViewContracts.DataSource = bindingsource1;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            var _getContracts = new BusinessLogic.Contract();
            dt1 = _getContracts.selectAllContracts();
            bindingsource1.DataSource = dt1;
            dgvViewContracts.DataSource = bindingsource1;
        }
    }
}
