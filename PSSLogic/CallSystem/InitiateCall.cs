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

namespace CallSystem
{
    public partial class InitiateCall : Form
    {
        public InitiateCall()
        {
            InitializeComponent();
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            // takes you to the LoginForm
            LoginV2.Login f1 = new LoginV2.Login();
            f1.Show();

            CallInformation start = new CallInformation();
            start.startTime();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallInformation end = new CallInformation();
            end.endTime();

            end.elapsedTime();

            MessageBox.Show(end.elapsedTime());
        }
    }
}
