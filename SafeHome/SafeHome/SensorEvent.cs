using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeHome
{
    public class SensorEvent
    {
        int EventID;
        int SensorID;
        DateTime EventTime;
        string Detail;

        public SensorEvent() { }

        public SensorEvent(int sID, DateTime time, string details)
        {
            this.SensorID = sID;
            this.EventTime = time;
            this.Detail = details;
        }

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
    }
}