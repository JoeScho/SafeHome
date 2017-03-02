using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeHomeWebsite.Models
{
    public class EventsForTable
    {
        int eventID;
        string roomName;
        string sensorType;
        DateTime time;
        string detail;

        public EventsForTable() { }

        public EventsForTable(int id, string rmName, string snsType, DateTime dttm, string detail)
        {
            this.eventID = id;
            this.roomName = rmName;
            this.sensorType = snsType;
            this.time = dttm;
            this.detail = detail;
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

        public DateTime Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
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
    }
}