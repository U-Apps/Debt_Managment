using System;
using System.Data;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer       
{
    public static class clsClient_Data
    {

        public static bool GetClientInfoByID(int ClientID, ref string Name,
        ref string Email, ref string Phone, ref string Address,ref string SSN,
           ref string Commercial_Registration,ref int Classification, ref double RemainderAmoun)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT tblPersons.*, tblClients.*
                             FROM     tblClients INNER JOIN
                        tblPersons ON tblClients.PersonID = tblPersons.PersonID
                        where tblClients.ClientID = @ClientID;";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@ClientID", ClientID);

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
                    Classification = (int)reader["Classification"];
                    RemainderAmoun = (int)reader["RemainderAmoun"];


                    //ssn: allows null in database so we should handle null

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";


                    if (reader["SSN"] != DBNull.Value)
                        SSN = (string)reader["SSN"];
                    else
                        SSN = "";


                    if (reader["Commercial_Registration"] != DBNull.Value)
                        Commercial_Registration = (string)reader["Commercial_Registration"];
                    else
                        Commercial_Registration = "";
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

        public static int AddNewClient(string Name, string Email, string Phone, string Address,string SSN,
            string Commercial_Registration,int Classification,double RemainderAmount)
        {
            //this function will return the new client id if succeeded and -1 if not.
            int ClientID = -1;

            int PersonID = clsPersons_Data.AddNewPerson(Name, Email, Phone, Address);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO tblClients
                            values (@PersonID,
                                    @SSN,
                                    @Commercial_Registration,
                                    @Classification,
                                    @RemainderAmount)
                                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID",PersonID);
            command.Parameters.AddWithValue("@Classification", Classification);
            command.Parameters.AddWithValue("@RemainderAmount", RemainderAmount);


            if (SSN != "")
                command.Parameters.AddWithValue("@SSN", SSN);
            else
                command.Parameters.AddWithValue("@SSN", System.DBNull.Value);


            if (Commercial_Registration !="")
                command.Parameters.AddWithValue("@Commercial_Registration", Commercial_Registration);
            else
                command.Parameters.AddWithValue("@Commercial_Registration", System.DBNull.Value);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ClientID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ClientID;
            }

            finally
            {
                connection.Close();
            }


            return ClientID;
        }


        public static bool UpdateClient(int ClientID,string Name, string Email, string Phone, string Address, double RemainderAmount)
        {

            int PersonID = _GetPersonID_ByClientID(ClientID);
            if (PersonID == 0)
                return false;




            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                            Update  tblClients  
                            set SSN = @SSN, 
                                Commercial_Registration = @Commercial_Registration, 
                                Classification = @Classification, 
                                RemainderAmount = @RemainderAmount
                                where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@RemainderAmount", RemainderAmount);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            if (clsPersons_Data.UpdatePerson(PersonID, Name, Email, Phone, Address))
                return false;
           


            return (rowsAffected > 0);
        }

        public static bool DeleteClient(int ClientID)
        {
            int PersonID = _GetPersonID_ByClientID(ClientID);
            if (PersonID == -1)
                return false;


            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from tblClients where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                clsPersons_Data.DeletePerson(PersonID);        //will delete the person record after deleting the client record

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


        public static DataTable GetAllClients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT tblClients.ClientID, tblPersons.Name, 
		                    tblPersons.PhoneNumber,
		                    tblPersons.Email,
		                    tblPersons.Address,
		                    tblClients.SSN, 
		                    tblClients.RemainderAmount

                            FROM     tblClients INNER JOIN
                                      tblPersons ON tblClients.PersonID = tblPersons.PersonID";

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


        public static bool IsClientExist(int ClientID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM tblClients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@ClientID", ClientID);

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


        static int _GetPersonID_ByClientID(int ClientID)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT PersonID FROM tblClients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

