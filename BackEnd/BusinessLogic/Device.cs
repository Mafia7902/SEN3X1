using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace BusinessLogic
{
    public class Device
    {
        private string deviceID;
        private string manufacturer;
        private string model;

        public Device()
        {

        }
        public Device(string deviceID, string manufacturer, string model)
        {
            this.deviceID = deviceID;
            this.manufacturer = manufacturer;
            this.model = model;
            
        }


        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        public string Maufacturere
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public void deviceInsert(string deviceID, string manufacturer, string model)
        {
            DataHandler dh = new DataHandler();
            dh.InsertDevice(deviceID, manufacturer, model);
        }
    }
}
