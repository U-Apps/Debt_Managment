using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    public static class clsDebtsToSuppliers_Data
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

       

        public static bool GetDebtToSupplierByID(int DebtID, ref double AmountOfDebt, ref DateTime DateOfDebt, ref string Material,ref int SupplierID, ref int UserID)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from DebtsToSuppliers where ID = @DebtID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DebtID", DebtID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    SupplierID = (int)reader["SupplierID"];
                    AmountOfDebt = double.Parse( reader["AmountOFDebt"].ToString());
                    DateOfDebt = (DateTime)reader["DateOfDebt"];
                    Material = (string)reader["Material"];
                    UserID = (int)reader["UserID"];


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

            string query = @"delete from DebtsToSuppliers where ID = @DebtID";

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
                                 AmountOFDebt = @DebtAmount WHERE ID = @DebtID
                                ";

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

            string query = @"select ID, AmountOFDebt as 'Amount of Debt', Material , DateOfDebt as 'Date of Debt' from DebtsToSuppliers
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
        public static double GetTotalDebtsToSuppliers()
        {

            double TotalDebtsToCertainSupplier = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TotalDebt = sum(AmountOfDebt) from DebtsToSuppliers";

            SqlCommand command = new SqlCommand(query, connection);

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
