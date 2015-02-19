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
        string DBConnectionString = "Server=ealdb1.eal.local;" + "Database=EJL04_DB;" + "User Id=ejl04_usr;" + "Password=Baz1nga4;";
        public List<Model.Event> GetWeeks()
        {
            List<Model.Event> WeekList = new List<Model.Event>();

            SqlConnection SqlConnection = new SqlConnection(DBConnectionString);

            //try
            //{
            //    SqlConnection.Open();

            //    SqlCommand cmd = new SqlCommand("StoredProcedure", SqlConnection);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlDataReader rdr = cmd.ExecuteReader();

            //    while (rdr.Read() && rdr.HasRows)
            //    {
            //        WeekList.Add(new Model.Event(int.Parse(rdr["Parameter"].ToString())));
            //    }
            //}
            //catch (SqlException e)
            //{
            //    System.Windows.MessageBox.Show(e.Message);

            //}
            //finally
            //{
            //    SqlConnection.Close();
            //    SqlConnection.Dispose();
            //}

            return WeekList;


        }
    }
}
