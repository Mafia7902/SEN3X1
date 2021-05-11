using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClinetMaintance
{
    public partial class ClientMaintanance : Form
    {
        public ClientMaintanance()
        {
            InitializeComponent();
        }
       

        public string FirstName;
        public string LastName;
        public int Phone;
        public string Email;
        public string StreetAddress;
        public string Suburb;
        public int UnitNumber;
        public int PostalCode;
        public string Province;
        public string ProblemDescription;

        public string firstname { get { return FirstName; } set { FirstName = value; } }
        public string lastName { get { return LastName; } set { LastName = value; } }
        public int phone { get { return Phone; } set { Phone = value; } }
        public string email { get { return Email; } set { Email = value; } }
        public string streetAddress { get { return StreetAddress; } set { StreetAddress = value; } }
        public string suburb { get { return Suburb; } set { Suburb = value; } }
        public int unitNumber { get { return UnitNumber; } set { UnitNumber = value; } }
        public int postalCode { get { return PostalCode; } set { PostalCode = value; } }
        public string province { get { return Province; } set { Province = value; } }
        public string problemDescription { get { return ProblemDescription; } set { ProblemDescription = value; } }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Text = FirstName;
            txtSurname.Text = LastName;
            txtPhone.Text = Phone.ToString();
            txtEmail.Text = Email;
            txtAddress.Text = StreetAddress;
            txtSuburb.Text = Suburb;
            txtUnitNumber.Text = UnitNumber.ToString();
            txtPostalCode.Text = PostalCode.ToString();
            txtProvince.Text = Province;
            txtProblemDesc.Text = ProblemDescription;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
