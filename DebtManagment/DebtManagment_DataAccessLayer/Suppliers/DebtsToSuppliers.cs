﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    public static class clsDebtsToSuppliers
    {

        public static DataTable GetAllDebtsToSuppliers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT DebtsToSuppliers.ID, DebtsToSuppliers.UserID, tblSuppliers.SupplierID, tblPersons.Name as Supplier_Name, DebtsToSuppliers.AmountOFDebt, DebtsToSuppliers.Material, DebtsToSuppliers.DateOfDebt
                    FROM     DebtsToSuppliers INNER JOIN
                  tblSuppliers ON DebtsToSuppliers.SupplierID = tblSuppliers.SupplierID INNER JOIN
                  tblPersons ON tblSuppliers.PersonID = tblPersons.PersonID";

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

        public static int AddNewSupplierDebt(int UserID, int SupplierID, double DebtAmount, string Material)
        {
            //this function will return the new debt id if succeeded and -1 if not.
            int DebtID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into DebtsToSuppliers
                            values (@UserID,@SupplierID,@Material,@DebtAmount,@DebtDate)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.Parameters.AddWithValue("@Material", Material);
            command.Parameters.AddWithValue("@DebtAmount", DebtAmount);
            command.Parameters.AddWithValue("@DebtDate", DateTime.Now);



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

        public static bool DeleteSupplierDebt(int DebtID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from DebtsToSuppliers where DebtID = @DebtID";

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

        public static bool UpdateSupplierDebt(int DebtID, double DebtAmount, string Material)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE DebtsToSuppliers
                             SET Material = @Material,
                                 DebtAmount = @DebtAmount WHERE DebtID = @DebtID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DebtID", DebtID);
            command.Parameters.AddWithValue("@Material", Material);
            command.Parameters.AddWithValue("@DebtAmount", DebtAmount);




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


        public static DataTable GetAllDebtsToCertainSupplier(int SupplierID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT DebtsToSuppliers.ID, DebtsToSuppliers.UserID, tblSuppliers.SupplierID, tblPersons.Name as Supplier_Name, DebtsToSuppliers.AmountOFDebt, DebtsToSuppliers.Material, DebtsToSuppliers.DateOfDebt
                    FROM     DebtsToSuppliers INNER JOIN
                  tblSuppliers ON DebtsToSuppliers.SupplierID = tblSuppliers.SupplierID INNER JOIN
                  tblPersons ON tblSuppliers.PersonID = tblPersons.PersonID WHERE SupplierID = @SupplierID";

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


        public static double GetTotalDebtsToCertainSupplier(int SupplierID)
        {

            double TotalDebtsToCertainSupplier = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalDebt = sum(AmountOfDebt) from DebtsToSuppliers
                            where SupplierID = @SupplierID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", SupplierID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && double.TryParse(Result.ToString(), out TotalDebtsToCertainSupplier))
                {
                    connection.Close();
                    return TotalDebtsToCertainSupplier;
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

            return TotalDebtsToCertainSupplier;
        }

    }
}
