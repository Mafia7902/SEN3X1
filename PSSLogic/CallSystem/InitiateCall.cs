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

        DateTime StartTime;
        CallInformation CallInfo = new CallInformation();
        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            //// takes you to the LoginForm
            LoginV2.Login f1 = new LoginV2.Login();
            f1.Show();
            StartTime = DateTime.Now;

            CallInfo.startTime(StartTime);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elapsedTime = CallInfo.elapsedTime();
            MessageBox.Show(elapsedTime);
        }
    }
}
