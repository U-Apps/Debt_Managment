﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer
{
    public class clsUser_Data
    {

        public static bool GetUserInfoByID(int UserID, ref string Name, ref string Email, ref string Phone, ref string Address,
            ref string SSN, ref byte[] PersonalPhoto, ref string Username, ref string Password, ref int Permissions)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =  @"SELECT tblUsers.*, tblPersons.*
                            FROM tblUsers INNER JOIN
                            tblPersons ON tblUsers.PersonID = tblPersons.PersonID
                            where tblUsers.UserID = @UserID";

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
                    Name = (string)reader["Name"];
                    Phone = (string)reader["PhoneNumber"];
                    Address = (string)reader["Address"];
                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
                    SSN = (string)reader["SSN"];




                    //PersonalPhoto: allows null in database so we should handle null
                    if (reader["PersonalPicture"] != DBNull.Value)
                        PersonalPhoto = (byte[])reader["PersonalPicture"];
                    else
                        PersonalPhoto = new byte[] {};



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


        public static bool GetUserInfoByUsernameAndPassword(ref int UserID, ref string Name, ref string Email, ref string Phone,
            ref string Address,ref string SSN, ref byte[] PersonalPhoto, string Username, string Password, ref int Permissions)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT tblUsers.*, tblPersons.*
                            FROM tblUsers INNER JOIN
                            tblPersons ON tblUsers.PersonID = tblPersons.PersonID
							where tblUsers.Username = @Username and tblUsers.Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);


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
                    UserID = (int)reader["UserID"];
                    Permissions = (int)reader["Permissions"];
                    SSN = (string)reader["SSN"];


                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";


                    //PersonalPhoto: allows null in database so we should handle null
                    if (reader["PersonalPicture"] != DBNull.Value)
                        PersonalPhoto = (byte[])reader["PersonalPicture"];
                    else
                        PersonalPhoto = new byte[] {};



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



        public static int AddNewUser(string Name, string Email, string Phone, string Address, string SSN,
            byte[] ImageData, string Username, string Password, int Permissions)
        {
            //this function will return the new user id if succeeded and -1 if not.
            int UserID = -1;

            int PersonID = clsPersons_Data.AddNewPerson(Name, Email, Phone, Address);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO tblUsers
                            values (@PersonID,@SSN,@ImageData,@Username,@Password,@Permissions)
                                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@SSN", SSN);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);



            if (ImageData.Length != 0)
                command.Parameters.AddWithValue("@ImageData", ImageData);
            else
                command.Parameters.AddWithValue("@ImageData", System.DBNull.Value);



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


        public static bool UpdateUser(int UserID,string Name, string Email, string Phone, string Address, string SSN,
            byte[] ImageData, string Password, int Permissions)
        {


            int PersonID = _GetPersonID_ByUserID(UserID);
            if (PersonID == -1)
                return false;




            clsPersons_Data.UpdatePerson(PersonID, Name, Email, Phone, Address);


            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  tblUsers  
                            set  SSN=@SSN,
                                 PersonalPicture = @ImageData ,
                                 Password=@Password,
                                 Permissions=@Permissions
                                   where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@SSN", SSN);



            if (ImageData.Length != 0 && ImageData != null)
                command.Parameters.AddWithValue("@ImageData", ImageData);
            else
                command.Parameters.AddWithValue("@ImageData", System.DBNull.Value);


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
            if (PersonID == -1)
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
                clsPersons_Data.DeletePerson(PersonID);        //will delete the person record after deleting the user record

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

            string query = @"SELECT tblUsers.UserID as م, tblPersons.Name as الاسم, tblPersons.PhoneNumber 'رقم الجوال', tblPersons.Email as الايميل, tblUsers.SSN as 'الرقم الوطني',  tblUsers.Username as 'اسم المستخدم', tblUsers.Password as 'كلمة المرور'
                        FROM     tblUsers INNER JOIN
                  tblPersons ON tblUsers.PersonID = tblPersons.PersonID";

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

      //  public static bool IsUserExist(string Username, string Password,ref int UserID, ref string Name, ref string Email,ref string Phone,
      //      ref string Address,ref string SSN,
      //      ref string PersonalPhoto, ref int Permissions)
      //  {
      //      bool isFound = false;

      //      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

      //      string query = @"SELECT tblUsers.*, tblPersons.*
      //          FROM     tblUsers INNER JOIN
      //            tblPersons ON tblUsers.PersonID = tblPersons.PersonID
				  //where tblUsers.Username = @Username and tblUsers.Password = @Password";

      //      SqlCommand command = new SqlCommand(query, connection);

      //      command.Parameters.AddWithValue("@Username", Username);
      //      command.Parameters.AddWithValue("@Password", Password);


      //      try
      //      {
      //          connection.Open();
      //          SqlDataReader reader = command.ExecuteReader();

      //          if (reader.HasRows)
      //          {
      //              isFound = true;
      //              UserID = (int)reader["UserID"]; 
      //              Name = (string)reader["Name"];
      //              Phone = (string)reader["PhoneNumber"];
      //              Address = (string)reader["Address"];
      //              SSN = (string)reader["SSN"];
      //              Permissions = (int)reader["Permissions"];
      //              Email = (string)reader["Email"];

      //              if (reader["PersonalPicture"] != DBNull.Value)
      //                  PersonalPhoto = (string)reader["PersonalPicture"];
      //              else
      //                  PersonalPhoto = "";
      //          }

      //          reader.Close();
      //      }
      //      catch (Exception ex)
      //      {
      //          //Console.WriteLine("Error: " + ex.Message);
      //          isFound = false;
      //      }
      //      finally
      //      {
      //          connection.Close();
      //      }

      //      return isFound;
      //  }


        private static int _GetPersonID_ByUserID(int UserID)
        {
            int PersonID = -1;

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



    }
}
