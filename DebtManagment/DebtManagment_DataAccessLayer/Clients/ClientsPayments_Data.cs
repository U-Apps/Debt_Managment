﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    public class clsClientsPayments_Data
    {

        public static DataTable GetAllClientsPayments()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM ClientsPayments";

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

        public static int AddNewClientPayment(int UserID, int ClientID, double PayedAmount, DateTime PaymentDate)
        {
            //this function will return the new payment id if succeeded and -1 if not.
            int PaymentID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into ClientsPayments
                            values (@UserID,@ClientID,@PayedAmount,@PaymentDate)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
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

        public static bool UpdateClientPayment(int PaymentID, int UserID, int ClientID, double PayedAmount, DateTime PaymentDate)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE ClientsPayments
                                SET UserID = @UserID,
                                    ClientID  = @ClientID,
                                    PayedAmount = @PayedAmount,
                                    PaymentDate = @PaymentDate
                                    WHERE PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
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