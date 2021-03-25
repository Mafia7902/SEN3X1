using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
