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

        private void Technician_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new TechInfo().dg1(1);
            dataGridView1.DataSource = dt1;
            

            DataTable dt2 = new TechInfo().dg2(1);
            dataGridView1.DataSource = dt2;

        }
    }
}
