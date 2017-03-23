using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeHome.SafeHomeAPIServices;

namespace SafeHome
{
    public partial class SensorEmulator : Form
    {
        List<Floor> floors = new List<Floor>();
        List<Room> rooms = new List<Room>();
        List<Sensor> sensors = new List<Sensor>();
        List<SensorType> sensorTypes = new List<SensorType>();
        Sensor selectedSensor = null;
        Customer customer = new Customer();
        SafeHomeAPISoapClient service = new SafeHomeAPISoapClient();

        public SensorEmulator(Customer c)
        {
            // Window size fixed
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            customer = c;
            sensorTypes = DBConnection.getSensorTypes();
            floors = DBConnection.db_GetFloors(c.CustomerID1);
            foreach(Floor f in floors)
            {
                comboFloor.Items.Add(f.FloorNum1);
            }
        }

        // When the selected floor is changed, populate room ddl with new floor's rooms
        private void comboFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboRoom.Items.Clear();
            comboRoom.Text = "";
            comboSensor.Items.Clear();
            comboSensor.Text = "";
            selectedSensor = null;

            int floornum = int.Parse(comboFloor.SelectedItem.ToString());
            Floor selectedFloor = (from f in floors
                                   where f.FloorNum1 == floornum
                                   select f).First();
            rooms = DBConnection.db_GetRooms(customer.CustomerID1, selectedFloor.FloorID1);
            foreach (Room r in rooms)
            {
                comboRoom.Items.Add(r.RoomName1);
            }
        }

        // When the selected room is changed, populate sensor ddl with room's sensors
        private void comboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSensor.Items.Clear();
            comboSensor.Text = "";
            selectedSensor = null;

            string roomname = comboRoom.SelectedItem.ToString();
            Room selectedRoom = (from r in rooms
                                   where r.RoomName1 == roomname
                                 select r).First();
            sensors = DBConnection.db_getRoomSensors(selectedRoom.RoomID1);
            foreach (Sensor s in sensors)
            {
                string sensorname = (from st in sensorTypes
                                     where st.SensorTypeID1 == s.SensorTypeID1
                                     select st.SensorName1).First();
                comboSensor.Items.Add(sensorname);
            }
        }

        // When the sensortype is selected, find that sensor from the room's sensors
        private void comboSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SensorType selectedtype = (from st in sensorTypes
                                   where st.SensorName1 == comboSensor.SelectedItem.ToString()
                                   select st).First();
            selectedSensor = (from s in sensors
                              where s.SensorTypeID1 == selectedtype.SensorTypeID1
                              select s).First();
        }

        // Submit the reading to the db
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string detail = "";
            if (txtDetail != null)
            {
                detail = txtDetail.Text;
            }
            if (selectedSensor != null)
            {
                // Call API to submit sensor reading
                lblSubmit.Text = service.SubmitReading(customer.CustomerID1, selectedSensor.SensorID1, detail);
            }
            else
            {
                lblSubmit.Text = "Please select a sensor.";
            }
        }
    }
}
