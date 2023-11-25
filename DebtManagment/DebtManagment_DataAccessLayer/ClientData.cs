using System;
using System.Data.SqlClient;

namespace DebtManagment_DataAccessLayer       //[Database]
{
    public class clsClientData
    {
        public static int AddNewClient(string Name, string Email, string Phone, string Address,int SSN,
            int Commercial_Registration,int Classification,double RemainderAmount)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int ClientID = -1;

            int PersonID = clsPersonData.AddNewPerson(Name, Email, Phone, Address);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO tblClient
                            values (@PersonID,@SSN,@Commercial_Registration,@Classification,@RemainderAmount)
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




    }

   
}

