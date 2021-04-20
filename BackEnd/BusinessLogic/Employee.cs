using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	class Employee
	{
		private int empID;
		private string empName;
		private string empSurname;
		private string phone;
		private string email;
		private string postalAddress;
		private string resAddress;
		private DateTime hireDate;
		private int empJob;
		private int leaveDays;
		private string maritalStatus;

		public Employee()
		{

		}

		public Employee(int empID, string empName, string empSurname, string phone, string email, string postalAddress, string resAddress, DateTime hireDate, int empJob, int leaveDays, string maritalStatus)
		{
			this.empID = empID;
			this.empName = empName;
			this.empSurname = empSurname;
			this.phone = phone;
			this.email = email;
			this.postalAddress = postalAddress;
			this.resAddress = resAddress;
			this.hireDate = hireDate;
			this.empJob = empJob;
			this.leaveDays = leaveDays;
			this.maritalStatus = maritalStatus;
		}

		public string MaritalStatus
		{
			get { return maritalStatus; }
			set { maritalStatus = value; }
		}


		public int LeaveDays
		{
			get { return leaveDays; }
			set { leaveDays = value; }
		}


		public int EmpJob
		{
			get { return empJob; }
			set { empJob = value; }
		}


		public DateTime HireDate
		{
			get { return hireDate; }
			set { hireDate = value; }
		}


		public string ResAddress
		{
			get { return resAddress; }
			set { resAddress = value; }
		}


		public string PostalAddress
		{
			get { return postalAddress; }
			set { postalAddress = value; }
		}


		public string Email
		{
			get { return email; }
			set { email = value; }
		}


		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}


		public string EmpSurname
		{
			get { return empSurname; }
			set { empSurname = value; }
		}


		public string EmpName
		{
			get { return empName; }
			set { empName = value; }
		}


		public int EmpID
		{
			get { return empID; }
			set { empID = value; }
		}

		public override string ToString()
		{
			return base.ToString();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

	}
}
