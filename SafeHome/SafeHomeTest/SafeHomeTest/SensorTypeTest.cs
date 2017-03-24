using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SafeHome;

namespace SafeHomeTest
{
    [TestClass]
    public class SensorTypeTest
    {
        List<SensorType> sensors = new List<SensorType>() {
            new SensorType(1, "sensor1"),
            new SensorType(2, "sensor2"),
            new SensorType(3, "sensor3"),
            new SensorType(4, "sensor4")
        };

        [TestMethod]
        public void _getSensorNameByID_Pass()
        {
            Assert.AreEqual("sensor3", SensorType.getSensorNameByID(3, sensors));
        }

        [TestMethod]
        public void _getSensorNameByID_Fail()
        {
            Assert.AreNotEqual("sensor4", SensorType.getSensorNameByID(3, sensors));
        }

        [TestMethod]
        public void _getSensorTypeIDByName_Pass()
        {
            Assert.AreEqual(3, SensorType.getSensorTypeIDByName("sensor3", sensors));
        }

        [TestMethod]
        public void _getSensorTypeIDByName_Fail()
        {
            Assert.AreNotEqual(4, SensorType.getSensorTypeIDByName("sensor3", sensors));
        }
    }
}
