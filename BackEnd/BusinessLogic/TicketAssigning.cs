using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccess;

namespace BusinessLogic
{
    enum ContractScore
    {
        D = 1,
        C,
        B,
        A
    }
    public class TicketAssigning
    {
        public static void assignTicket(string ticketID)
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

            AvalibleTechnicians = handler.SelectTicketsAndSatisfactionScore(neededScore);

            try
            {
                //DataRow employee = AvalibleTechnicians.Rows[0];
                string empID = AvalibleTechnicians.Rows[0][0].ToString();
                handler.InsertTechnicianSchedule(empID, ticketID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            

            
        }
    }
}
