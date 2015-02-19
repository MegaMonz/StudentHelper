using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentHelper.Controller
{
    class DatabaseFacade
    {
        static SqlConnection dbconn;
        static string _connectionString = "Server=ealdb1.eal.local;" + "Database=EJL04_DB;" + "User Id=ejl04_usr;" + "Password=Baz1nga4;";
        public CreatEvent(Model.Event Event) {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand("CreateEvent", dbconn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlModel = new SqlParameter("@E_Day", Event.Day);
                cmd.Parameters.Add(sqlModel);

                SqlParameter sqlSensorID = new SqlParameter("@SensorID", sensor.SensorID);
                cmd.Parameters.Add(sqlSensorID);

                SqlParameter sqlCprNr = new SqlParameter("@CPRNR", sensor.P_CprNr);
                cmd.Parameters.Add(sqlCprNr);

                SqlParameter sqlBatteryLastCharged = new SqlParameter("@BatteryLastCharged", sensor.BatteryLastChanged);
                cmd.Parameters.Add(sqlBatteryLastCharged);

                cmd.ExecuteNonQuery();

                CloseDB();
            }
            catch (Exception e)
            {

                throw new Exception("Error in Store Person: " + e.Message);
            }
        }

        private static void ConnectDB()
        {
            dbconn = new SqlConnection(_connectionString);
            dbconn.Open();
        }

        private static void CloseDB()
        {
            dbconn.Close();
        }
    }
}
