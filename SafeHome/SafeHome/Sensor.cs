using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHome
{
    public class Sensor
    {
        int SensorTypeID;
        int RoomID;

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

        public Sensor() { }

        public Sensor(int typeID, int rmID)
        {
            this.SensorTypeID1 = typeID;
            this.RoomID1 = rmID;
        }

        public bool alert ()
        {
            return true;
        }
    }
}
