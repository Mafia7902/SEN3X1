using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G9testThing
{
    class TechnicianSchedule
    {
        private int scheduleID;
        private List<Ticket> scheduleTicket;

        public List<Ticket> ScheduleTicket
        {
            get { return scheduleTicket; }
            set { scheduleTicket = value; }
        }

        public int ScheduleID
        {
            get { return scheduleID; }
            set { scheduleID = value; }
        }

        public List<Ticket> getScheduledTickets(int TechnicianID)
        {
            //TODO add logic
            List<Ticket> tickets = new List<Ticket>();
            return tickets;
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
