
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
     public static class clsDataAccessSettings
    {
        public static string Server { get; set; } = ".";
        //public static string Database = "Debt_Managment_DB";
        public static string User_ID { get; set; } = "sa";
        public static string Password { get; set; } = "1234";
        public static string ConnectionString { 
            get
            {
                // return $"Server={Server};Database=Debt_Managment_DB;User Id={User_ID};Password={Password};";
                 return $"Server={Server};Database=Debt_Managment_DB; Integrated Security =True;";

            }
        }
        public static bool BackUp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand(@"backup DataBase Debt_Managment_DB to Disk = '[DeptManegmentDevice]' with init", sqlConnection);


            try
            {
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public static bool restore()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand(@"use master Restore DataBase Debt_Managment_DB from Disk = '[DeptManegmentDevice]' with replace , recovery", sqlConnection);


            try
            {
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
