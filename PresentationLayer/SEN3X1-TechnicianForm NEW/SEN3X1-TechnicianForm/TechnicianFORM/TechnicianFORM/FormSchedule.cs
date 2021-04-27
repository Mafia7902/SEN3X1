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
            FormLogConfirmation confirm = new FormLogConfirmation();
            confirm.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void Technician_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new TechInfo().dg1(1);

            foreach (DataRow row in dt1.Rows)
            {
                dataGridView1.DataSource = dt1;
            }


            DataTable dt2 = new TechInfo().dg2(1);

            foreach (DataRow row in dt2.Rows)
            {
                dataGridView1.DataSource = dt2;
            }

            // Testing inserting data into the DGV on FormSchedule
            /* DataTable dt1 = new TechInfo().myTestData(1);

             foreach (DataRow row in dt1.Rows)
             {
                 dataGridView1.DataSource = dt1;
             }
            */
        }
    }
}
