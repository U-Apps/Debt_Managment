using System;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    internal static class clsPersons_Data
    { 
        public static int AddNewPerson(string Name,
            string Email, string Phone, string Address)
        {
            Name = Name.Trim();
            Email = Email.Trim();
            Phone = Phone.Trim();
            Address = Address.Trim();

            //this function will return the new person id if succeeded and -1 if not.
            int PersonID = -1;



             // check if person already exists return true and update the personID or return false
            if (_IsPersonExists(ref PersonID, Name, Phone, Address))
                return PersonID;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [tblPersons]
                            ([Name]
                            ,[PhoneNumber]
                            ,[Email]
                            ,[Address])
                            VALUES
                            (@Name,@Phone,@Email,@Address)
                                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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


        public static bool UpdatePerson(int PersonID, string Name,
            string Email, string Phone, string Address)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  tblPersons  
                            set Name = @Name, 
                                Email = @Email, 
                                PhoneNumber = @Phone, 
                                Address = @Address
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Eamil", System.DBNull.Value);


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


        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;

            

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from tblPersons where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool GetPersonInfoByID(int PersonID, ref string Name,
                ref string Email, ref string Phone, ref string Address)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM tblPersons WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    Name = (string)reader["Name"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

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


        private static bool _IsPersonExists(ref int PersonID, string Name, string Phone, string Address)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT PersonID FROM tblPersons WHERE Name = @Name and PhoneNumber = @Phone and Address = @Address";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out PersonID))
                {
                    isFound = true;
                }

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

    }
}
        
