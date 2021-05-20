using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.BusinessLogic;
using BusinessLogic;


namespace TechnicianFORM
{
    public partial class Technician : Form
    {
        string jobID;
        string item;
        int empID;

        public Technician()
        {
            InitializeComponent();
            jobID = BusinessLogic.EmployeeLogin.JobID;

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // Method to update ticket to "Complete".
            //DataTable tktID = new TechInfo().dg1(1);
            //string ticketID = tktID.Rows[3]["TicketID"].ToString();

            TechInfo t = new TechInfo();
            t.ConfirmCompletion(item);

            MessageBox.Show("Ticket Marked as completed","Success",MessageBoxButtons.OK);

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            item = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
        TechInfo Tech = new TechInfo();

        private void Technician_Load(object sender, EventArgs e)
        {
            if (jobID=="admin")
            {
                btnSearch.Visible = true;
                txtSearch.Visible = true;
                btnGetTicket.Visible = false;
            }
        }

        DataTable dt1 = new DataTable();

        private void btnGetTicket_Click(object sender, EventArgs e)
        {
            empID = EmployeeLogin.EmpID;
            BindingSource bindingsource1 = new BindingSource();

            BindingSource bindingsource2 = new BindingSource();
            DataTable dt2 = new DataTable();

            dt1 = Tech.dg1(empID);
            bindingsource1.DataSource = dt1;
            dataGridView1.DataSource = bindingsource1;

            dt2 = Tech.dg2(empID);
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

        private void btnReassign_Click(object sender, EventArgs e)
        {
            // Get current empoyee ID
            // Run select "SelectAvailableTechnician". Pass current technician id and min score
            // Returns a datatable
            // make a variable and assign the first row of the dt to the variable

            ReassignTicket reassign = new ReassignTicket();
            Console.WriteLine(item);

            reassign.assignTicket(item, empID);

            MessageBox.Show("Ticket has been reassigned","Success",MessageBoxButtons.OK);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            empID = Int32.Parse(txtSearch.Text);
            BindingSource bindingsource1 = new BindingSource();

            BindingSource bindingsource2 = new BindingSource();
            DataTable dt2 = new DataTable();

            dt1 = Tech.dg1(empID);
            bindingsource1.DataSource = dt1;
            dataGridView1.DataSource = bindingsource1;

            dt2 = Tech.dg2(empID);
            bindingsource2.DataSource = dt2;
            dataGridView2.DataSource = bindingsource2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    } 
}
