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
    public partial class FormLogConfirmation : Form
    {
        public FormLogConfirmation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Technician tech = new Technician();
            tech.Show();

            this.Close();

        }
    }
}
