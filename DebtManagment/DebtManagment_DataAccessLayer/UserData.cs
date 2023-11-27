using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagment_DataAccessLayer
{
    public class clsUserData
    {

        public static int AddNewUser(string Name, string Email, string Phone, string Address, int SSN,
            string PersonalPhoto, string Username, string Password, int Permissions)
        {
            //this function will return the new user id if succeeded and -1 if not.
            int UserID = -1;

            int PersonID = clsPersonsData.AddNewPerson(Name, Email, Phone, Address);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO tblUsers
                            values (@PersonID,@SSN,@PersonalPhoto,@Username,@Password,@Permissions)
                                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@SSN", SSN);


            if (PersonalPhoto != "")
                command.Parameters.AddWithValue("@PersonalPhoto", PersonalPhoto);
            else
                command.Parameters.AddWithValue("@PersonalPhoto", System.DBNull.Value);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return UserID;
            }

            finally
            {
                connection.Close();
            }


            return UserID;
        }

        public static bool GetUserInfoByID(int UserID, ref string Name, ref string Email, ref string Phone, ref string Address,
            ref int SSN, ref string PersonalPhoto, ref string Username, ref string Password, ref int Permissions)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM tblUsers WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    int PersonID = (int)reader["PersonID"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];

                    if (!clsPersonsData.GetPersonInfoByID(PersonID, ref Name, ref Email, ref Phone, ref Address))
                        return false;


                    //ssn: allows null in database so we should handle null
                    if (reader["SSN"] != DBNull.Value)
                        SSN = (int)reader["SSN"];
                    else
                        SSN = 0;

                    //PersonalPhoto: allows null in database so we should handle null
                    if (reader["PersonalPicture"] != DBNull.Value)
                        PersonalPhoto = (string)reader["PersonalPicture"];
                    else
                        PersonalPhoto = "";



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

        public static bool UpdateUser(int UserID,string Name, string Email, string Phone, string Address, int SSN,
            string PersonalPhoto, string Username, string Password, int Permissions)
        {


            if (_IsUsernameExsist(Username)) // Updating the Usename requirs checking if the new username exsist already 
                return false;


            int PersonID = _GetPersonID_ByUserID(UserID);
            if (PersonID == 0)
                return false;




            clsPersonsData.UpdatePerson(PersonID, Name, Email, Phone, Address);


            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  tblUsers  
                            set  SSN=@SSN,
                                 PersonalPhoto = @PersonalPhoto ,
                                 Username=@Username,
                                 Password=@Password,
                                 Permissions=@Permissions; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            if (SSN != 0 && SSN != null)
                command.Parameters.AddWithValue("@SSN", SSN);
            else
                command.Parameters.AddWithValue("@SSN", System.DBNull.Value);

            if (PersonalPhoto != "" && PersonalPhoto != null)
                command.Parameters.AddWithValue("@PersonalPhoto", PersonalPhoto);
            else
                command.Parameters.AddWithValue("@PersonalPhoto", System.DBNull.Value);


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

        public static bool DeleteUser(int UserID)
        {
            int PersonID = _GetPersonID_ByUserID(UserID);
            if (PersonID == 0)
                return false;


            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete tblUsers 
                                where UserID =@UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                clsPersonsData.DeletePerson(PersonID);        //will delete the person record after deleting the user record

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

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT tblUsers.UserID, tblPersons.Name, 
		                    tblPersons.PhoneNumber,
		                    tblPersons.Email,
		                    tblPersons.Address,
		                    tblUsers.SSN, 
		                    tblUsers.Username, 
		                    tblUsers.Password, 
		                    tblUsers.Permissions,
							tblUsers.PersonalPhoto

                            FROM     tblUsers INNER JOIN
                                      tblPersons ON tblUsers.PersonID = tblPersons.PersonID;";

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

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM tblUsers WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        static int _GetPersonID_ByUserID(int UserID)
        {
            int PersonID = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT PersonID FROM tblUsers WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        private static bool _IsUsernameExsist(string Username)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM tblUsers WHERE Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

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


    }
}
