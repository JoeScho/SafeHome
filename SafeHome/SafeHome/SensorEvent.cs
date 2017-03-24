using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeHome
{
    public class SensorEvent
    {
        DateTime eventTime;
        int eventID;
        string roomName;
        string sensorType;
        string detail;

        public DateTime EventTime
        {
            get
            {
                return eventTime;
            }

            set
            {
                eventTime = value;
            }
        }

        public int EventID
        {
            get
            {
                return eventID;
            }

            set
            {
                eventID = value;
            }
        }

        public string RoomName
        {
            get
            {
                return roomName;
            }

            set
            {
                roomName = value;
            }
        }

        public string SensorType
        {
            get
            {
                return sensorType;
            }

            set
            {
                sensorType = value;
            }
        }

        public string Detail
        {
            get
            {
                return detail;
            }

            set
            {
                detail = value;
            }
        }

        public SensorEvent() { }
    }
}