using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G9testThing
{
    class BankDetails
    {
        private int bankDetailsID;
        private string paymentType;
        private string branchNum;
        private string bankName;

        public BankDetails(int bankDetailsID, string paymentType, string branchNum, string bankName)
        {
            this.bankDetailsID = bankDetailsID;
            this.paymentType = paymentType;
            this.branchNum = branchNum;
            this.bankName = bankName;
        }

        public BankDetails()
        {

        }

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        public string BranchNum
        {
            get { return branchNum; }
            set { branchNum = value; }
        }

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

        public int BankDetailsID
        {
            get { return bankDetailsID; }
            set { bankDetailsID = value; }
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
