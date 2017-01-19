using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHome
{
    public class Sensor
    {
        string[] types = new string[5] {"Door / Window Contact", "Movement", "Fire", "Breaking Glass", "Vibration"};

        public bool alert ()
        {
            return true;
        }
    }
}
