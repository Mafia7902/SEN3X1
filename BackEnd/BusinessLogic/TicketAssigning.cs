using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BackEnd.BusinessLogic
{
    enum ContractScore
    {
        D = 1,
        C,
        B,
        A
    }
    class TicketAssigning
    {
        public void assignTicket(string ticketID)
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

            AvalibleTechnicians = handler.SelectTicketsAndSatisfactionScore(neededScore);

            DataRow employee = AvalibleTechnicians.Rows[0];

            string empID = employee["EmpID"].ToString();

            handler.InsertTechnicianSchedule(empID, ticketID);
        }
    }
}
