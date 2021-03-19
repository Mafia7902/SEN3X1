using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G9testThing
{
    class Specialization
    {
        private int specID;
        private string specName;

        public Specialization()
        {

        }
        public Specialization(int specID, string specName)
        {
            this.specID = specID;
            this.specName = specName;
        }

        public string SpecName
        {
            get { return specName; }
            set { specName = value; }
        }

        public int SpecID
        {
            get { return specID; }
            set { specID = value; }
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
