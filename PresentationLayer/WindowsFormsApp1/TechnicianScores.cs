using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;



namespace WindowsFormsApp1
{
    public partial class TechnicianScores : Form
    {
        TechInfo techInfo = new TechInfo();
        public TechnicianScores()
        {
            InitializeComponent();
        }

        private void GetTech_Click(object sender, EventArgs e)
        {
            BindingSource bindingsource1 = new BindingSource();
            DataTable dt1;

            dt1 = techInfo.AllTechnicians();
            bindingsource1.DataSource = dt1;
            dataGridView1.DataSource = bindingsource1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int TechID = Int32.Parse(txtBoxSearch.Text);
            BindingSource bindingsource1 = new BindingSource();
            DataTable dt1;

            dt1 = techInfo.SpecificTechnicians(TechID);
            if (dt1.Rows.Count>0)
            {
                bindingsource1.DataSource = dt1;
                dataGridView1.DataSource = bindingsource1;
            }
            else
            {
                MessageBox.Show("No record found for employee ID: "+ TechID);
            }
        }
    }
}
