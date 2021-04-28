using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace BusinessLogic
{
    public class Ticket
    {
        public Ticket()
        {

        }
        public string IDGenV2()
        {
            
            string newID = "";
            Random random = new Random();
            do
            {
                newID += random.Next(10).ToString();
            } while (newID.Length != 8);
            char letter = (char)('a' + random.Next(0, 5));
            newID = letter.ToString().ToUpper() + newID;
            return newID;
        }

        public void TicketInsert(string ticketID, string callId, string problemeDesc)
        {
            DataHandler dh = new DataHandler();
            dh.InsertTicket(ticketID, callId, problemeDesc);
        }

    }
}
