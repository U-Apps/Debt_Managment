using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    public static  class clsClientsDebts_Data
    {

        public static DataTable GetAllClientsDebts()
            {

                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"SELECT ClientsDebts.DebtID, ClientsDebts.UserID, tblClients.ClientID, tblPersons.Name as Client_Name, ClientsDebts.DebtAmount, ClientsDebts.Material, ClientsDebts.DebtDate
                    FROM     ClientsDebts INNER JOIN
                  tblClients ON ClientsDebts.ClientID = tblClients.ClientID INNER JOIN
                  tblPersons ON tblClients.PersonID = tblPersons.PersonID";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)

                    {
                        dt.Load(reader);
                    }

                    reader.Close();


                }

                catch (Exception ex)
                {
                    // Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                return dt;

            }

        public static int AddNewClientDebt(int UserID, int ClientID, double DebtAmount ,string Material, DateTime DebtDate)
        {
            //this function will return the new debt id if succeeded and -1 if not.
            int DebtID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into ClientsDebts
                            values (@UserID,@ClientID,@DebtAmount,@Material,@DebtDate)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@DebtAmount", DebtAmount);
            command.Parameters.AddWithValue("@Material", Material);
            command.Parameters.AddWithValue("@DebtDate", DebtDate);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DebtID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }


            return DebtID;
        }

        public static bool UpdateClientDebt(int DebtID,  double DebtAmount, string Material )
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"UPDATE ClientsDebts
                                SET UserID = @UserID,
                                    ClientID  = @ClientID,
                                    DebtAmount = @DebtAmount,
                                    Material = @Material,
                                    DebtDate = @DebtDate
                                    WHERE DebtID = @DebtID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DebtID", DebtID);
            command.Parameters.AddWithValue("@DebtAmount", DebtAmount);
            command.Parameters.AddWithValue("@Material", Material);



            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                connection.Close();
                return false;
            }

            finally
            {
                connection.Close();
            }


            return (rowsAffected > 0);
        }

        public static bool DeleteClientDebt(int DebtID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from ClientsDebts where DebtID = @DebtID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DebtID", DebtID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
   
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }


        public static DataTable GetAllDebtsForCertainClient(int ClientID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT ClientsDebts.DebtID, ClientsDebts.UserID, ClientsDebts.ClientID, tblPersons.Name, ClientsDebts.DebtAmount, ClientsDebts.Material, ClientsDebts.DebtDate
                FROM     ClientsDebts INNER JOIN
                  tblClients ON ClientsDebts.ClientID = tblClients.ClientID INNER JOIN
                  tblPersons ON tblClients.PersonID = tblPersons.PersonID
				  Where tblClients.ClientID = 8";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }


        public static double GetTotalDebtsForCertainClient(int ClientID)
        {

            double TotalDebtForClient = 0;
           

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalDebt = sum(DebtAmount) from ClientsDebts
                            where ClientID = @ClientID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && double.TryParse(Result.ToString(), out TotalDebtForClient))
                {
                    connection.Close();
                    return TotalDebtForClient;
                }

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return TotalDebtForClient;
        }


    }
}
