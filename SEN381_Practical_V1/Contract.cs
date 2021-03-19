using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Practical_V1
{
    class Contract
    {
        private int contractID;
        private string contractType;
        private string contractDescription;
        private double price;

        public Contract()
        {

        }

        public Contract(int contractID, string contractType, string contractDescription, double price)
        {
            this.contractID = contractID;
            this.contractType = contractType;
            this.contractDescription = contractDescription;
            this.price = price;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string ContractDescription
        {
            get { return contractDescription; }
            set { contractDescription = value; }
        }

        public string ContractType
        {
            get { return contractType; }
            set { contractType = value; }
        }

        public int ContractID
        {
            get { return contractID; }
            set { contractID = value; }
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
