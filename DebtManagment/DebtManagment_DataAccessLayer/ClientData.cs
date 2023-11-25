using System;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer       //[Database]
{
    public class clsClientData
    {

        public static bool GetClientInfoByID(int ClientID, ref string Name,
        ref string Email, ref string Phone, ref string Address,ref int SSN,
           ref int Commercial_Registration,ref int Classification, ref double RemainderAmoun)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM tblClients WHERE ClientID = @ClientID";

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
                    Classification = (int)reader["Classification"];
                    RemainderAmoun = (int)reader["RemainderAmoun"];

                    if (!clsPersonData.GetPersonInfoByID(PersonID, ref Name, ref Email, ref Phone, ref Address))
                        return false;


                    //ssn: allows null in database so we should handle null
                    if (reader["SSN"] != DBNull.Value)
                        SSN = (int)reader["SSN"];
                    else
                        SSN = 0;


                    if (reader["Commercial_Registration"] != DBNull.Value)
                        Commercial_Registration = (int)reader["Commercial_Registration"];
                    else
                        Commercial_Registration = 0;
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

        public static int AddNewClient(string Name, string Email, string Phone, string Address,int SSN,
            int Commercial_Registration,int Classification,double RemainderAmount)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int ClientID = -1;

            int PersonID = clsPersonData.AddNewPerson(Name, Email, Phone, Address);

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


            if (SSN != 0)
                command.Parameters.AddWithValue("@SSN", SSN);
            else
                command.Parameters.AddWithValue("@SSN", System.DBNull.Value);


            if (Commercial_Registration != 0)
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


        public static bool UpdateClient(int ClientID,string Name, string Email, string Phone, string Address, int SSN,
            int Commercial_Registration, int Classification, double RemainderAmount)
        {

            int PersonID = _GetPersonID_ByClientID(ClientID);
            if (PersonID == 0)
                return false;


            clsPersonData.UpdatePerson(PersonID, Name, Email, Phone, Address);


            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  tblClients  
                            set SSN = @SSN, 
                                Commercial_Registration = @Commercial_Registration, 
                                PhoneNumber = @Phone, 
                                Classification = @Classification, 
                                RemainderAmount = @RemainderAmount,
                                where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@Classification", Classification);
            command.Parameters.AddWithValue("@RemainderAmount", RemainderAmount);


            if (SSN != 0 && SSN != null)
                command.Parameters.AddWithValue("@SSN", SSN);
            else
                command.Parameters.AddWithValue("@SSN", System.DBNull.Value);


            if (Commercial_Registration != 0 && Commercial_Registration != null)
                command.Parameters.AddWithValue("@Commercial_Registration", Commercial_Registration);
            else
                command.Parameters.AddWithValue("@Commercial_Registration", System.DBNull.Value);

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

        public static bool DeleteClient(int ClientID)
        {
            int PersonID = _GetPersonID_ByClientID(ClientID);
            if (PersonID == 0)
                return false;


            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete tblClient 
                                where ClienID = @ClienID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                clsPersonData.DeletePerson(PersonID);        //will delete the person record after deleting the client record

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




        static int _GetPersonID_ByClientID(int ClientID)
        {
            int PersonID = 0;

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

