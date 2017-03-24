using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SafeHome;

namespace SafeHomeTest
{
    [TestClass]
    public class RoomTest
    {
        List<Room> rooms = new List<Room>();
        Room r1 = new Room(1, "room1", 1, 1, 2, true, 3, true, 4, true, 5, true);
        Room r2 = new Room(2, "room2", 1, 1, 0, true, 0, true, 1, true, 0, true);
        Room r3 = new Room(3, "room3", 1, 1, 0, true, 0, true, 0, true, 1, true);
        Room r4 = new Room(4, "room4", 1, 1, 1, true, 0, true, 0, true, 0, true);
        Room r5 = new Room(5, "room5", 1, 1, 0, true, 1, true, 0, true, 0, true);

        [TestMethod]
        public void _getRoomByName_Pass()
        {
            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r5);
            Assert.AreEqual(r4, Room.getRoomByName("room4", rooms));
        }

        [TestMethod]
        public void _getRoomByName_Fail()
        {
            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r5);
            Assert.AreNotEqual(r3, Room.getRoomByName("room4", rooms));
        }

        [TestMethod]
        public void _getRoomByID_Pass()
        {
            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r5);
            Assert.AreEqual(r4, Room.getRoomByID(4, rooms));
        }

        [TestMethod]
        public void _getRoomByID_Fail()
        {
            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r5);
            Assert.AreNotEqual(r3, Room.getRoomByID(4, rooms));
        }
    }
}
