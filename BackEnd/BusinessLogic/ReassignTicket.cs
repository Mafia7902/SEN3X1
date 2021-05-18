using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccess;

namespace BackEnd.BusinessLogic
{
    enum ContractScore
    {
        D = 1,
        C,
        B,
        A
    }
    public class ReassignTicket
    {
        public void assignTicket(string ticketID, int employeeID)
        {
            DataHandler handler = new DataHandler();
            string contractID = "";
            int neededScore = 1;

            DataTable contractType;

            DataTable AvalibleTechnicians;

            contractType = handler.SelectUncompletedTickets(ticketID);
            foreach (DataRow row in contractType.Rows)
            {
                contractID = row["ContractID"].ToString();
                contractID = contractID.Substring(5, 1);
            }

            switch (contractID)
            {
                case "A":
                    {
                        neededScore = (int)ContractScore.A;
                        break;
                    }
                case "B":
                    {
                        neededScore = (int)ContractScore.B;
                        break;
                    }
                case "C":
                    {
                        neededScore = (int)ContractScore.C;
                        break;
                    }
                case "D":
                    {
                        neededScore = (int)ContractScore.D;
                        break;
                    }
            }

            AvalibleTechnicians = handler.SelectAvailableTechnician(neededScore, employeeID);

            try
            {
                //DataRow employee = AvalibleTechnicians.Rows[0];
                int empID = Int32.Parse(AvalibleTechnicians.Rows[0][0].ToString());
                handler.UpdateTechnicianSchedule(empID, ticketID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
