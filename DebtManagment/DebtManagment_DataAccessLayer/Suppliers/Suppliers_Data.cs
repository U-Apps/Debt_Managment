using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    public static class clsSupplier_Data
    {

        public static bool GetSupplierInfoByID(int SupplierID, ref string Name,
        ref string Email, ref string Phone, ref string Address,
           ref int Commercial_Registration)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT tblSuppliers.*, tblPersons.*
FROM     tblSuppliers INNER JOIN
                  tblPersons ON tblSuppliers.PersonID = tblPersons.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", SupplierID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    int PersonID = (int)reader["PersonID"];
                    Name = (string)reader["Name"];
                    Phone = (string)reader["PhoneNumber"];
                    Address = (string)reader["Address"];
                    Commercial_Registration = (int)reader["Commercial_Registration"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";





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


        public static int AddNewSupplier(string Name, string Email, string Phone, string Address,
           int Commercial_Registration)
        {
            //this function will return the new supplier id if succeeded and -1 if not.
            int SupplierID = -1;

            int PersonID = clsPersons_Data.AddNewPerson(Name, Email, Phone, Address);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO tblSuppliers
                            values (@PersonID,@Commercial_Registration)
                                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Commercial_Registration", Commercial_Registration);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    SupplierID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return SupplierID;
            }

            finally
            {
                connection.Close();
            }


            return SupplierID;
        }


        public static bool UpdateSupplier(int SupplierID, string Name, string Email, string Phone, string Address,
            int Commercial_Registration)
        {

            int PersonID = _GetPersonID_BySupplierID(SupplierID);
            if (PersonID == -1)
                return false;


            clsPersons_Data.UpdatePerson(PersonID, Name, Email, Phone, Address);


            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  tblSuppliers  
                            set  Commercial_Registration = @Commercial_Registration 
                                 where SupplierID = @SupplierID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", SupplierID);
            command.Parameters.AddWithValue("@Commercial_Registration", Commercial_Registration);

            
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool DeleteSupplier(int SupplierID)
        {
            int PersonID = _GetPersonID_BySupplierID(SupplierID);
            if (PersonID == -1)
                return false;


            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete tblSuppliers 
                                where SupplierID =@SupplierID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", SupplierID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                clsPersons_Data.DeletePerson(PersonID);        //will delete the person record after deleting the supplier record

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

        public static DataTable GetAllSuppliers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT tblSuppliers.SupplierID, tblPersons.Name, 
		                    tblPersons.PhoneNumber,
		                    tblPersons.Email,
		                    tblPersons.Address,
		                    tblSuppliers.Commercial_Registration

                            FROM     tblSuppliers INNER JOIN
                                      tblPersons ON tblSuppliers.PersonID = tblPersons.PersonID;";

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

        public static bool IsSupplierExist(int SupplierID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM tblSuppliers WHERE SupplierID = @SupplierID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", SupplierID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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

        static int _GetPersonID_BySupplierID(int SupplierID)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT PersonID FROM tblSuppliers WHERE SupplierID = @SupplierID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", SupplierID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    PersonID = (int)result;
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

            return PersonID;
        }

    }
}
