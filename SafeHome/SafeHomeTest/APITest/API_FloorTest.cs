using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using API;

namespace SafeHomeTest.APITest
{
    [TestClass]
    public class API_FloorTest
    {
        List<Floor> rooms = new List<Floor>();
        Floor f1 = new Floor(1, 1, 5, 1);
        Floor f2 = new Floor(2, 2, 5, 1);
        Floor f3 = new Floor(3, 3, 5, 1);
        Floor f4 = new Floor(4, 4, 5, 1);
        Floor f5 = new Floor(5, 5, 5, 1);

        [TestMethod]
        public void _API_getFloorByName_Pass()
        {
            rooms.Add(f1);
            rooms.Add(f2);
            rooms.Add(f3);
            rooms.Add(f4);
            rooms.Add(f5);
            Assert.AreEqual(f4, Floor.getFloorByName(4, rooms));
        }

        [TestMethod]
        public void _API_getFloorByName_Fail()
        {
            rooms.Add(f1);
            rooms.Add(f2);
            rooms.Add(f3);
            rooms.Add(f4);
            rooms.Add(f5);
            Assert.AreNotEqual(f3, Floor.getFloorByName(4, rooms));
        }
    }
}
