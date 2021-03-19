using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G9testThing
{
    class Ticket : Call
    {
        private int ticketID;
        private int clientID;
        private int technicianID;// Renamed EmpID to TechnicianID for clarity
        private int clientSatisfaction;
        private bool completed;
        private DateTime dateCompleted;
        private DateTime dateStarted;

        public Ticket()
        {

        }

        public Ticket(int callCenterEmpID, string callCenterEmpFullName, int clientID) : base(callCenterEmpID, callCenterEmpFullName, clientID)
        {
        }

        public Ticket(int ticketID, int clientID, int technicianID, int clientSatisfaction, bool completed, DateTime dateCompleted, DateTime dateStarted)
        {
            this.ticketID = ticketID;
            this.clientID = clientID;
            this.technicianID = technicianID;
            this.clientSatisfaction = clientSatisfaction;
            this.completed = completed;
            this.dateCompleted = dateCompleted;
            this.dateStarted = dateStarted;
        }

        public DateTime DateStarted
        {
            get { return dateStarted; }
            set { dateStarted = value; }
        }

        public DateTime DateCompleted
        {
            get { return dateCompleted; }
            set { dateCompleted = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        public int ClientSatisfaction
        {
            get { return clientSatisfaction; }
            set { clientSatisfaction = value; }
        }

        public int TechnicianID
        {
            get { return technicianID; }
            set { technicianID = value; }
        }

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }


        public int TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }

        public Ticket createTicket(int ClientID)
        {
            //TODO add logic
            Ticket ticket = new Ticket();
            return ticket;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
