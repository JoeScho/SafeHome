﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SafeHome
{
    public class Customer
    {
        int CustomerID;
        string UserName;

        public Customer()
        {
            CustomerID = 0;
            UserName = "";
        }

        public int CustomerID1
        {
            get
            {
                return CustomerID;
            }

            set
            {
                CustomerID = value;
            }
        }

        public string UserName1
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }
    }
}
