using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class SensorType
    {
        private int SensorTypeID;
        private string SensorName;

        public SensorType(int sID, string name)
        {
            this.SensorTypeID1 = sID;
            this.SensorName1 = name;
        }

        public int SensorTypeID1
        {
            get
            {
                return SensorTypeID;
            }

            set
            {
                SensorTypeID = value;
            }
        }

        public string SensorName1
        {
            get
            {
                return SensorName;
            }

            set
            {
                SensorName = value;
            }
        }

        public static string getSensorNameByID(int stID, List<SensorType> types)
        {
            foreach (SensorType st in types)
            {
                if (st.SensorTypeID1 == stID)
                {
                    return st.SensorName1;
                }
            }
            return "";
        }

        public static int getSensorTypeIDByName(string name, List<SensorType> types)
        {
            foreach (SensorType st in types)
            {
                if (st.SensorName1.Equals(name))
                {
                    return st.SensorTypeID1;
                }
            }
            return -1;
        }
    }
}
