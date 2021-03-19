using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G9testThing
{
    class Technician : Employee
    {
        private int empID;
        private double satisfactionScore;
        private List<Specialization> skillList;

        public Technician()
        {

        }

        public Technician(int empID, double satisfactionScore)
        {
            this.empID = empID;
            this.satisfactionScore = satisfactionScore;
        }

        public Technician(int empID, string empName, string empSurname, string phone, string email, string postalAddress, string resAddress, DateTime hireDate, int empJob, int leaveDays, string maritalStatus) : base(empID, empName, empSurname, phone, email, postalAddress, resAddress, hireDate, empJob, leaveDays, maritalStatus)
        {
        }

        public List<Specialization> SkillList
        {
            get { return skillList; }
            set { skillList = value; }
        }

        public double SatisfactionScore
        {
            get { return satisfactionScore; }
            set { satisfactionScore = value; }
        }

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public int[] assignTicket(Ticket ticket)
        {
            //TODO revisit this method and its intended logic, might be a smarter way to impliment the desired funtionality.
            int[] intarray = new int[1];
            return intarray;
        }

        public List<Specialization> GetSpecializations(int TechnicianID)
        {
            //TODO add logic
            List<Specialization> specializations = new List<Specialization>();
            return specializations;
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
