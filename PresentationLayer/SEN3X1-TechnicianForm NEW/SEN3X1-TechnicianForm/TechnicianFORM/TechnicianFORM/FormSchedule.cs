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


namespace TechnicianFORM
{
    public partial class Technician : Form
    {
        
        public Technician()
        {
            InitializeComponent();
            
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // Method to update ticket to "Complete".
            DataTable tktID = new TechInfo().dg1(1);
            string ticketID = tktID.Rows[3]["TicketID"].ToString();

            TechInfo t = new TechInfo();
            t.ConfirmCompletion(ticketID, 5);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
        TechInfo Tech = new TechInfo();

        private void Technician_Load(object sender, EventArgs e)
        {
            

            //if (dt1.Rows.Count > 0)
            //{
            //    MessageBox.Show("WE got something");
            //}


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BindingSource bindingsource1 = new BindingSource();
            DataTable dt1 = new DataTable();


            
            BindingSource bindingsource2 = new BindingSource();
            DataTable dt2 = new DataTable();

            

            dt1 = Tech.dg1(1);
            bindingsource1.DataSource = dt1;
            dataGridView1.DataSource = bindingsource1;

            dt2 = Tech.dg2(1);
            bindingsource2.DataSource = dt2;
            dataGridView2.DataSource = bindingsource2;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
  
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClientMaintanance clientMaintanance = new ClientMaintanance();
            this.Hide();
            clientMaintanance.Show();
        }
    }
}
