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

namespace CallCenter
{
    public partial class EndCall : Form
    {
        public EndCall()
        {
            InitializeComponent();
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            CallInformation end = new CallInformation();
            end.endTime();

            end.elapsedTime();

            MessageBox.Show(end.elapsedTime());
            
        }
    }
}
