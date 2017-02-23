using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHome
{
    public class Room
    {
        int RoomID;
        string RoomName;
        int CustomerID;
        int Floor;
        int RoomIDNorth;
        bool DoorNorth;
        int RoomIDEast;
        bool DoorEast;
        int RoomIDSouth;
        bool DoorSouth;
        int RoomIDWest;
        bool DoorWest;

        public Room(int id, string name, int cID, int floor, int roomN, bool doorN, int roomE, bool doorE, int roomS, bool doorS, int roomW, bool doorW)
        {
            this.RoomID1 = id;
            this.RoomName1 = name;
            this.CustomerID1 = cID;
            this.Floor1 = floor;
            this.RoomIDNorth1 = roomN;
            this.DoorNorth1 = doorN;
            this.RoomIDEast1 = roomE;
            this.DoorEast1 = doorE;
            this.RoomIDSouth1 = roomS;
            this.DoorSouth1 = doorS;
            this.RoomIDWest1 = roomW;
            this.DoorWest1 = doorW;
        }

        public Room(string name, int cID, int floor, int roomN, bool doorN, int roomE, bool doorE, int roomS, bool doorS, int roomW, bool doorW)
        {
            this.RoomName1 = name;
            this.CustomerID1 = cID;
            this.Floor1 = floor;
            this.RoomIDNorth1 = roomN;
            this.DoorNorth1 = doorN;
            this.RoomIDEast1 = roomE;
            this.DoorEast1 = doorE;
            this.RoomIDSouth1 = roomS;
            this.DoorSouth1 = doorS;
            this.RoomIDWest1 = roomW;
            this.DoorWest1 = doorW;
        }

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

        public int Floor1
        {
            get
            {
                return Floor;
            }

            set
            {
                Floor = value;
            }
        }

        public int RoomID1
        {
            get
            {
                return RoomID;
            }

            set
            {
                RoomID = value;
            }
        }

        public static Room getRoomByName(string name, List<Room> rooms)
        {
            foreach (Room r in rooms)
            {
                if (r.RoomName1 == name)
                {
                    return r;
                }
            }
            return null;
        }

        public static Room getRoomByID(int ID, List<Room> rooms)
        {
            foreach (Room r in rooms)
            {
                if (r.RoomID1 == ID)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
