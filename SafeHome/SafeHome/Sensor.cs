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
        public string SensorName;
        int RoomID;

        public int SensorID1
        {
            get
            {
                return SensorID;
            }

            set
            {
                SensorID = value;
            }
        }

        public int SensorTypeID1
        {
            get
            {
                return SensorTypeID;
            }

            set
            {
                SensorTypeID = value;
            }
        }

        public int RoomID1
        {
            get
            {
                return RoomID;
            }

            set
            {
                RoomID = value;
            }
        }

        public string SensorName1
        {
            get
            {
                return SensorName;
            }

            set
            {
                SensorName = value;
            }
        }

        public Sensor() { }

        public Sensor(int id, int typeID, string name, int rmID)
        {
            this.SensorID1 = id;
            this.SensorTypeID1 = typeID;
            this.SensorName1 = name;
            this.RoomID1 = rmID;
        }

        public bool alert ()
        {
            return true;
        }
    }
}
