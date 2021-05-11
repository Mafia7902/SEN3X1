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

        Stopwatch stopwatch = new Stopwatch();
        public void startTime()
        {
            stopwatch.Start();
        }

        public void endTime()
        {
            stopwatch.Stop();
        }

        public string elapsedTime()
        {
            TimeSpan timeSpan = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
            timeSpan.Milliseconds / 10);
            return elapsedTime;
        }
    }
}
