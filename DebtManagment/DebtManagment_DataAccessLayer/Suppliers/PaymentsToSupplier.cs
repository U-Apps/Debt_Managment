using System;
using System.Data;
using System.Data.SqlClient;


namespace DebtManagment_DataAccessLayer
{
    public static  class PaymentsToSupplier

    {
        public static DataTable GetAllPaymentsToSuppliers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT PaymentsToSuppliers.ID, PaymentsToSuppliers.UserID, tblSuppliers.SupplierID, tblPersons.Name, PaymentsToSuppliers.PayedAmount, PaymentsToSuppliers.PaymentDate
                    FROM     PaymentsToSuppliers INNER JOIN
                  tblSuppliers ON PaymentsToSuppliers.SupplierID = tblSuppliers.SupplierID INNER JOIN
                  tblPersons ON tblSuppliers.PersonID = tblPersons.PersonID INNER JOIN
                  tblUsers ON PaymentsToSuppliers.UserID = tblUsers.UserID AND tblPersons.PersonID = tblUsers.PersonID";

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

        public static bool GetPaymentToSupplierByID(int ID,ref int UserID,ref int SupplierID, ref double PayedAmount, ref DateTime PaymentDate)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from PaymentsToSuppliers where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    UserID = (int)reader["UserID"];

                    SupplierID = (int)reader["SupplierID"];
                    PayedAmount = double.Parse(reader["PayedAmount"].ToString());
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

        public static DataTable GetAllPaymentsToCertainSupplier(int SupplierID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ID,PayedAmount as 'Payed amount' , PaymentDate as 'Payment Date' from PaymentsToSuppliers
                                where SupplierID = @SupplierID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);


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

            string query = @"insert into PaymentsToSuppliers
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

        public static bool UpdatePaymentToSupplier(int PaymentID, double PayedAmount)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE PaymentsToSuppliers
                                SET PayedAmount = @PayedAmount
                                    WHERE ID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@PayedAmount", PayedAmount);




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

            string query = @"delete from PaymentsToSuppliers where ID = @PaymentID";

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

            string query = @"select TotalPayments = sum(PayedAmount) from PaymentsToSuppliers
                            where SupplierID = @SupplierID;";

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

        public static double GetTotalPaymentsToSupplier()
        {

            double TotalPaymentsToSupplier = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalPayments = sum(PayedAmount) from PaymentsToSuppliers;";

            SqlCommand command = new SqlCommand(query, connection);

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
