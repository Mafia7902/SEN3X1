using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using TechnicianFORM;

namespace CallCenter
{
    public partial class ProblemeDesc : Form
    {
        public ProblemeDesc()
        {
            InitializeComponent();
        }

        private void ProblemeDesc_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtProblem.Text.Length > 0)
            {
                Ticket ticket = new Ticket();
                
                TechnicianFORM.Technician f1 = new TechnicianFORM.Technician();
                string ticketID = ticket.IDGenV2();
                ticket.TicketInsert(ticketID, "call22", txtProblem.Text.ToString());
                TicketAssigning.assignTicket(ticketID);
                MessageBox.Show("Problem has been submited\nThe Ticket Number is:\n"+ticketID,"Submitted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MainMenu mainMenu = new MainMenu();
                f1.Show();
                this.Hide();
            }

            // take to the EndCall form
            //EndCall end = new EndCall();
            //end.Show();

            ProblemeDesc prob = new ProblemeDesc();
            prob.Close();
        }
    }
}
