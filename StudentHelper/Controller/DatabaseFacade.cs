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
        public void CreatEvent(Model.Event cevent) {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand("CreateEvent", dbconn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlDay = new SqlParameter("@E_Day", cevent.Day);
                cmd.Parameters.Add(sqlDay);

                SqlParameter sqlStartDate = new SqlParameter("@E_StartDate", cevent.StartDate);
                cmd.Parameters.Add(sqlStartDate);

                SqlParameter sqlEndDate = new SqlParameter("@E_EndDate", cevent.EndDate);
                cmd.Parameters.Add(sqlEndDate);

                SqlParameter sqlSubjectID = new SqlParameter("@E_S_SubjectID", cevent.SubjectID);
                cmd.Parameters.Add(sqlSubjectID);

                SqlParameter sqlDescription = new SqlParameter("@E_Description", cevent.Description);
                cmd.Parameters.Add(sqlDescription);

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
