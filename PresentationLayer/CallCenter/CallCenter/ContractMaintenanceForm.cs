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
    public partial class ContractMaintenanceForm : Form
    {
        private string _email;
        public ContractMaintenanceForm(string email)
        {
            _email = email;
            InitializeComponent();
        }

        private void ContractMaintenanceForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show(_email);
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            ClientChoiceForm choiceForm = new ClientChoiceForm(_email);
            choiceForm.Show();
            this.Close();
        }
    }
}
