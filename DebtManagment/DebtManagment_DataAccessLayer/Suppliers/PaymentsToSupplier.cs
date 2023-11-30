using System;
using System.Data;
using System.Data.SqlClient;


namespace DebtManagment_DataAccessLayer
{
<<<<<<< Updated upstream
    public static class PaymentsToSupplier
=======
    public static  class PaymentsToSupplier
>>>>>>> Stashed changes
    {
        public static DataTable GetAllPaymentsToSupplier()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM PaymentsForSupliers";

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

        public static int AddNewPaymentToSupplier(int UserID, int SupplierID, double PayedAmount, DateTime PaymentDate)
        {
            //this function will return the new payment id if succeeded and -1 if not.
            int PaymentID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into PaymentsForSupliers
                            values (@UserID,@SupplierID,@PayedAmount,@PaymentDate)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.Parameters.AddWithValue("@PayedAmount", PayedAmount);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);



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

        public static bool UpdatePaymentToSupplier(int PaymentID, int UserID, int SupplierID, double PayedAmount, DateTime PaymentDate)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE PaymentsForSupliers
                                SET UserID = @UserID,
                                    SuplierID  = @SupplierID,
                                    PayedAmount = @PayedAmount,
                                    PaymentDate = @PaymentDate
                                    WHERE ID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.Parameters.AddWithValue("@PayedAmount", PayedAmount);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);



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

        public static bool DeletePaymentToSupplier(int PaymentID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from PaymentsForSupliers where ID = @PaymentID";

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

        public static double GetTotalPaymentsToCertainSupplier(int SupplierID)
        {

            double TotalPaymentsToSupplier = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalPayments = sum(PayedAmount) from PaymentsForSupliers
                            where SuplierID = @SupplierID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", SupplierID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && double.TryParse(Result.ToString(), out TotalPaymentsToSupplier))
                {
                    connection.Close();
                    return TotalPaymentsToSupplier;
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

            return TotalPaymentsToSupplier;
        }

    }
}
