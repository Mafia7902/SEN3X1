using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.BusinessLogic
{
    public class ContratTypeToID
    {
        private string contractID;
   

        public  string ContractID { get { return contractID; } set {contractID = value; } }

        public string ContractType(string contractType)
        {
            string ContractTypeID="";
            switch (contractType)
            {
                case "Platinum":
                    {
                        ContractTypeID = "A";
                        ContractID = "A";
                        break;
                    }
                case "Gold":
                    {
                        ContractTypeID = "B";
                        ContractID = "B";
                        break;
                    }
                case "Silver":
                    {
                        ContractTypeID = "C"; 
                        ContractID = "C";
                        break;
                    }
                case "Bronze":
                    {
                        ContractTypeID = "D";
                        ContractID = "D";
                        break;
                    }
            }
            return ContractTypeID;

        }

    }
}
