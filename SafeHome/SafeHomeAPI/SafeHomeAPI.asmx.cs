using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SafeHomeAPI
{
    /// <summary>
    /// API for Website and Sensor emulator to use to create events on the system
    /// </summary>
    [WebService(Namespace = "http://www.safehome-gre.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SafeHomeAPI : System.Web.Services.WebService
    {
        private static SafeHomeEntities dataContext = new SafeHomeEntities();

        [WebMethod]
        public static string HelloWorld()
        {
            return "Hello world";
        }

        [WebMethod]
        public static string GetSystemState(PDC_Customer c)
        {
            var cust = (from customer in dataContext.PDC_Customer
                        where customer.CustomerID == c.CustomerID
                        select customer).First();
            return cust.SystemState;
        }

        [WebMethod]
        public static List<PDC_SensorEvent> GetSensorEvents(PDC_Customer c)
        {
            List<PDC_Sensor> sensors = new List<PDC_Sensor>();
            List<PDC_SensorEvent> events = new List<PDC_SensorEvent>();
            List<PDC_Room> rooms = (from room in dataContext.PDC_Room
                                    where room.CustomerID == c.CustomerID
                                    select room).ToList();
            foreach (PDC_Room r in rooms)
            {
                List<PDC_Sensor> sen = (from s in dataContext.PDC_Sensor
                                        where s.RoomID == r.RoomID
                                        select s).ToList();
                foreach (PDC_Sensor sens in sen)
                {
                    sensors.Add(sens);
                }
            }
            foreach (PDC_Sensor s in sensors)
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
