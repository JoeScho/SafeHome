using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SafeHome
{
    class DBConnection
    {
        public static Customer db_Login(string username, string password)
        {
            Customer selectedCustomer = new Customer();
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramUsername = new SqlParameter("@ParamUsername", SqlDbType.VarChar);
            paramUsername.Value = username;
            SqlParameter paramPwd = new SqlParameter("@ParamPwd", SqlDbType.VarChar);
            paramPwd.Value = password;

            SqlCommand myCommand = new SqlCommand(
                "SELECT * FROM dbo.PDC_Customer WHERE Username = @ParamUsername AND Password = @ParamPwd", myConnection);
            myCommand.Parameters.Add(paramUsername);
            myCommand.Parameters.Add(paramPwd);

            SqlDataReader myReader = null;

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    selectedCustomer.CustomerID1 = (int)myReader["CustomerID"];
                    selectedCustomer.UserName1 = myReader["Username"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return selectedCustomer;
        }

        public static bool db_Register(string username, string password)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramUsername = new SqlParameter("@ParamUsername", SqlDbType.VarChar);
            paramUsername.Value = username;
            SqlParameter paramPwd = new SqlParameter("@ParamPwd", SqlDbType.VarChar);
            paramPwd.Value = password;

            SqlCommand myCommand = new SqlCommand(
                "INSERT INTO dbo.PDC_Customer (Username, Password) VALUES (@ParamUsername,@ParamPwd)", myConnection);
            myCommand.Parameters.Add(paramUsername);
            myCommand.Parameters.Add(paramPwd);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return false;
        }

        public static List<Room> db_GetRooms(int CustomerID, int FloorID)
        {
            List<Room> rooms = new List<Room>();
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramCID = new SqlParameter("@paramCID", SqlDbType.Int);
            paramCID.Value = CustomerID;
            SqlParameter paramFID = new SqlParameter("@paramFID", SqlDbType.Int);
            paramFID.Value = FloorID;

            SqlCommand myCommand = new SqlCommand(
                "SELECT * FROM dbo.PDC_Room WHERE CustomerID = @paramCID AND FloorID = @paramFID", myConnection);
            myCommand.Parameters.Add(paramCID);
            myCommand.Parameters.Add(paramFID);
            SqlDataReader myReader = null;

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int n = 0;
                    int e = 0;
                    int s = 0;
                    int w = 0;

                    if (myReader["RoomIDNorth"] != DBNull.Value)
                    {
                        n = (int)myReader["RoomIDNorth"];
                    }
                    if (myReader["RoomIDEast"] != DBNull.Value)
                    {
                        e = (int)myReader["RoomIDEast"];
                    }
                    if (myReader["RoomIDSouth"] != DBNull.Value)
                    {
                        s = (int)myReader["RoomIDSouth"];
                    }
                    if (myReader["RoomIDWest"] != DBNull.Value)
                    {
                        w = (int)myReader["RoomIDWest"];
                    }

                    int rID = (int)myReader["RoomID"];
                    string name = myReader["RoomName"].ToString();
                    bool drN = myReader.GetBoolean(myReader.GetOrdinal("DoorNorth"));
                    bool drE = myReader.GetBoolean(myReader.GetOrdinal("DoorEast"));
                    bool drS = myReader.GetBoolean(myReader.GetOrdinal("DoorSouth"));
                    bool drW = myReader.GetBoolean(myReader.GetOrdinal("DoorWest"));
                    Room r = new Room(rID, name, CustomerID, FloorID, n, drN, e, drE, s, drS, w, drW);
                    rooms.Add(r);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return rooms;
        }

        public static List<SensorType> getSensorTypes()
        {
            List<SensorType> sensorTypes = new List<SensorType>();
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            SqlCommand myCommand = new SqlCommand(
                "SELECT * FROM dbo.PDC_SensorType", myConnection);

            SqlDataReader myReader = null;

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int id = int.Parse(myReader["SensorTypeID"].ToString());
                    string name = myReader["SensorName"].ToString();
                    SensorType s = new SensorType(id, name);
                    sensorTypes.Add(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return sensorTypes;
        }

        public static int db_AddRoom(string rmName, int cID, int flrID)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramRoomName = new SqlParameter("@paramRoomName", SqlDbType.VarChar);
            paramRoomName.Value = rmName;
            SqlParameter paramCID = new SqlParameter("@ParamCID", SqlDbType.Int);
            paramCID.Value = cID;
            SqlParameter paramFloorID = new SqlParameter("@paramFloorID", SqlDbType.Int);
            paramFloorID.Value = flrID;

            SqlCommand myCommand = new SqlCommand(
                "INSERT INTO dbo.PDC_Room (RoomName, CustomerID, FloorID) VALUES (@paramRoomName,@ParamCID,@paramFloorID); "
                + "SELECT CAST(scope_identity() AS int)", myConnection);
            myCommand.Parameters.Add(paramRoomName);
            myCommand.Parameters.Add(paramCID);
            myCommand.Parameters.Add(paramFloorID);

            try
            {
                myConnection.Open();
                int id = (int)myCommand.ExecuteScalar();
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return -1;
        }

        public static void updateRoomN(int roomID, int roomIDN, bool drN)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramRoom = new SqlParameter("@paramRoom", SqlDbType.Int);
            paramRoom.Value = roomID;
            SqlParameter paramRoomN = new SqlParameter("@paramRoomN", SqlDbType.Int);
            paramRoomN.Value = roomIDN;
            SqlParameter paramDoorN = new SqlParameter("@paramDoorN", SqlDbType.Bit);
            paramDoorN.Value = drN;

            SqlCommand myCommand = new SqlCommand(
                "UPDATE dbo.PDC_Room SET RoomIDNorth = @paramRoomN, DoorNorth = @paramDoorN WHERE RoomID = @paramRoom;"
                + "UPDATE dbo.PDC_Room SET RoomIDSouth = @paramRoom, DoorSouth = @paramDoorN WHERE RoomID = @paramRoomN;", myConnection);
            myCommand.Parameters.Add(paramRoom);
            myCommand.Parameters.Add(paramRoomN);
            myCommand.Parameters.Add(paramDoorN);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void updateRoomE(int roomID, int roomIDE, bool drE)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramRoom = new SqlParameter("@paramRoom", SqlDbType.Int);
            paramRoom.Value = roomID;
            SqlParameter paramRoomE = new SqlParameter("@paramRoomE", SqlDbType.Int);
            paramRoomE.Value = roomIDE;
            SqlParameter paramDoorE = new SqlParameter("@paramDoorE", SqlDbType.Bit);
            paramDoorE.Value = drE;

            SqlCommand myCommand = new SqlCommand(
                 "UPDATE dbo.PDC_Room SET RoomIDEast = @paramRoomE, DoorEast = @paramDoorE WHERE RoomID = @paramRoom;"
                 + "UPDATE dbo.PDC_Room SET RoomIDWest = @paramRoom, DoorWest = @paramDoorE WHERE RoomID = @paramRoomE;", myConnection);
            myCommand.Parameters.Add(paramRoom);
            myCommand.Parameters.Add(paramRoomE);
            myCommand.Parameters.Add(paramDoorE);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void updateRoomS(int roomID, int roomIDS, bool drS)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramRoom = new SqlParameter("@paramRoom", SqlDbType.Int);
            paramRoom.Value = roomID;
            SqlParameter paramRoomS = new SqlParameter("@paramRoomS", SqlDbType.Int);
            paramRoomS.Value = roomIDS;
            SqlParameter paramDoorS = new SqlParameter("@paramDoorS", SqlDbType.Bit);
            paramDoorS.Value = drS;

            SqlCommand myCommand = new SqlCommand(
                 "UPDATE dbo.PDC_Room SET RoomIDSouth = @paramRoomS, DoorSouth = @paramDoorS WHERE RoomID = @paramRoom;"
                 + "UPDATE dbo.PDC_Room SET RoomIDNorth = @paramRoom, DoorNorth = @paramDoorS WHERE RoomID = @paramRoomS;", myConnection);
            myCommand.Parameters.Add(paramRoom);
            myCommand.Parameters.Add(paramRoomS);
            myCommand.Parameters.Add(paramDoorS);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void updateRoomW(int roomID, int roomIDW, bool drW)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramRoom = new SqlParameter("@paramRoom", SqlDbType.Int);
            paramRoom.Value = roomID;
            SqlParameter paramRoomW = new SqlParameter("@paramRoomW", SqlDbType.Int);
            paramRoomW.Value = roomIDW;
            SqlParameter paramDoorW = new SqlParameter("@paramDoorW", SqlDbType.Bit);
            paramDoorW.Value = drW;

            SqlCommand myCommand = new SqlCommand(
                 "UPDATE dbo.PDC_Room SET RoomIDWest = @paramRoomW, DoorWest = @paramDoorW WHERE RoomID = @paramRoom;"
                 + "UPDATE dbo.PDC_Room SET RoomIDEast = @paramRoom, DoorEast = @paramDoorW WHERE RoomID = @paramRoomW;", myConnection);
            myCommand.Parameters.Add(paramRoom);
            myCommand.Parameters.Add(paramRoomW);
            myCommand.Parameters.Add(paramDoorW);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static List<Sensor> db_getRoomSensors(int roomID)
        {
            List<Sensor> sensors = new List<Sensor>();
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            SqlParameter paramRoomID = new SqlParameter("@paramRoomID", SqlDbType.Int);
            paramRoomID.Value = roomID;

            SqlCommand myCommand = new SqlCommand(
                "SELECT s.SensorID, s.SensorTypeID, st.SensorName FROM PDC_Sensor s INNER JOIN PDC_SensorType st ON s.SensorTypeID = st.SensorTypeID WHERE s.RoomID = @paramRoomID", myConnection);
            myCommand.Parameters.Add(paramRoomID);

            SqlDataReader myReader = null;

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Sensor s = new Sensor(
                        int.Parse(myReader["SensorID"].ToString()),
                        int.Parse(myReader["SensorTypeID"].ToString()),
                        roomID
                        );
                    sensors.Add(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return sensors;
        }

        public static bool db_AddSensor(int typeID, int roomID)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramSensorType = new SqlParameter("@paramSensorType", SqlDbType.Int);
            paramSensorType.Value = typeID;
            SqlParameter paramRoomID = new SqlParameter("@paramRoomID", SqlDbType.Int);
            paramRoomID.Value = roomID;

            SqlCommand myCommand = new SqlCommand(
                "INSERT INTO dbo.PDC_Sensor (SensorTypeID, RoomID) VALUES (@paramSensorType, @paramRoomID)", myConnection);
            myCommand.Parameters.Add(paramSensorType);
            myCommand.Parameters.Add(paramRoomID);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return false;
        }

        public static int db_AddFloor(int cID, int flr, int noOfRooms)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection            
            SqlParameter paramFloor = new SqlParameter("@paramFloor", SqlDbType.Int);
            paramFloor.Value = flr;
            SqlParameter paramNoOfRooms = new SqlParameter("@paramNoOfRooms", SqlDbType.Int);
            paramNoOfRooms.Value = noOfRooms;
            SqlParameter paramCID = new SqlParameter("@ParamCID", SqlDbType.Int);
            paramCID.Value = cID;

            SqlCommand myCommand = new SqlCommand(
                "INSERT INTO dbo.PDC_Floor (FloorNum, NoOfRooms, CustomerID) VALUES (@paramFloor, @paramNoOfRooms, @ParamCID); "
                + "SELECT CAST(scope_identity() AS int)", myConnection);
            myCommand.Parameters.Add(paramFloor);
            myCommand.Parameters.Add(paramNoOfRooms);
            myCommand.Parameters.Add(paramCID);

            try
            {
                myConnection.Open();
                int id = (int)myCommand.ExecuteScalar();
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return -1;
        }

        public static List<Floor> db_GetFloors(int CustomerID)
        {
            List<Floor> floors = new List<Floor>();
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramID = new SqlParameter("@ParamID", SqlDbType.Int);
            paramID.Value = CustomerID;

            SqlCommand myCommand = new SqlCommand(
                "SELECT * FROM dbo.PDC_Floor WHERE CustomerID = @ParamID", myConnection);
            myCommand.Parameters.Add(paramID);

            SqlDataReader myReader = null;

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {

                    Floor f = new Floor(
                        (int)myReader["FloorID"],
                        (int)myReader["FloorNum"],
                        (int)myReader["NoOfRooms"],
                        (int)myReader["CustomerID"]
                        );
                    floors.Add(f);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return floors;
        }
    }
}
