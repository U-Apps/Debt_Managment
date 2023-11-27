﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    public static  class clsClientsDebtsData
    {
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


            return ClientID;
        }

        public static bool UpdateClientDebt(int DebtID, int UserID, int ClientID, double DebtAmount, string Material, DateTime DebtDate)
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
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@DebtAmount", DebtAmount);
            command.Parameters.AddWithValue("@Material", Material);
            command.Parameters.AddWithValue("@DebtDate", DebtDate);



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



    }
}
