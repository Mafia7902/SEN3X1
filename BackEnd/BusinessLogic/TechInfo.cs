using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DataAccess;

namespace BusinessLogic
{
   public class TechInfo
    {
        private string clientFName;
        private string clientLName;
        private string clientType;
        private string ticketNum;
        private string probDesc;
        private string unitNum;
        private string streetAdd;
        private string suburb;
        private string clientEmail;
        private string clientPhone;

        public TechInfo()
        {

        }

        public TechInfo(string clientFName, string clientLName, string clientType, string ticketNum, string probDesc, string unitNum, string streetAdd, string suburb, string clientEmail, string clientPhone)
        {
            this.clientFName = clientFName;
            this.clientLName = clientLName;
            this.clientType = clientType;
            this.ticketNum = ticketNum;
            this.probDesc = probDesc;
            this.unitNum = unitNum;
            this.streetAdd = streetAdd;
            this.suburb = suburb;
            this.clientEmail = clientEmail;
            this.clientPhone = clientPhone;
        }

        public string ClientPhone
        {
            get { return clientPhone; }
            set { clientPhone = value; }
        }


        public string ClientEmail
        {
            get { return clientEmail; }
            set { clientEmail = value; }
        }


        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }


        public string StreetAdd
        {
            get { return streetAdd; }
            set { streetAdd = value; }
        }



        public string UnitNum
        {
            get { return unitNum; }
            set { unitNum = value; }
        }



        public string ProbDesc
        {
            get { return probDesc; }
            set { probDesc = value; }
        }


        public string TickeNumber
        {
            get { return ticketNum; }
            set { ticketNum = value; }
        }


        public string ClientType
        {
            get { return clientType; }
            set { clientType = value; }
        }

        public string ClientLast
        {
            get { return clientLName; }
            set { clientLName = value; }
        }


        public string ClientFirst
        {
            get { return clientFName; }
            set { clientFName = value; }
        }

        public DataTable dg1(int id)
        {
            DataTable mytbl = new DataTable();
            mytbl = new DataHandler().SelectTechnicianView1(id);
            return mytbl;
        }

        public DataTable dg2(int id)
        {
            DataTable mytbl = new DataTable();
            mytbl = new DataHandler().SelectTechnicianView2(id);
            return mytbl;
        }

        // Testing inserting data into the DGV on FormSchedule
        /*public DataTable myTestData(int id)
        {
            DataTable mytbl = new DataTable();
            mytbl.Columns.Add("First Name", typeof(string));
            mytbl.Columns.Add("Last Name", typeof(string));
            mytbl.Columns.Add("Client Type", typeof(string));
            mytbl.Columns.Add("Ticket Number", typeof(string));
            mytbl.Columns.Add("Problem Description", typeof(string));

            mytbl.Rows.Add("Bob", "Builder", "Platinum", "A123", "Printer is busted");
            mytbl.Rows.Add("Luke", "Mross", "Gold", "B123", "Computer is slow");
            mytbl.Rows.Add("Tiaan", "Wolfaardt", "Silver", "C123", "Mouse is broken");
            mytbl.Rows.Add("Stefan", "Ferriera", "Bronze", "D123", "I forgot my wifi password");

            return mytbl;

        } */

    }
}
