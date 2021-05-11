using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLogic
{
    public class EmployeeLogin
    {
        string EmpUser;
        string Password;
        private int empID;
        private string jobID;

        public static int EmpID { get; set ; }
        public static string JobID { get; set; }

        public EmployeeLogin()
        {

        }

        public void VerifyUser(string empUserName, string empPassword)
        {
            DataTable table;
            DataAccess.DataHandler handler = new DataAccess.DataHandler();
            try
            {
                table = handler.LoginCheck(empUserName, empPassword);
                foreach (DataRow item in table.Rows)
                {
                    EmpID = Int32.Parse(item["EmpID"].ToString());
                    JobID = item["JobID"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("no user exists: " + e.ToString());
            }
            
        }


    }
}
