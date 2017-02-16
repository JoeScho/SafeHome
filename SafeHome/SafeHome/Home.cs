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
        List<int> sensorsToDelete = new List<int>();
        List<int> sensorsToAdd = new List<int>();
        Customer c = new Customer();
        int floor;
        bool update;
        
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
                update = false;
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
            if (!update)
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
                                DBConnection.updateRoomE(rmID, cbRoom.RoomID1, checkDoorN.Checked);
                            }
                            if (comboRoomS.SelectedItem != null)
                            {
                                Room cbRoom = Room.getRoomByName(comboRoomS.SelectedItem.ToString(), customerRooms);
                                DBConnection.updateRoomS(rmID, cbRoom.RoomID1, checkDoorN.Checked);
                            }
                            if (comboRoomW.SelectedItem != null)
                            {
                                Room cbRoom = Room.getRoomByName(comboRoomW.SelectedItem.ToString(), customerRooms);
                                DBConnection.updateRoomW(rmID, cbRoom.RoomID1, checkDoorN.Checked);
                            }
                        }    
                        catch (Exception)
                        {
                            lblSaveRoomError.Text = "Error assigning adjacent rooms.";
                        }                    

                        // Add sensors to DB
                        foreach (int i in sensorsToAdd)
                        {
                            try
                            {
                                DBConnection.db_AddSensor(i, rmID);
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
            else
            {
                //update room
            }            
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            if(update)
            {
                sensorsToAdd.Add(int.Parse(lvSensors.SelectedItems[0].SubItems[1].Text));
            }
            string s = comboAddSensor.Text;
            lvSensors.Items.Add(s);
        }

        private void btnDeleteSensor_Click(object sender, EventArgs e)
        {
            if(update)
            {
                //sensorsToDelete.Add(int.Parse(lvSensors.SelectedItems[0].SubItems[1].Text));
            }            
            lvSensors.Items.Remove(lvSensors.SelectedItems[0]);
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
            lvSensors.Clear();
            // Add rooms to drop down lists            
            setAllPanelsInvisible();
            pnlAddRoom.Visible = true;
        }

        private void btnViewRoom_Click(object sender, EventArgs e)
        {
            update = true;
            Room r = Room.getRoomByName(listboxRooms.SelectedItem.ToString(), customerRooms);
            txtRoomName.Text = r.RoomName1;            

            foreach (Sensor s in DBConnection.db_getRoomSensors(r.RoomID1))
            {
                lvSensors.Items.Add(s.SensorName).SubItems.Add(s.SensorID1.ToString());
            }
            loadAddPage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadViewPage();
        }
    }
}
