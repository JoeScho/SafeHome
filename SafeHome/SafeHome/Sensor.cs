using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHome
{
    public class Sensor
    {
        // Like this for now but once DB connection secured then get from SensorType table
        string[] types = new string[5] {"Door / Window Contact", "Movement", "Fire", "Breaking Glass", "Vibration"};

        int SensorID;
        int SensorTypeID;
        int RoomID;

        public bool alert ()
        {
            return true;
        }

        public int getSensorIDByType (string sensorType)
        {
            // SELECT SensorTypeID FROM SensorType WHERE SensorName ='" + sensorType + "'";
            return 1;
        }
    }
}
