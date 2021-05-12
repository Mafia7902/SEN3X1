using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace BackEnd.BusinessLogic
{
    public class CallInformation
    {
        
        private string callStart;
        private string callEnd;

        public CallInformation()
        {

        }

        public CallInformation(string callStart, string callEnd)
        {
            this.callStart = callStart;
            this.callEnd = callEnd;
        }

        
        public string CallStart
        {
            get { return callStart; }
            set { callStart = value; }
        }

        public string CallEnd
        {
            get { return callEnd; }
            set { callEnd = value; }
        }

        string sTime;
        public string startTime()
        {
            var start = DateTime.Now;
            sTime = start.ToString();
            return sTime;
        }

        string eTime;
        public string endTime()
        {
            var end = DateTime.Now;
            eTime = end.ToString();
            return eTime;
        }

        public double elapsedTime()
        {
            TimeSpan duration = DateTime.Parse(eTime).Subtract(DateTime.Parse(sTime));
            double x = duration.TotalMinutes;
            return x;
        }
    }
}
