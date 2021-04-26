using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	class Job
	{
		private int jobID;
		private string jobName;
		private double salary;

		public Job()
		{

		}

		public Job(int jobID, string jobName, double salary)
		{
			this.jobID = jobID;
			this.jobName = jobName;
			this.salary = salary;
		}

		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}

		public string JobName
		{
			get { return jobName; }
			set { jobName = value; }
		}

		public int JobID
		{
			get { return jobID; }
			set { jobID = value; }
		}

		public double SetSalary()
        {
			double salary = 0;
			return salary;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override string ToString()
		{
			return base.ToString();
		}

	}
}
