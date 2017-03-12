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
        List<Room> customerRooms = new List<Room>();
        List<Sensor> roomSensors = new List<Sensor>();
        List<Floor> customerFloors = new List<Floor>();
        List<SensorType> sensorTypes = DBConnection.getSensorTypes();
        Customer c = new Customer();
        Floor selectedFloor;
        string layoutErrString;

        public Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            foreach (SensorType s in sensorTypes)
            {
                comboAddSensor.Items.Add(s.SensorName1);
            }
            comboAddSensor.SelectedIndex = 0;
            listPanels.Add(pnlLogin);
            listPanels.Add(pnlViewRooms);
            listPanels.Add(pnlAddRoom);
            loadLoginPage();
            comboNoOfRooms.SelectedIndex = 0;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text != "" && txtLoginPwd.Text != "")
            {
                c = DBConnection.db_Login(txtLoginName.Text, txtLoginPwd.Text);
                if (c != null)
                {
                    loadViewPage();
                }
                else
                {
                    lblLoginErr.Text = "Error logging in";
                }
            }
            else
            {
                lblLoginErr.Text = "";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loadLoginPage();
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
                int floorNum = int.Parse(comboSelectFloor.SelectedItem.ToString());
                // Get ID of current floor
                selectedFloor = Floor.getFloorByName(floorNum, customerFloors);
                if (selectedFloor != null)
                {
                    if (customerRooms.Count < selectedFloor.NoOfRooms1)
                    {
                        loadAddPage();
                        makeAddEditable();
                        List<Room> roomsOnFloor = new List<Room>();
                        foreach (Room r in customerRooms)
                        {
                            if (r.Floor1 == selectedFloor.FloorID1)
                            {
                                comboRoomN.Items.Add(r.RoomName1);
                                comboRoomE.Items.Add(r.RoomName1);
                                comboRoomS.Items.Add(r.RoomName1);
                                comboRoomW.Items.Add(r.RoomName1);
                            }
                        }
                    }
                    else
                    {
                        lblAddRoomError.Text = "Floor has all rooms created";
                    }
                }
                else
                {
                    lblAddRoomError.Text = "Error selecting floor";
                }
            }
            catch (Exception)
            {
                lblAddRoomError.Text = "Select a Floor no";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Room.getRoomByName(txtRoomName.Text, customerRooms) == null && txtRoomName.Text != "")
            {
                // Check if room is feasible
                Room r = new Room();
                if (comboRoomN.SelectedItem != null)
                {
                    r.RoomIDNorth1 = (from room in customerRooms
                                      where room.RoomName1 == comboRoomN.SelectedItem.ToString()
                                      select room.RoomID1).First();
                }
                if (comboRoomE.SelectedItem != null)
                {
                    r.RoomIDEast1 = (from room in customerRooms
                                     where room.RoomName1 == comboRoomE.SelectedItem.ToString()
                                     select room.RoomID1).First();
                }
                if (comboRoomS.SelectedItem != null)
                {
                    r.RoomIDSouth1 = (from room in customerRooms
                                      where room.RoomName1 == comboRoomS.SelectedItem.ToString()
                                      select room.RoomID1).First();
                }
                if (comboRoomW.SelectedItem != null)
                {
                    r.RoomIDWest1 = (from room in customerRooms
                                     where room.RoomName1 == comboRoomW.SelectedItem.ToString()
                                     select room.RoomID1).First();
                }
                if (layoutIsFeasible(r, customerRooms))
                {
                    // Add room to DB
                    try
                    {
                        int rmID = DBConnection.db_AddRoom(
                            txtRoomName.Text,
                            c.CustomerID1,
                            selectedFloor.FloorID1
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
                            lblSaveRoomError.Text = "Error assigning adjacent rooms";
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
                                lblSaveRoomError.Text = "Added room but error adding sensor(s)";
                            }
                        }
                        loadViewPage();
                    }
                    catch (Exception)
                    {
                        lblSaveRoomError.Text = "Error adding room";
                    }
                }
                else
                {
                    lblSaveRoomError.Text = "Layout is not feasible. " + layoutErrString;
                }
            }
            else
            {
                lblSaveRoomError.Text = "Room name is not unique";
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
            SensorEmulator f = new SensorEmulator(c);
            f.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterName.Text != "" && txtRegisterPwd.Text != "")
            {
                if (IsValidEmail(txtRegisterName.Text)) {
                    if (DBConnection.db_Register(txtRegisterName.Text, txtRegisterPwd.Text))
                    {
                        txtRegisterName.Text = "";
                        txtRegisterPwd.Text = "";
                        lblRegisterError.Text = "Successfully registered";
                    }
                    else
                    {
                        lblRegisterError.Text = "Error during registration";
                    }
                }
                else
                {
                    lblRegisterError.Text = "Email is not valid";
                }
            }
            else
            {
                lblRegisterError.Text = "Please enter your email and password";
            }
        }

        public void loadLoginPage()
        {
            // Reset screen
            lblLoginErr.Text = "";
            lblRegisterError.Text = "";
            txtLoginName.Text = "";
            txtLoginPwd.Text = "";
            txtRegisterName.Text = "";
            txtRegisterPwd.Text = "";
            lblRoomCount.Text = "";
            setAllPanelsInvisible();
            pnlLogin.Visible = true;
            btnLaunchEmulator.Visible = false;
            btnLogout.Visible = false;

            // Reset variable values
            customerRooms = new List<Room>();
            roomSensors = new List<Sensor>();
            customerFloors = new List<Floor>();
            c = new Customer();
            selectedFloor = new Floor();
        }

        public void loadViewPage()
        {
            lblAddRoomError.Text = "";
            lblAddFloorError.Text = "";
            comboSelectFloor.Text = "";
            comboNoOfRooms.Text = "";
            listboxRooms.Items.Clear();
            comboSelectFloor.Items.Clear();
            customerFloors = DBConnection.db_GetFloors(c.CustomerID1);
            foreach (Floor f in customerFloors)
            {
                comboSelectFloor.Items.Add(f.FloorNum1);
            }
            if (comboSelectFloor.Items.Count > 0)
            {
                comboSelectFloor.SelectedIndex = 0;
            }
            setAllPanelsInvisible();
            pnlViewRooms.Visible = true;
            btnSave.Visible = true;
            btnLaunchEmulator.Visible = true;
            btnLogout.Visible = true;
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
            checkDoorN.Enabled = false;
            checkDoorE.Enabled = false;
            checkDoorS.Enabled = false;
            checkDoorW.Enabled = false;
            lbSensors.Items.Clear();
            setAllPanelsInvisible();
            pnlAddRoom.Visible = true;
        }

        private void btnViewRoom_Click(object sender, EventArgs e)
        {
            if (listboxRooms.SelectedItems.Count == 1)
            {
                loadAddPage();
                makeAddViewOnly();
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
            lblAddRoomError.Text = "Select a room";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadViewPage();
        }

        public void makeAddViewOnly()
        {
            btnSave.Visible = false;
            btnAddSensor.Visible = false;
            btnDeleteSensor.Visible = false;
            comboAddSensor.Visible = false;
            lblAddSensor.Text = "Room sensors:";
            lbSensors.Enabled = false;
            txtRoomName.Enabled = false;
            checkDoorN.Enabled = false;
            checkDoorE.Enabled = false;
            checkDoorS.Enabled = false;
            checkDoorW.Enabled = false;
            comboRoomN.Enabled = false;
            comboRoomE.Enabled = false;
            comboRoomS.Enabled = false;
            comboRoomW.Enabled = false;
        }

        public void makeAddEditable()
        {
            btnSave.Visible = true;
            btnAddSensor.Visible = true;
            btnDeleteSensor.Visible = true;
            comboAddSensor.Visible = true;
            lblAddSensor.Text = "Add a sensor";
            lbSensors.Enabled = true;
            txtRoomName.Enabled = true;
            comboRoomN.Enabled = true;
            comboRoomE.Enabled = true;
            comboRoomS.Enabled = true;
            comboRoomW.Enabled = true;
        }

        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            if (comboNoOfRooms.Text != "")
            {
                int floorNum = 1;
                if (customerFloors.Count != 0)
                {
                    floorNum = customerFloors.Max(x => x.FloorNum1) + 1;
                }                
                int noOfRooms = int.Parse(comboNoOfRooms.SelectedItem.ToString());
                DBConnection.db_AddFloor(c.CustomerID1, floorNum, noOfRooms);
                loadViewPage();
            }
            else
            {
                lblAddFloorError.Text = "Select number of rooms";
            }
        }

        private void comboSelectFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxRooms.Items.Clear();
            if (int.Parse(comboSelectFloor.SelectedItem.ToString()) != 0)
            {
                int floornum = int.Parse(comboSelectFloor.SelectedItem.ToString());
                int floorid = (from fl in customerFloors
                               where fl.FloorNum1 == floornum
                               select fl.FloorID1).First();
                Floor f = Floor.getFloorByName(floornum, customerFloors);
                customerRooms = DBConnection.db_GetRooms(c.CustomerID1, floorid);
                foreach (Room r in customerRooms)
                {
                    listboxRooms.Items.Add(r.RoomName1);
                }
                lblRoomCount.Text = "( " + customerRooms.Count + " / " + f.NoOfRooms1 + " )";
            }
        }

        private void comboRoomN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRoomN.SelectedItem != null)
            {
                checkDoorN.Enabled = true;
            }
        }

        private void comboRoomE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRoomE.SelectedItem != null)
            {
                checkDoorE.Enabled = true;
            }
        }

        private void comboRoomS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRoomS.SelectedItem != null)
            {
                checkDoorS.Enabled = true;
            }
        }

        private void comboRoomW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRoomN.SelectedItem != null)
            {
                checkDoorW.Enabled = true;
            }
        }

        public bool layoutIsFeasible(Room newRoom, List<Room> currentRooms)
        {
            if (newRoom.RoomIDNorth1 != 0)
            {
                //Check if that room is already referenced as a RoomIDNorth in any other rooms
                foreach (Room r in currentRooms)
                {
                    if (newRoom.RoomIDNorth1 == r.RoomIDNorth1)
                    {
                        // Room is already referenced as a north room
                        layoutErrString = "The room '" + r.RoomName1 + "' already exists in this location";
                        return false;
                    }
                }
            }
            if (newRoom.RoomIDEast1 != 0)
            {
                //Check if that room is already referenced as a RoomIDEast in any other rooms
                foreach (Room r in currentRooms)
                {
                    if (newRoom.RoomIDEast1 == r.RoomIDEast1)
                    {
                        // Room is already referenced as a north room
                        layoutErrString = "The room '" + r.RoomName1 + "' already exists in this location";
                        return false;
                    }
                }
            }
            if (newRoom.RoomIDSouth1 != 0)
            {
                //Check if that room is already referenced as a RoomIDSouth in any other rooms
                foreach (Room r in currentRooms)
                {
                    if (newRoom.RoomIDSouth1 == r.RoomIDSouth1)
                    {
                        // Room is already referenced as a north room
                        layoutErrString = "The room '" + r.RoomName1 + "' already exists in this location";
                        return false;
                    }
                }
            }
            if (newRoom.RoomIDWest1 != 0)
            {
                //Check if that room is already referenced as a RoomIDWest in any other rooms
                foreach (Room r in currentRooms)
                {
                    if (newRoom.RoomIDWest1 == r.RoomIDWest1)
                    {
                        // Room is already referenced as a north room
                        layoutErrString = "The room '" + r.RoomName1 + "' already exists in this location";
                        return false;
                    }
                }
            }
            return true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
