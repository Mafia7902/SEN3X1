using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G9testThing
{
	class Call : Employee
	{
		private int callCenterEmpID;
		private string callCenterEmpFullName;
		private int clientID;

		public Call()
		{

		}

		public Call(int callCenterEmpID, string callCenterEmpFullName, int clientID)
		{
			this.callCenterEmpID = callCenterEmpID;
			this.callCenterEmpFullName = callCenterEmpFullName;
			this.clientID = clientID;
		}

		public int ClientID
		{
			get { return clientID; }
			set { clientID = value; }
		}


		public string CallCenterEmpFullName
		{
			get { return callCenterEmpFullName; }
			set { callCenterEmpFullName = value; }
		}


		public int CallCenterEmpID
		{
			get { return callCenterEmpID; }
			set { callCenterEmpID = value; }
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
