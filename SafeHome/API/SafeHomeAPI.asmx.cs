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

        [WebMethod]
        public string DeactivateSystem(int customerID)
        {
            try
            {
                DBConnection.SetSystemStatus(customerID, "Off");
                return "Successfully deactivated the system.";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return "Could not deactivate the system.";
            }
        }

        [WebMethod]
        public string ActivateSystem(int customerID)
        {
            try
            {
                DBConnection.SetSystemStatus(customerID, "Armed");
                DBConnection.SetArmTime(customerID);
                return "Successfully activated the system.";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return "Could not activate the system.";
            }
        }

        [WebMethod]
        public string RestartSystem(int customerID)
        {
            try
            {
                DeactivateSystem(customerID);
                ActivateSystem(customerID);
                return "Successfully restarted the system.";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return "Could not restart the system.";
            }
        }

        [WebMethod]
        public string SubmitReading(int customerID, int sensorID, string detail)
        {
            try
            {
                string state = DBConnection.checkSystemStatus(customerID);
                if (state != "Off")
                {
                    DBConnection.submitSensorReading(sensorID, detail);
                    DBConnection.SetSystemStatus(customerID, "Alert");
                    return "Reading submitted.";
                }
                else
                {
                    return "System is not activated.";
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return "Could not submit the reading.";
            }
        }
    }
}
