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
using SensorEmulator;

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
        string[] typeOfSensor = new string[5] { "Door / Window Contact", "Movement", "Fire", "Breaking Glass", "Vibration" };

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            listPanels.Add(pnlLogin);
            listPanels.Add(pnlViewRooms);
            listPanels.Add(pnlAddRoom);
            setAllPanelsInvisible();
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
            //c = db_getCustomerDetails(txtLoginName.Text, txtLoginPwd.Text);
            //if (c.UserName1 != "")
            //{
                setAllPanelsInvisible();
                pnlViewRooms.Visible = true;
            //}
            //else
            //{
            //    lblLoginErr.Text = "Error logging in.";
            //}
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlLogin.Visible = true;
        }

        public void setAllPanelsInvisible()
        {
            foreach (Panel p in listPanels)
            {
                p.Visible = false;
            }
        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlViewRooms.Visible = true;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            setAllPanelsInvisible();
            pnlAddRoom.Visible = true;
            comboAddSensor.DataSource = typeOfSensor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.RoomName1 = txtRoomName.Text;
            r.CustomerID1 = c.CustomerID1;
            if (comboRoomN.SelectedText != "None")
            {
                r.RoomIDNorth1 = Room.getRoomByName(comboRoomN.SelectedText);
                if (checkDoorN.Checked)
                {
                    r.DoorNorth1 = true;
                }
            }
            if (comboRoomE.SelectedText != "None")
            {
                r.RoomIDEast1 = Room.getRoomByName(comboRoomE.SelectedText);
                if (checkDoorE.Checked)
                {
                    r.DoorEast1 = true;
                }
            }
            if (comboRoomS.SelectedText != "None")
            {
                r.RoomIDSouth1 = Room.getRoomByName(comboRoomS.SelectedText);
                if (checkDoorS.Checked)
                {
                    r.DoorSouth1 = true;
                }
            }
            if (comboRoomW.SelectedText != "None")
            {
                r.RoomIDWest1 = Room.getRoomByName(comboRoomW.SelectedText);
                if (checkDoorW.Checked)
                {
                    r.DoorWest1 = true;
                }
            }
            // INSERT INTO Room VALUES ( all values entered )
            setAllPanelsInvisible();
            pnlViewRooms.Visible = true;
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            string s = comboAddSensor.Text;
            lbSensors.Items.Add(s);
        }

        private void btnDeleteSensor_Click(object sender, EventArgs e)
        {
            lbSensors.Items.Remove(lbSensors.SelectedItem);
        }

        private void btnLaunchEmulator_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
