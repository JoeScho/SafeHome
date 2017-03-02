using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace API
{
    /// <summary>
    /// API for SafeHome users. To be consumed by the website and sensor emulator.
    /// </summary>
    [WebService(Namespace = "http://www.safehome-gre.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SafeHomeAPI : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetSystemState(int customerID)
        {            
            try
            {
                string state = DBConnection.checkSystemStatus(customerID);
                return state;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

        [WebMethod]
        public List<SensorEvent> GetSensorEvents(int customerID)
        {
            try
            {
                List<SensorEvent> events = DBConnection.getEvents(customerID);
                return events;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }
    }
}
