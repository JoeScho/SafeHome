﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SafeHome;

namespace SafeHomeTest
{
    [TestClass]
    public class SensorTest
    {
        [TestMethod]
        public void _sensorAlarm()
        {
            Sensor s = new Sensor();
            Assert.AreEqual(true, s.alert());
        }
    }
}