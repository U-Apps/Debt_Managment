using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagment_DataAccessLayer
{
    internal class SupplierDebts
    {

        public static int NewSupplierDebt(int UserID, int SupplierID, double DebtAmount, string Material, DateTime DebtDate)
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

        public static bool UpdateSupplierDebt(int DebtID, int UserID, int SupplierID, double DebtAmount, string Material, DateTime DebtDate)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE DebtsToSuppliers

                             SET UserID = @UserID,
                                 SupplierID  = @SupplierID,
                                 Material = @Material,
                                 DebtAmount = @DebtAmount,
                                 DebtDate = @DebtDate   WHERE DebtID = @DebtID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DebtID", DebtID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.Parameters.AddWithValue("@Material", Material);
            command.Parameters.AddWithValue("@DebtAmount", DebtAmount);
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
    }
}
