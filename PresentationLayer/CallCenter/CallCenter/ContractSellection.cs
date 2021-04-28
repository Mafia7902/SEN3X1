using BusinessLogic;
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
    public partial class ContractSellection : Form
    {
        public ContractSellection()
        {
            InitializeComponent();
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExistingCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.ContractDescription = comboBoxPlanSelect.Text;
            contract.ContractID = " ";

            if (contract.ContractDescription.Equals("Platinum"))
            {
                Random random = new Random();
                string date = DateTime.Now.ToString("yyyy MMMM").Substring(0,4);
                char contractType = (char)('a' + random.Next(0, 5));
                contractType.ToString().ToUpper();
                char letter = 'A';
                string newID = "";
                
                do
                {
                    newID += random.Next(10).ToString();
                } while (newID.Length != 6);

                contract.ContractID = date +contractType+ letter + newID.ToString();
                contract.Price = 8000;
                string contractDesc = "Top of the range";

                contract.contractInsert(contract.ContractID, comboBoxPlanSelect.Text, contractDesc, contract.Price, "epxlp", 1);
            }
            else if (contract.ContractDescription.Equals("Gold"))
            {
                Random random = new Random();
                string date = DateTime.Now.ToString("yyyy MMMM").Substring(0, 4);
                char contractType = (char)('a' + random.Next(0, 5));
                contractType.ToString().ToUpper();
                char letter = 'B';

                string newID = "";

                do
                {
                    newID += random.Next(10).ToString();
                } while (newID.Length != 6);

                contract.ContractID = date + contractType + letter + newID.ToString();
                contract.Price = 5000;
                string contractDesc = "Medium class";

                contract.contractInsert(contract.ContractID, comboBoxPlanSelect.Text, contractDesc, contract.Price, "epxlp", 0);
            }
            else if (contract.ContractDescription.Equals("Silver"))
            {

                Random random = new Random();
                string date = DateTime.Now.ToString("yyyy MMMM").Substring(0, 4);
                char contractType = (char)('a' + random.Next(0, 5));
                contractType.ToString().ToUpper();
                char letter = 'C';
                string newID = "";

                do
                {
                    newID += random.Next(10).ToString();
                } while (newID.Length != 6);

                contract.ContractID = date + contractType + letter + newID.ToString();
                contract.Price = 2000;
                string contractDesc = "Budget";
                contract.contractInsert(contract.ContractID, comboBoxPlanSelect.Text, contractDesc, contract.Price, "epxlp", 0);
            }
            else if (contract.ContractDescription.Equals("Bronze"))
            {

                Random random = new Random();
                string date = DateTime.Now.ToString("yyyy MMMM").Substring(0, 4);
                char contractType = (char)('a' + random.Next(0, 5));
                contractType.ToString().ToUpper();
                char letter = 'D';
                string newID = "";

                do
                {
                    newID += random.Next(10).ToString();
                } while (newID.Length != 6);

                contract.ContractID = date + contractType + letter + newID.ToString();
                contract.Price = 800;
                string contractDesc = "Entry package";
                contract.contractInsert(contract.ContractID, comboBoxPlanSelect.Text, contractDesc, contract.Price, "epxlp", 0);
            }

          


            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
