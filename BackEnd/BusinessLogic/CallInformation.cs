using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace BackEnd.BusinessLogic
{
    public class CallInformation
    {

        private DateTime StartCall;

        public CallInformation()
        {

        }

        public DateTime StartCall1 { get => StartCall; set => StartCall = value; }

        //string sTime;
        public void startTime(DateTime sTime)
        {
            StartCall1 = sTime;
        }


        public string elapsedTime()
        {
            System.TimeSpan yx = DateTime.Now - StartCall1;
            return String.Format("{0}:{1}:{2}", yx.Hours, yx.Minutes, yx.Seconds);
        }
    }
}
