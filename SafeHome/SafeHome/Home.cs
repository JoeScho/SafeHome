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
        List<Sensor> roomSensors = new List<Sensor>();
        List<SensorType> sensorTypes = DBConnection.getSensorTypes();
        Customer c = new Customer();
        int floor;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.pDC_RoomTableAdapter.Fill(this.safeHomeDataSet.PDC_Room);            
            foreach (SensorType s in sensorTypes)
            {
                comboAddSensor.Items.Add(s.SensorName1);
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
                List<Room> roomsOnFloor = new List<Room>();
                foreach (Room r in customerRooms)
                {
                    if (r.Floor1 == int.Parse(txtFloor.Text))
                    {
                        comboRoomN.Items.Add(r.RoomName1);
                        comboRoomE.Items.Add(r.RoomName1);
                        comboRoomS.Items.Add(r.RoomName1);
                        comboRoomW.Items.Add(r.RoomName1);
                    }
                }
            }
            catch (Exception)
            {
                lblAddError.Text = "Please enter Floor no.";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Room.getRoomByName(txtRoomName.Text, customerRooms) == null)
            {
                try
                {
                    // Add room to DB
                    int rmID = DBConnection.db_AddRoom(
                        txtRoomName.Text,
                        c.CustomerID1,
                        floor
                        );
                    try
                    {
                        // If adjacent rooms have been specified, update room details (includes updating other room)
                        if (comboRoomN.SelectedItem != null)
                        {
                            Room cbRoom = Room.getRoomByName(comboRoomN.SelectedItem.ToString(), customerRooms);
                            DBConnection.updateRoomN(rmID, cbRoom.RoomID1, checkDoorN.Checked);
                        }
                        if (comboRoomE.SelectedItem != null)
                        {
                            Room cbRoom = Room.getRoomByName(comboRoomE.SelectedItem.ToString(), customerRooms);
                            DBConnection.updateRoomE(rmID, cbRoom.RoomID1, checkDoorE.Checked);
                        }
                        if (comboRoomS.SelectedItem != null)
                        {
                            Room cbRoom = Room.getRoomByName(comboRoomS.SelectedItem.ToString(), customerRooms);
                            DBConnection.updateRoomS(rmID, cbRoom.RoomID1, checkDoorS.Checked);
                        }
                        if (comboRoomW.SelectedItem != null)
                        {
                            Room cbRoom = Room.getRoomByName(comboRoomW.SelectedItem.ToString(), customerRooms);
                            DBConnection.updateRoomW(rmID, cbRoom.RoomID1, checkDoorW.Checked);
                        }
                    }
                    catch (Exception)
                    {
                        lblSaveRoomError.Text = "Error assigning adjacent rooms.";
                    }

                    List<Sensor> sensorsToAdd = new List<Sensor>();
                    foreach (var sensor in lbSensors.Items)
                    {
                        int sensorTypeID = SensorType.getSensorTypeIDByName(sensor.ToString(), sensorTypes);
                        Sensor s = new Sensor(sensorTypeID, rmID);
                        sensorsToAdd.Add(s);
                    }

                    // Add sensors to DB
                    foreach (Sensor s in sensorsToAdd)
                    {
                        try
                        {
                            DBConnection.db_AddSensor(s.SensorTypeID1, rmID);
                        }
                        catch (Exception)
                        {
                            lblSaveRoomError.Text = "Added room but error adding sensor(s).";
                        }
                    }
                    loadViewPage();
                }
                catch (Exception)
                {
                    lblSaveRoomError.Text = "Error adding room.";
                }
            }
            else
            {
                lblSaveRoomError.Text = "Please ensure room name is unique.";
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
            comboRoomN.Items.Clear();
            comboRoomE.Items.Clear();
            comboRoomS.Items.Clear();
            comboRoomW.Items.Clear();
            comboRoomN.ResetText();
            comboRoomE.ResetText();
            comboRoomS.ResetText();
            comboRoomW.ResetText();
            txtRoomName.Text = "";
            checkDoorN.Checked = false;
            checkDoorE.Checked = false;
            checkDoorS.Checked = false;
            checkDoorW.Checked = false;
            lbSensors.Items.Clear();
            // Add rooms to drop down lists            
            setAllPanelsInvisible();
            pnlAddRoom.Visible = true;
        }

        private void btnViewRoom_Click(object sender, EventArgs e)
        {
            loadAddPage();
            Room r = Room.getRoomByName(listboxRooms.SelectedItem.ToString(), customerRooms);
            txtRoomName.Text = r.RoomName1;
            Room rmN = Room.getRoomByID(r.RoomIDNorth1, customerRooms);
            Room rmE = Room.getRoomByID(r.RoomIDEast1, customerRooms);
            Room rmS = Room.getRoomByID(r.RoomIDSouth1, customerRooms);
            Room rmW = Room.getRoomByID(r.RoomIDWest1, customerRooms);
            if (rmN != null)
            {
                comboRoomN.Text = rmN.RoomName1;
            }
            if (rmE != null)
            {
                comboRoomE.Text = rmE.RoomName1;
            }
            if (rmS != null)
            {
                comboRoomS.Text = rmS.RoomName1;
            }
            if (rmW != null)
            {
                comboRoomW.Text = rmW.RoomName1;
            }
            checkDoorN.Checked = r.DoorNorth1;
            checkDoorE.Checked = r.DoorEast1;
            checkDoorS.Checked = r.DoorSouth1;
            checkDoorW.Checked = r.DoorWest1;
            foreach (Sensor s in DBConnection.db_getRoomSensors(r.RoomID1))
            {
                lbSensors.Items.Add(SensorType.getSensorNameByID(s.SensorTypeID1, sensorTypes));
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadViewPage();
        }
    }
}
