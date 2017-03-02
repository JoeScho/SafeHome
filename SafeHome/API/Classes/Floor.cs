using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class Floor
    {
        int FloorID;
        int FloorNum;
        int NoOfRooms;
        int CustomerID;

        public Floor() { }

        public Floor(int flrNum, int roomCount, int cID)
        {
            this.FloorNum = flrNum;
            this.NoOfRooms = roomCount;
            this.CustomerID = cID;
        }

        public Floor(int flrID, int flrNum, int roomCount, int cID)
        {
            this.FloorID = flrID;
            this.FloorNum = flrNum;
            this.NoOfRooms = roomCount;
            this.CustomerID = cID;
        }

        public int FloorID1
        {
            get
            {
                return FloorID;
            }

            set
            {
                FloorID = value;
            }
        }

        public int FloorNum1
        {
            get
            {
                return FloorNum;
            }

            set
            {
                FloorNum = value;
            }
        }

        public int NoOfRooms1
        {
            get
            {
                return NoOfRooms;
            }

            set
            {
                NoOfRooms = value;
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

        public static Floor getFloorByName(int floorNum, List<Floor> floors)
        {
            foreach (Floor f in floors)
            {
                if (f.FloorNum == floorNum)
                {
                    return f;
                }
            }
            return null;
        }
    }
}
