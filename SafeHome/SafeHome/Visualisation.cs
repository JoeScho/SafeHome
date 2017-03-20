using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeHome
{
    public partial class Visualisation : Form
    {
        List<Floor> floors = new List<Floor>();
        List<Room> rooms = new List<Room>();
        List<SensorType> types = new List<SensorType>();
        Customer c;
        int xLocation = 300;
        int yLocation = 300;
        int roomSize = 150;
        System.Drawing.Graphics graphics;

        public Visualisation(Customer customer)
        {
            c = customer;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            floors = DBConnection.db_GetFloors(c.CustomerID1);
            types = DBConnection.getSensorTypes();
            foreach (Floor f in floors)
            {
                comboFloors.Items.Add(f.FloorNum1);
            }
            xLocation = this.Width / 2;
            yLocation = this.Height / 2;
            roomSize = this.Height / 4;
            graphics = panel1.CreateGraphics();

            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { panel1.VerticalScroll.Value = vScrollBar1.Value; };
            panel1.Controls.Add(vScrollBar1);
        }

        private void DrawRoom(Room r)
        {
            // Draw room
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
                xLocation, yLocation, roomSize, roomSize);
            graphics.DrawRectangle(System.Drawing.Pens.Black, rectangle);
            r.HasBeenDrawn = true;

            // Draw room name            
            string drawString = r.RoomName1;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            graphics.DrawString(drawString, drawFont, drawBrush, xLocation, yLocation);

            // Display sensors
            List<Sensor> roomSensors = DBConnection.db_getRoomSensors(r.RoomID1);
            int currentYLocation = yLocation;
            foreach (Sensor s in roomSensors)
            {
                currentYLocation += 20;
                string type = (from t in types
                               where t.SensorTypeID1 == s.SensorTypeID1
                               select t.SensorName1).First();
                System.Drawing.Font sensorDrawFont = new System.Drawing.Font("Arial", 8);
                graphics.DrawString(type, sensorDrawFont, drawBrush, xLocation, currentYLocation);
            }

            // Display doorways
            if(r.DoorNorth1)
            {
                System.Drawing.Pen myPen;
                myPen = new System.Drawing.Pen(System.Drawing.Color.White);
                graphics.DrawLine(myPen, xLocation + (roomSize / 3), yLocation, xLocation + (2 * (roomSize / 3)), yLocation);
                System.Drawing.Pen blackPen;
                blackPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                graphics.DrawLine(blackPen, xLocation + (roomSize / 3), yLocation, xLocation + (2 * (roomSize / 3)), yLocation - 25);
            }
            if (r.DoorEast1)
            {
                System.Drawing.Pen myPen;
                myPen = new System.Drawing.Pen(System.Drawing.Color.White);
                graphics.DrawLine(myPen, xLocation + roomSize, yLocation + (roomSize / 3), xLocation + roomSize, yLocation + (2 * (roomSize / 3)));
                System.Drawing.Pen blackPen;
                blackPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                graphics.DrawLine(blackPen, xLocation + roomSize, yLocation + (roomSize / 3), xLocation + roomSize - 25, yLocation + (2 * (roomSize / 3)));
            }
            if (r.DoorSouth1)
            {
                System.Drawing.Pen myPen;
                myPen = new System.Drawing.Pen(System.Drawing.Color.White);
                graphics.DrawLine(myPen, xLocation + (roomSize / 3), yLocation + roomSize, xLocation + (2 * (roomSize / 3)), yLocation + roomSize);
                System.Drawing.Pen blackPen;
                blackPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                graphics.DrawLine(blackPen, xLocation + (roomSize / 3), yLocation + roomSize, xLocation + (2 * (roomSize / 3)), yLocation + roomSize - 25);
            }
            if (r.DoorWest1)
            {
                System.Drawing.Pen myPen;
                myPen = new System.Drawing.Pen(System.Drawing.Color.White);
                graphics.DrawLine(myPen, xLocation, yLocation + (roomSize / 3), xLocation, yLocation + (2 * (roomSize / 3)));
                System.Drawing.Pen blackPen;
                blackPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                graphics.DrawLine(blackPen, xLocation, yLocation + (roomSize / 3), xLocation - 25, yLocation + (2 * (roomSize / 3)));
            }
        }

        private void comboFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            graphics.Clear(System.Drawing.Color.White);
            lblNoRooms.Text = "";
            int floornum = int.Parse(comboFloors.SelectedItem.ToString());
            Floor selectedFloor = (from f in floors
                                   where f.FloorNum1 == floornum
                                   select f).First();
            rooms = DBConnection.db_GetRooms(c.CustomerID1, selectedFloor.FloorID1);
            if (rooms.Count > 0)
            {
                DrawRoom(rooms[0]);
                drawAdjacentRooms(rooms[0]);
            }
            else
            {
                lblNoRooms.Text = "No rooms to display.";
            }            
        }

        public void drawAdjacentRooms(Room r)
        {
            if (r.RoomIDNorth1 != 0)
            {
                
                Room roomN = (from rm in rooms
                              where r.RoomIDNorth1 == rm.RoomID1
                              select rm).First();
                if (!roomN.HasBeenDrawn)
                {
                    yLocation -= roomSize;
                    DrawRoom(roomN);
                    drawAdjacentRooms(roomN);
                    yLocation += roomSize;
                }                
            }
            if (r.RoomIDEast1 != 0)
            {                
                Room roomE = (from rm in rooms
                              where r.RoomIDEast1 == rm.RoomID1
                              select rm).First();
                if(!roomE.HasBeenDrawn)
                {
                    xLocation += roomSize;
                    DrawRoom(roomE);
                    drawAdjacentRooms(roomE);
                    xLocation -= roomSize;
                }                
            }
            if (r.RoomIDSouth1 != 0)
            {                
                Room roomS = (from rm in rooms
                              where r.RoomIDSouth1 == rm.RoomID1
                              select rm).First();
                if(!roomS.HasBeenDrawn)
                {
                    yLocation += roomSize;
                    DrawRoom(roomS);
                    drawAdjacentRooms(roomS);
                    yLocation -= roomSize;
                }                
            }
            if (r.RoomIDWest1 != 0)
            {                
                Room roomW = (from rm in rooms
                              where r.RoomIDWest1 == rm.RoomID1
                              select rm).First();
                if(!roomW.HasBeenDrawn)
                {
                    xLocation -= roomSize;
                    DrawRoom(roomW);
                    drawAdjacentRooms(roomW);
                    xLocation += roomSize;
                }                
            }
        }
    }
}
