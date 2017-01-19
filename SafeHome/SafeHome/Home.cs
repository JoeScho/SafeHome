using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SafeHome
{
    public partial class Home : Form
    {
        List<Panel> listPanels = new List<Panel>();
        Customer c = new Customer();
        SqlConnection myConnection = new SqlConnection("user id=Joe;" +
                                   "password=;server=localhost;" +
                                   "Trusted_Connection=yes;" +
                                   "database=database; " +
                                   "connection timeout=30");

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            listPanels.Add(pnlHome);
            listPanels.Add(pnlLogin);
            listPanels.Add(pnlViewRooms);
            listPanels.Add(pnlAddRoom);
            setAllPanelsInvisible();
            disableButtons();
            pnlLogin.Visible = true;
        }

        public Customer db_getCustomerDetails(string username, string password)
        {
            Customer selectedCustomer = new Customer();
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            SqlDataReader myReader = null;

            // Parameterise input to avoid SQL Injection
            SqlParameter paramUsername = new SqlParameter("@ParamUsername", SqlDbType.VarChar);
            paramUsername.Value = username;
            SqlParameter paramPwd = new SqlParameter("@ParamPwd", SqlDbType.VarChar);
            paramPwd.Value = password;

            SqlCommand myCommand = new SqlCommand(
                "SELECT * FROM Customer WHERE Username = @ParamUsername AND Password = @ParamPwd", myConnection);
            myCommand.Parameters.Add(paramUsername);
            myCommand.Parameters.Add(paramPwd);

            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    selectedCustomer.CustomerID1 = (int)myReader["Column1"];
                    selectedCustomer.UserName1 = myReader["Column2"].ToString();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return selectedCustomer;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            c = db_getCustomerDetails(txtLoginName.Text, txtLoginPwd.Text);
            if (c.UserName1 != "")
            {
                setAllPanelsInvisible();
                pnlHome.Visible = true;
                enableButtons();
            }
            else
            {
                lblLoginErr.Text = "Error logging in.";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlLogin.Visible = true;
            disableButtons();
        }

        public void setAllPanelsInvisible()
        {
            foreach (Panel p in listPanels)
            {
                p.Visible = false;
            }
        }

        public void enableButtons()
        {
            btnHome.Enabled = true;
            btnViewRooms.Enabled = true;
            btnLogout.Enabled = true;
        }

        public void disableButtons()
        {
            btnHome.Enabled = false;
            btnViewRooms.Enabled = false;
            btnLogout.Enabled = false;
        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlViewRooms.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlHome.Visible = true;
        }
    }
}
