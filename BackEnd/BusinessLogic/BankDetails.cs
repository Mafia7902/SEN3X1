using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic
{
    public class BankDetails
    {
        private int bankDetailsID;
        private string paymentType;
        private string branchNum;
        private string bankName;
        private string accountNum;
        

        public BankDetails(int bankDetailsID, string paymentType, string branchNum, string bankName, string accountNum)
        {
            this.bankDetailsID = bankDetailsID;
            this.paymentType = paymentType;
            this.branchNum = branchNum;
            this.bankName = bankName;
            this.accountNum = accountNum;
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
        public string AccountNumber
        {
            get { return accountNum; }
            set { accountNum = value; }
        }

        public void AddBankDetails(string bankID, string paymentType, string branchNum, string bankName, string accountNum ) {
            DataHandler dh = new DataHandler();
            dh.InsertBankDetails(bankID, paymentType, bankName, branchNum, accountNum);
           
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

        public void updateBankDetails(string bankDetailsID, string paymentType, string bankname, string branchNum, string accountNum)
        {
            DataHandler dh = new DataHandler();
            dh.UpdateBankDetails(bankDetailsID, paymentType, bankname, branchNum, accountNum);
        }

    }
}
