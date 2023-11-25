using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagment_DataAccessLayer
{
    public class clsSupplierData
    {
        public static int AddNewSupplier(string Name, string Email, string Phone, string Address,
           int Commercial_Registration)
        {
            //this function will return the new supplier id if succeeded and -1 if not.
            int SupplierID = -1;

            int PersonID = clsPersonData.AddNewPerson(Name, Email, Phone, Address);

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
    }
}
