using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.BusinessLogic
{
    public class ContratTypeToID
    {
        
        public string ContractType(string contractType)
        {
            string contractID="";
            switch (contractType)
            {
                case "Platinum":
                    {
                        contractID = "A";
                        break;
                    }
                case "Gold":
                    {
                        contractID = "B";
                        break;
                    }
                case "Silver":
                    {
                        contractID = "C";
                        break;
                    }
                case "Bronze":
                    {
                        contractID = "D";
                        break;
                    }
            }
            return contractID;

        }

    }
}
