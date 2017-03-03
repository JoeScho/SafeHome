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
                clearTable();
                if (lblSystemStatus.Text == "Alert")
                {
                    populateTable();
                }                
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
            lblSystemStatus.Text = safehomeSystem.GetSystemState(c.CustomerID1);
            clearTable();
        }

        protected void btnArm_Click(object sender, EventArgs e)
        {
            safehomeSystem.ActivateSystem(c.CustomerID1);
            lblSystemStatus.Text = safehomeSystem.GetSystemState(c.CustomerID1);
            clearTable();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            safehomeSystem.RestartSystem(c.CustomerID1);
            lblSystemStatus.Text = safehomeSystem.GetSystemState(c.CustomerID1);
            clearTable();
        }

        public void populateTable()
        {
            SafeHomeAPIService.SensorEvent[] events = safehomeSystem.GetSensorEvents(c.CustomerID1);            
            if (events != null)
            {
                List<SafeHomeAPIService.SensorEvent> tblEvents = events.ToList();
                gvEvents.DataSource = tblEvents;
                gvEvents.DataBind();             
            }
            else
            {
                lblNoEvents.Text = "No events found";
            }
        }

        public void clearTable()
        {
            gvEvents.DataSource = null;
            gvEvents.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Default.aspx");
        }
    }
}