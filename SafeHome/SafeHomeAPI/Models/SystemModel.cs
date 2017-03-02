using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeHomeAPI.Models
{
    public class SystemModel
    {
        private static SafeHomeEntities dataContext = new SafeHomeEntities();

        public static string GetSystemState(PDC_Customer c)
        {
            var cust = (from customer in dataContext.PDC_Customer
                       where customer.CustomerID == c.CustomerID
                       select customer).First();
            return cust.SystemState;
        }

        public static List<PDC_SensorEvent> GetSensorEvents(PDC_Customer c)
        {
            List<PDC_Sensor> sensors = new List<PDC_Sensor>();
            List<PDC_SensorEvent> events = new List<PDC_SensorEvent>();
            List<PDC_Room> rooms = (from room in dataContext.PDC_Room
                                    where room.CustomerID == c.CustomerID
                                    select room).ToList();
            foreach(PDC_Room r in rooms)
            {
                List<PDC_Sensor> sen = (from s in dataContext.PDC_Sensor
                                        where s.RoomID == r.RoomID
                                        select s).ToList();
                foreach (PDC_Sensor sens in sen)
                {
                    sensors.Add(sens);
                }                
            }
            foreach(PDC_Sensor s in sensors)
            {
                List<PDC_SensorEvent> ev = (from e in dataContext.PDC_SensorEvent
                                            where e.SensorID == s.SensorID
                                            select e).ToList();
                foreach (PDC_SensorEvent e in ev)
                {
                    events.Add(e);
                }
            }
            return events;
        }
    }
}