using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API
{
    public class SensorEvent
    {
        DateTime EventTime;
        int EventID;        
        string RoomName;
        string SensorType;        
        string Detail;

        public int EventID1
        {
            get
            {
                return EventID;
            }

            set
            {
                EventID = value;
            }
        }

        public string RoomName1
        {
            get
            {
                return RoomName;
            }

            set
            {
                RoomName = value;
            }
        }

        public string SensorType1
        {
            get
            {
                return SensorType;
            }

            set
            {
                SensorType = value;
            }
        }

        public string Detail1
        {
            get
            {
                return Detail;
            }

            set
            {
                Detail = value;
            }
        }

        public DateTime EventTime1
        {
            get
            {
                return EventTime;
            }

            set
            {
                EventTime = value;
            }
        }

        public SensorEvent() { }

        public SensorEvent(DateTime time, int EvID, string rmName, string snsType, string details)
        {
            this.EventTime1 = time;
            this.EventID1 = EvID;            
            this.RoomName1 = rmName;
            this.SensorType1 = snsType;
            this.Detail1 = details;
        }
    }
}