using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class Contract
    {
        private string contractID;
        private string contractType;
        private string contractDescription;
        private float price;

        public Contract()
        {

        }

        public Contract(string contractID, string contractType, string contractDescription, float price)
        {
            this.contractID = contractID;
            this.contractType = contractType;
            this.contractDescription = contractDescription;
            this.price = price;
        }

        public float Price
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

        public string ContractID
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

        public void contractInsert(string contractID, string contractType, string contractDesc, float price, string deviceID, int isActive)
        {
            DataHandler dh = new DataHandler();
            dh.InsertContract(contractID, contractType, contractDesc, price, deviceID, isActive);
        }
        public  void newStates(int newState, string contractID)
        {
            DataHandler dh = new DataHandler();
            dh.UpdateContractState(newState, contractID);
        }

    }
}
