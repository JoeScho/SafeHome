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
        List<Room> customerRooms = new List<Room>();
        Customer c = new Customer();
        int floor;
        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'safeHomeDataSet.PDC_Room' table. You can move, or remove it, as needed.
            this.pDC_RoomTableAdapter.Fill(this.safeHomeDataSet.PDC_Room);
            List<string> sensorTypes = DBConnection.getSensorTypes();
            foreach (string s in sensorTypes)
            {
                comboAddSensor.Items.Add(s);
            }
            listPanels.Add(pnlLogin);
            listPanels.Add(pnlViewRooms);
            listPanels.Add(pnlAddRoom);
            loadLoginPage();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            c = DBConnection.db_Login(txtLoginName.Text, txtLoginPwd.Text);
            if (c.UserName1 != "")
            {
                customerRooms = DBConnection.db_GetRooms(c.CustomerID1);
                loadViewPage();                
            }
            else
            {
                lblLoginErr.Text = "Error logging in.";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loadLoginPage();
            c = new Customer();
        }

        private void setAllPanelsInvisible()
        {
            foreach (Panel p in listPanels)
            {
                p.Visible = false;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {                
            try
            {
                floor = int.Parse(txtFloor.Text);
                loadAddPage();
            }     
            catch(Exception)
            {
                lblAddError.Text = "Please enter Floor no.";
            }                            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Room.getRoomByName(txtRoomName.Text, customerRooms) != null) {
                Room r = new Room(
                txtRoomName.Text,
                c.CustomerID1,
                floor,
                int.Parse(comboRoomN.SelectedValue.ToString()),
                checkDoorN.Checked,
                int.Parse(comboRoomE.SelectedValue.ToString()),
                checkDoorE.Checked,
                int.Parse(comboRoomS.SelectedValue.ToString()),
                checkDoorS.Checked,
                int.Parse(comboRoomW.SelectedValue.ToString()),
                checkDoorW.Checked
                );
                DBConnection.db_AddRoom(r);
                loadViewPage();
            }
            else
            {
                lblRegisterError.Text = "Error adding room.";
            }
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(DBConnection.db_Register(txtRegisterName.Text, txtRegisterPwd.Text))
            {
                txtRegisterName.Text = "";
                txtRegisterPwd.Text = "";
                lblRegisterError.Text = "Successfully registered.";
            }
            else
            {
                lblRegisterError.Text = "Error during registration.";
            }
        }

        public void loadLoginPage()
        {
            lblLoginErr.Text = "";
            lblRegisterError.Text = "";
            txtLoginName.Text = "";
            txtLoginPwd.Text = "";
            txtRegisterName.Text = "";
            txtRegisterPwd.Text = "";
            setAllPanelsInvisible();
            pnlLogin.Visible = true;
        }

        public void loadViewPage()
        {
            listboxRooms.Items.Clear();
            foreach (Room r in customerRooms)
            {
                listboxRooms.Items.Add(r.RoomName1);
            }
            lblAddError.Text = "";
            txtFloor.Text = "";
            setAllPanelsInvisible();
            pnlViewRooms.Visible = true;
        }

        public void loadAddPage()
        {
            txtRoomName.Text = "";
            checkDoorN.Checked = false;
            checkDoorE.Checked = false;
            checkDoorS.Checked = false;
            checkDoorW.Checked = false;
            // Add rooms to drop down lists            
            setAllPanelsInvisible();
            pnlAddRoom.Visible = true;            
        }

        private void btnViewRoom_Click(object sender, EventArgs e)
        {
            Room r = Room.getRoomByName(listboxRooms.SelectedItem.ToString(), customerRooms);
            txtRoomName.Text = r.RoomName1;
            loadAddPage();
        }
    }
}
