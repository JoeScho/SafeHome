using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace API
{
    class DBConnection
    {        
        public static string checkSystemStatus(int CustomerID)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramID = new SqlParameter("@ParamID", SqlDbType.Int);
            paramID.Value = CustomerID;

            SqlCommand myCommand = new SqlCommand(
                "SELECT SystemState FROM dbo.PDC_Customer WHERE CustomerID = @ParamID", myConnection);
            myCommand.Parameters.Add(paramID);

            SqlDataReader myReader = null;

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    return myReader["SystemState"].ToString();
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
            return null;
        }

        public static List<SensorEvent> getEvents(int CustomerID)
        {
            List<SensorEvent> events = new List<SensorEvent>();
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramID = new SqlParameter("@ParamID", SqlDbType.Int);
            paramID.Value = CustomerID;

            SqlCommand myCommand = new SqlCommand(
                "select se.SensorID, se.EventTime, se.Detail from PDC_SensorEvent se "
                   + "INNER JOIN PDC_Sensor s ON se.SensorID = s.SensorID "
                   + "INNER JOIN PDC_Room r ON s.RoomID = r.RoomID "
                   + "INNER JOIN PDC_Customer c ON r.CustomerID = c.CustomerID "
                   + "WHERE c.LastTimeArmed < se.EventTime "
                   + "AND c.CustomerID = @paramID", myConnection);
            myCommand.Parameters.Add(paramID);

            SqlDataReader myReader = null;

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int sID = int.Parse(myReader["SensorID"].ToString());
                    DateTime date1;
                    DateTime.TryParse(myReader["EventTime"].ToString(), out date1);
                    string detail = myReader["Detail"].ToString();
                    SensorEvent se = new SensorEvent(sID, date1, detail);
                    events.Add(se);
                }
                return events;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return null;
        }

        public static void SetSystemStatus(int CustomerID, string Action)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramID = new SqlParameter("@ParamID", SqlDbType.Int);
            paramID.Value = CustomerID;

            SqlCommand myCommand = new SqlCommand(
                "UPDATE PDC_Customer SET SystemState = '" + Action + "' WHERE CustomerID = @ParamID", myConnection);
            myCommand.Parameters.Add(paramID);

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

        public static void SetArmTime(int CustomerID)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramID = new SqlParameter("@ParamID", SqlDbType.Int);
            paramID.Value = CustomerID;

            SqlCommand myCommand = new SqlCommand(
                "UPDATE PDC_Customer SET LastTimeArmed = GETDATE() WHERE CustomerID = @ParamID", myConnection);
            myCommand.Parameters.Add(paramID);

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

        public static void submitSensorReading(int sensorID, string detail)
        {
            SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SafeHomeConnectionString);

            // Parameterise input to avoid SQL Injection
            SqlParameter paramSID = new SqlParameter("@paramSID", SqlDbType.Int);
            paramSID.Value = sensorID;
            SqlParameter paramDetail = new SqlParameter("@paramDetail", SqlDbType.VarChar);
            paramDetail.Value = detail;

            SqlCommand myCommand = new SqlCommand(
                "INSERT INTO PDC_SensorEvent (SensorID,Detail) VALUES (@paramSID, @paramDetail)", myConnection);
            myCommand.Parameters.Add(paramSID);
            myCommand.Parameters.Add(paramDetail);

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
    }
}
