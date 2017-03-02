using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SafeHome;

namespace SafeHomeWebsite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName != null && txtPwd != null)
            {
                Customer c = DBConnection.db_Login(txtUserName.Text, txtPwd.Text);
                if (c != null)
                {
                    Session["CustomerSession"] = c;
                    Response.Redirect("~/Home");
                }
                else
                {
                    lblLogin.Text = "User not found. Please check your details.";
                }
            }
            else
            {
                lblLogin.Text = "Please enter your username and password.";
            }
        }
    }
}