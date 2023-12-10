using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    public static class clsClientsPayments_Data
    {

        public static DataTable GetAllClientsPayments()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT ClientsPayments.PaymentID, ClientsPayments.UserID, ClientsPayments.ClientID, tblPersons.Name, ClientsPayments.PayedAmount, ClientsPayments.PaymentDate
                    FROM     ClientsPayments INNER JOIN
                  tblClients ON ClientsPayments.ClientID = tblClients.ClientID INNER JOIN
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


        public static bool GetClientPaymentByID(int PaymentID,ref int UserID , ref int ClientID,ref double PayedAmount, ref DateTime PaymentDate)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from ClientsPayments where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    UserID = (int)reader["UserID"];

                    ClientID = (int)reader["ClientID"];
                    PayedAmount =double.Parse( reader["PayedAmount"].ToString());
                    PaymentDate = (DateTime)reader["PaymentDate"];


                    //ssn: allows null in database so we should handle null


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static int AddNewClientPayment(int UserID, int ClientID, double PayedAmount)
        {
            //this function will return the new payment id if succeeded and -1 if not.
            int PaymentID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into ClientsPayments
                            values (@UserID,@ClientID,@PayedAmount,@PaymentDate)
                            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@PayedAmount", PayedAmount);
            command.Parameters.AddWithValue("@PaymentDate", DateTime.Now);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PaymentID = insertedID;
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


            return PaymentID;
        }

        public static bool UpdateClientPayment(int PaymentID, double PayedAmount)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE ClientsPayments
                                SET PayedAmount = @PayedAmount,
                                    PaymentDate = @PaymentDate
                                    WHERE PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@PayedAmount", PayedAmount);
            command.Parameters.AddWithValue("@PaymentDate", DateTime.Now);




            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return (rowsAffected > 0);
        }

        public static bool DeleteClientPayment(int PaymentID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from ClientsPayments where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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


        public static DataTable GetAllClientPayments(int ClientID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ClientsPayments.PaymentID ,PayedAmount as 'Payed Amount' , PaymentDate as 'Payment Date'  from ClientsPayments
                    WHERE ClientID = @ClientID";

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


        public static double GetTotalPaymentsForCertainClient(int ClientID)
        {

            double TotalClientPayments = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalPayments = sum(PayedAmount) from ClientsPayments
                            where ClientID = @ClientID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                
                if (Result != null && double.TryParse(Result.ToString(), out TotalClientPayments))
                {
                    connection.Close();
                    return TotalClientPayments;
                }
                else
                {
                    TotalClientPayments = 0;
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

            return TotalClientPayments;
        }
        public static double GetTotalPaymentsForClients()
        {

            double TotalClientPayments = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalPayments = sum(PayedAmount) from ClientsPayments";

            SqlCommand command = new SqlCommand(query, connection);



            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && double.TryParse(Result.ToString(), out TotalClientPayments))
                {
                    connection.Close();
                    return TotalClientPayments;
                }
                else
                {
                    TotalClientPayments = 0;
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

            return TotalClientPayments;
        }



    }
}
