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

        public SensorEvent() { }

        public SensorEvent(DateTime time, int EvID, string rmName, string snsType, string details)
        {
            this.EventTime = time;
            this.EventID = EvID;            
            this.RoomName = rmName;
            this.SensorType = snsType;
            this.Detail = details;
        }
    }
}