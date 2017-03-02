using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SafeHome;
using SafeHomeWebsite.Models;

namespace SafeHomeWebsite
{
    public partial class Home : System.Web.UI.Page
    {
        SafeHomeAPIService.SafeHomeAPI safehomeSystem = new SafeHomeAPIService.SafeHomeAPI();
        Customer c = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerSession"] != null)
            {
                c = (Customer)Session["CustomerSession"];
                lblWelcome.Text = "Welcome, " + c.UserName1 + "!";
                lblSystemStatus.Text = safehomeSystem.GetSystemState(c.CustomerID1);
                populateTable();
            }
            else
            {
                Session.Clear();
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnDisarm_Click(object sender, EventArgs e)
        {
            safehomeSystem.DeactivateSystem(c.CustomerID1);
        }

        protected void btnArm_Click(object sender, EventArgs e)
        {
            safehomeSystem.ActivateSystem(c.CustomerID1);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            safehomeSystem.RestartSystem(c.CustomerID1);
        }

        public void populateTable()
        {
            List<EventsForTable> tblEvents = new List<EventsForTable>();
            List<Room> rooms = DBConnection.db_GetAllRooms(c.CustomerID1);
            SafeHomeAPIService.SensorEvent[] events = safehomeSystem.GetSensorEvents(c.CustomerID1);
            foreach (SafeHomeAPIService.SensorEvent se in events)
            {
                EventsForTable et = new EventsForTable();
                et.Time = se.EventTime1;
                et.EventID = se.EventID1;
                et.Detail = se.Detail1;
                //TODO find room name and sensor type
                gvEvents.DataSource = tblEvents;
                gvEvents.DataBind();
            }
        }
    }
}