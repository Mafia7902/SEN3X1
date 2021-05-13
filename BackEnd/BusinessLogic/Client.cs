using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessLogic
{
    public class Client
    {
        private string clientID;
        private string name;
        private string surname;
        private string phone;
        private string email;
        private int clientType;
        private string physicalAddress;
        private string unitNumber;
        private string suburb;
        private string postalcode;
        private string province;
        private string contractID;
        private string bankDetails;
       
       


        public Client()
        {

        }

        public Client(string clientID, string name, string surname, string phone, string email, int clientType, string physicalAddress, string suburb, string postalcode
            , string province, string contractID, string bankDetails, string unitNumber )
        {
            this.clientID = clientID;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.clientType = clientType;
            this.physicalAddress = physicalAddress;
            this.surname = surname;
            this.suburb = suburb;
            this.postalcode = postalcode;
            this.province = province;
            this.contractID = contractID;
            this.bankDetails = bankDetails;
            this.unitNumber = unitNumber;

        }

        public string UnitNumber
        {
            get { return unitNumber; }
            set { unitNumber= value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        public string PostalCode
        {
            get { return postalcode; }
            set { postalcode = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }

        public string BankDetails
        {
            get { return bankDetails; }
            set { bankDetails = value; }
        }
  
        public string PhysicalAddress
        {
            get { return physicalAddress; }
            set { physicalAddress = value; }
        }

        public int ClientType
        {
            get { return clientType; }
            set { clientType = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        private string IDGenV1()
        {
            #region Notes
            /*
             * So this method basically generates 2 sets of numbers that has 4 characters each (padding applied if needed).
             * It also selects a random letter between A and E, and adds it to the left of the other 2 strings  and there you should
             * have a new ID. Now we can call this Private method into another method that checks if the ID doesn't already exist.
             * Or we just copy-paste this bit of code into the method that will inevitably be of a recursive nature...
             * - Albert Wolfaardt
             */
            #endregion
            Random random = new Random();
            string numSet1 = random.Next(10000).ToString().PadLeft(4, '0');
            string numSet2 = random.Next(10000).ToString().PadLeft(4, '0');
            char letter = (char)('a' + random.Next(0, 5));
            string newID = letter.ToString().ToUpper() + numSet1 + numSet2;
            return newID;
        }

        //private string IDGenV2()
        //{
        //    //Uses a Do-While loop to individually add the numeric values
        //    //My personal favorite because it makes more sense to me, but both work as intended
        //    //Might get merged with the AddNewClient() method...
        //    //- Albert Wolfaardt
        //    string newID = "";
        //    Random random = new Random();
        //    do
        //    {
        //        newID += random.Next(10).ToString();
        //    } while (newID.Length != 8);
        //    char letter = (char)('a' + random.Next(0, 5));
        //    newID = letter.ToString().ToUpper() + newID;
        //    return newID;
        //}

        public void AddNewClient(string clientName, string clientSurname, string phone, string email, string streetAddress, string suburb, string postalCode, string province, string contractID, int clientType, string bankDetails, string unitNumber = null)
        {
            string newID = IDGenV1();
            DataHandler dh = new DataHandler();
            
            if (dh.ClientIDChecker(newID) == true)
            {
                AddNewClient(clientName, clientSurname, phone, email, streetAddress, suburb, postalCode, province, contractID, clientType, bankDetails, unitNumber);
            }
            else
            {
                dh.InsertClient(newID, clientName, clientSurname, phone, email, streetAddress, suburb, postalCode, province, contractID, clientType, bankDetails, unitNumber);
            }
        }

        public DataTable searchClient(string email)
        {
            DataHandler dh = new DataHandler();
            return dh.SelectClient(email);
        }

        public DataTable searchClientDetails(string email)
        {
            DataHandler dh = new DataHandler();
            return dh.SelectClientDetails(email);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //Existing customer
        public DataTable dg1(string email)
        {
            DataTable mytbl = new DataTable();
            mytbl = new DataHandler().SelectClient(email);
            return mytbl;
        }

        //ClientMaintanance
        public DataTable dg2(string email)
        {
            DataTable mytbl = new DataTable();
            mytbl = new DataHandler().SelectClientDetails(email);
            return mytbl;
        }

        public DataTable dg3(string email)
        {
            DataTable mytbl = new DataTable();
            mytbl = new DataHandler().ClientTreeView();
            return mytbl;
        }

        public void updateClient(string clientID, string clientName, string clientSurname, string email, string suburb, string postalCode,
           string province, string streetAddress, string phone, string contractID, int clientType, string bankDetails, string unitNumber = null)
        {
            DataHandler dh = new DataHandler();
            dh.UpdateClient(clientID ,clientName, clientSurname, email, suburb, postalCode, province, streetAddress, phone, contractID, 
                clientType, bankDetails, unitNumber);
        }
       
    }
}

