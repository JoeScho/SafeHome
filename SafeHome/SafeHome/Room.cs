using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHome
{
    class Room
    {
        string RoomName;
        int CustomerID;
        int RoomIDNorth;
        bool DoorNorth;
        int RoomIDEast;
        bool DoorEast;
        int RoomIDSouth;
        bool DoorSouth;
        int RoomIDWest;
        bool DoorWest;

        public string RoomName1
        {
            get
            {
                return RoomName;
            }

            set
            {
                RoomName = value;
            }
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

        public int RoomIDNorth1
        {
            get
            {
                return RoomIDNorth;
            }

            set
            {
                RoomIDNorth = value;
            }
        }

        public int RoomIDEast1
        {
            get
            {
                return RoomIDEast;
            }

            set
            {
                RoomIDEast = value;
            }
        }

        public int RoomIDSouth1
        {
            get
            {
                return RoomIDSouth;
            }

            set
            {
                RoomIDSouth = value;
            }
        }

        public int RoomIDWest1
        {
            get
            {
                return RoomIDWest;
            }

            set
            {
                RoomIDWest = value;
            }
        }

        public bool DoorNorth1
        {
            get
            {
                return DoorNorth;
            }

            set
            {
                DoorNorth = value;
            }
        }

        public bool DoorEast1
        {
            get
            {
                return DoorEast;
            }

            set
            {
                DoorEast = value;
            }
        }

        public bool DoorSouth1
        {
            get
            {
                return DoorSouth;
            }

            set
            {
                DoorSouth = value;
            }
        }

        public bool DoorWest1
        {
            get
            {
                return DoorWest;
            }

            set
            {
                DoorWest = value;
            }
        }

        public static int getRoomByName(string roomName)
        {
            int roomID = 1;//query db - "SELECT RoomID FROM Room WHERE RoomName = '" + roomName + "'";
            return roomID;
        }
    }
}
