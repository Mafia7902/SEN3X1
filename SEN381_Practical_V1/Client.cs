using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Practical_V1
{
    class Client
    {
        private int clientID;
        private string name;
        private string phone;
        private string email;
        private List<Call> callhistory;
        private int clientType;
        private string physicalAddress;

        public Client()
        {

        }

        public Client(int clientID, string name, string phone, string email, List<Call> callhistory, int clientType, string physicalAddress)
        {
            this.clientID = clientID;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.callhistory = callhistory;
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

        public List<Call> CallHistory
        {
            get { return callhistory; }
            set { callhistory = value; }
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

        public List<Call> GetPastCalls(int clientID)
        {
            List<Call> calls = new List<Call>();
            return calls;
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
