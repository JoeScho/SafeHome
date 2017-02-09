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

        public static List<Room> db_GetRooms(int CustomerID)
        {
            List<Room> rooms = new List<Room>();
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramID = new SqlParameter("@ParamID", SqlDbType.VarChar);
            paramID.Value = CustomerID;

            SqlCommand myCommand = new SqlCommand(
                "SELECT * FROM dbo.PDC_Room WHERE CustomerID = @ParamID", myConnection);
            myCommand.Parameters.Add(paramID);

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

                    Room r = new Room(
                        (int)myReader["RoomID"],
                        myReader["RoomName"].ToString(),
                        CustomerID,
                        (int)myReader["FloorNumber"],
                        n,
                        myReader.GetBoolean(myReader.GetOrdinal("DoorNorth")),
                        e,
                        myReader.GetBoolean(myReader.GetOrdinal("DoorEast")),
                        s,
                        myReader.GetBoolean(myReader.GetOrdinal("DoorSouth")),
                        w,
                        myReader.GetBoolean(myReader.GetOrdinal("DoorWest"))
                        );
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

        public static List<string> getSensorTypes()
        {
            List<string> sensorTypes = new List<string>();
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            SqlCommand myCommand = new SqlCommand(
                "SELECT SensorName FROM dbo.PDC_SensorType", myConnection);

            SqlDataReader myReader = null;

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    sensorTypes.Add(myReader["SensorName"].ToString()); 
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

        public static bool db_AddRoom(Room r)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramRoomName = new SqlParameter("@paramRoomName", SqlDbType.VarChar);
            paramRoomName.Value = r.RoomName1;
            SqlParameter paramCID = new SqlParameter("@ParamCID", SqlDbType.Int);
            paramCID.Value = r.CustomerID1;
            SqlParameter paramFloor = new SqlParameter("@paramFloor", SqlDbType.VarChar);
            paramFloor.Value = r.Floor1;
            SqlParameter paramRoomN = new SqlParameter("@paramRoomN", SqlDbType.VarChar);
            paramRoomN.Value = r.RoomIDNorth1;
            SqlParameter paramDoorN = new SqlParameter("@paramDoorN", SqlDbType.VarChar);
            paramDoorN.Value = r.DoorNorth1;
            SqlParameter paramRoomE = new SqlParameter("@paramRoomE", SqlDbType.VarChar);
            paramRoomE.Value = r.RoomIDEast1;
            SqlParameter paramDoorE = new SqlParameter("@paramDoorE", SqlDbType.VarChar);
            paramDoorE.Value = r.DoorEast1;
            SqlParameter paramRoomS = new SqlParameter("@paramRoomS", SqlDbType.VarChar);
            paramRoomS.Value = r.RoomIDSouth1;
            SqlParameter paramDoorS = new SqlParameter("@paramDoorS", SqlDbType.VarChar);
            paramDoorS.Value = r.DoorSouth1;
            SqlParameter paramRoomW = new SqlParameter("@paramRoomW", SqlDbType.VarChar);
            paramRoomW.Value = r.RoomIDWest1;
            SqlParameter paramDoorW = new SqlParameter("@paramDoorW", SqlDbType.VarChar);
            paramDoorW.Value = r.DoorWest1;

            SqlCommand myCommand = new SqlCommand(
                "INSERT INTO dbo.PDC_Room (RoomID, RoomName, CustomerID, FloorNumber, RoomIDNorth, DoorNorth, RoomIDEast, DoorEast, RoomIDSouth, DoorSouth, RoomIDWest, DoorWest) VALUES (@paramRoomName,@ParamCID,@paramFloor,@paramRoomN,@paramDoorN,@paramRoomE,@paramDoorE,@paramRoomS,@paramDoorS,@paramRoomW,@paramDoorW)", myConnection);
            myCommand.Parameters.Add(paramRoomName);
            myCommand.Parameters.Add(paramCID);
            myCommand.Parameters.Add(paramFloor);
            myCommand.Parameters.Add(paramRoomN);
            myCommand.Parameters.Add(paramDoorN);
            myCommand.Parameters.Add(paramRoomE);
            myCommand.Parameters.Add(paramDoorE);
            myCommand.Parameters.Add(paramRoomS);
            myCommand.Parameters.Add(paramDoorS);
            myCommand.Parameters.Add(paramRoomW);
            myCommand.Parameters.Add(paramDoorW);

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
    }
}
