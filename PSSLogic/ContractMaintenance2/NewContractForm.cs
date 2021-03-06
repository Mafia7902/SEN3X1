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
    
    public partial class NewContractForm : Form
    {
        public NewContractForm()
        {
            InitializeComponent();
            
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            ContractMaintenance contract = new ContractMaintenance();
            contract.Show();
            this.Close();
        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != null || txtDeviceID.Text != null || txtPrice.Text != null || cmbActive.Text != null || CombContractType.Text != null|| txtManufacturer.Text != null || txtModel.Text != null)
            {
                var year = DateTime.Now.Year;
                String importnace;
                Random random = new Random();
                String ID;
                String r = random.Next(0, 999999).ToString("D6");
                int Active = int.Parse(cmbActive.Text);
                float Price = float.Parse(txtPrice.Text);

                
                String caseSwitch = CombContractType.Text;
                switch (caseSwitch)
                {
                    case "Platinum":
                        importnace = "AA";
                        ID = year.ToString() + importnace + r;
                        //MessageBox.Show(ID);
                        var _contract = new BusinessLogic.Contract();
                        var _device = new BusinessLogic.Device();

                        _device.deviceInsert(txtDeviceID.Text, txtManufacturer.Text, txtModel.Text);
                        _contract.contractInsert(ID, CombContractType.Text, txtDescription.Text, Price, txtDeviceID.Text, Active);
                        MessageBox.Show("New contract has been made","New Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Gold":
                        importnace = "BB";
                        ID = year.ToString() + importnace + r;
                        //MessageBox.Show(ID);
                       _contract = new BusinessLogic.Contract();
                        _device = new BusinessLogic.Device();

                        _device.deviceInsert(txtDeviceID.Text, txtManufacturer.Text, txtModel.Text);
                        _contract.contractInsert(ID, CombContractType.Text, txtDescription.Text, Price, txtDeviceID.Text, Active);
                        MessageBox.Show("New contract has been made", "New Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Silver":
                        importnace = "CC";
                        ID = year.ToString() + importnace + r;
                       // MessageBox.Show(ID);
                        _contract = new BusinessLogic.Contract();
                         _device = new BusinessLogic.Device();

                        _device.deviceInsert(txtDeviceID.Text, txtManufacturer.Text, txtModel.Text);
                        _contract.contractInsert(ID, CombContractType.Text, txtDescription.Text, Price, txtDeviceID.Text, Active);
                        MessageBox.Show("New contract has been made", "New Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Bronze":
                        importnace = "DD";
                        ID = year.ToString() + importnace + r;
                        //MessageBox.Show(ID);
                         _contract = new BusinessLogic.Contract();
                         _device = new BusinessLogic.Device();

                        _device.deviceInsert(txtDeviceID.Text, txtManufacturer.Text, txtModel.Text);
                        _contract.contractInsert(ID, CombContractType.Text, txtDescription.Text, Price, txtDeviceID.Text, Active);

                        MessageBox.Show("New contract has been made", "New Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                                         
                        MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                
                
            }
            else
            {
                MessageBox.Show("Please Fill In All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtManufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewContractForm_Load(object sender, EventArgs e)
        {

        }
    }
}
