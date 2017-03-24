using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API;

namespace SafeHomeTest.APITest
{
    [TestClass]
    public class API_SensorTypeTest
    {
        List<SensorType> sensors = new List<SensorType>() {
            new SensorType(1, "sensor1"),
            new SensorType(2, "sensor2"),
            new SensorType(3, "sensor3"),
            new SensorType(4, "sensor4")
        };

        [TestMethod]
        public void _API_getSensorNameByID_Pass()
        {
            Assert.AreEqual("sensor3", SensorType.getSensorNameByID(3, sensors));
        }

        [TestMethod]
        public void _API_getSensorNameByID_Fail()
        {
            Assert.AreNotEqual("sensor4", SensorType.getSensorNameByID(3, sensors));
        }

        [TestMethod]
        public void _API_getSensorTypeIDByName_Pass()
        {
            Assert.AreEqual(3, SensorType.getSensorTypeIDByName("sensor3", sensors));
        }

        [TestMethod]
        public void _API_getSensorTypeIDByName_Fail()
        {
            Assert.AreNotEqual(4, SensorType.getSensorTypeIDByName("sensor3", sensors));
        }
    }
}
