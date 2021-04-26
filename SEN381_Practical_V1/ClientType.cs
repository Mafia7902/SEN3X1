using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Practical_V1
{
    class ClientType
    {
        private int clientType;
        private string clientDescription;

        public ClientType(int clientType, string clientDescription)
        {
            this.clientType = clientType;
            this.clientDescription = clientDescription;
        }
        public ClientType()
        {

        }

        public string ClientDescription
        {
            get { return clientDescription; }
            set { clientDescription = value; }
        }

        public int ClienType
        {
            get { return clientType; }
            set { clientType = value; }
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
