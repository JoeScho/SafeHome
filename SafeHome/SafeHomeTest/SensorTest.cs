using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SafeHome;

namespace SafeHomeTest
{
    [TestClass]
    public class SensorTest
    {
        [TestMethod]
        public void checkCrapMethodWorks()
        {
            Sensor s = new Sensor();
            string ss = s.returnAString();
            Assert.AreEqual("Hello World!", ss);
        }
    }
}
