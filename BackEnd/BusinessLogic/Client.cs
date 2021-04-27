using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;

namespace BusinessLogic
{
    public class Client
    {
        private int clientID;
        private string name;
        private string phone;
        private string email;
        private int clientType;
        private string physicalAddress;

        public Client()
        {

        }

        public Client(int clientID, string name, string phone, string email, int clientType, string physicalAddress)
        {
            this.clientID = clientID;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.clientType = clientType;
            this.physicalAddress = physicalAddress;
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

        public int ClientID
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

    }
}
