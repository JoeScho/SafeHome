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
        Customer c;
        int xLocation = 300;
        int yLocation = 300;
        int roomSize = 80;

        public Visualisation(Customer customer)
        {
            c = customer;
            InitializeComponent();
            floors = DBConnection.db_GetFloors(c.CustomerID1);
            foreach (Floor f in floors)
            {
                comboFloors.Items.Add(f.FloorNum1);
            }
            xLocation = this.Width / 2;
            yLocation = this.Height / 2;
            roomSize = this.Height / 10;
        }

        private void DrawRoom(Room r)
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();

            // Draw room
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
                xLocation, yLocation, roomSize, roomSize);
            graphics.DrawRectangle(System.Drawing.Pens.Black, rectangle);
            r.HasBeenDrawn = true;

            // Draw room name            
            string drawString = r.RoomName1;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            graphics.DrawString(drawString, drawFont, drawBrush, xLocation, yLocation);
            // Display sensors


            // Display doorways

        }

        private void comboFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
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
