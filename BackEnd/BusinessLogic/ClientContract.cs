using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Data;
using BackEnd.BusinessLogic;

namespace BackEnd.BusinessLogic
{
    public class ClientContract
    {
        private string clientID;
        private string contractID;

        public string ClientID { get { return clientID; } set { clientID = value; } }
        public string ContractID { get { return contractID; } set { contractID = value; } }
         
        public ClientContract()
        {

        }

        public ClientContract(string clientID, string contractID)
        {
            this.clientID = clientID;
            this.contractID = contractID;
        }
        
        public void insertClientContract(string clientID, string contractID)
        {
            DataHandler dh = new DataHandler();
            dh.InsertClientContract(clientID, contractID);
        }
    }
   
}
