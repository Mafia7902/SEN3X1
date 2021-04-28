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

            Ticket ticket = new Ticket();
            ticket.TicketInsert(ticket.IDGenV2(), "AA001", txtProblem.Text);
            MessageBox.Show("Probleme has been submited");
            Thread.Sleep(5000);
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();

        }
    }
}
