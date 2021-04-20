using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ProblemDetails
    {
        private int problemID;
        private string problemDescription;

        public ProblemDetails(int problemID, string problemDescription)
        {
            this.problemID = problemID;
            this.problemDescription = problemDescription;
        }

        public string ProblemDescription
        {
            get { return problemDescription; }
            set { problemDescription = value; }
        }

        public int ProblemID
        {
            get { return problemID; }
            set { problemID = value; }
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
