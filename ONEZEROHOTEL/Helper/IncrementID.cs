using Microsoft.Data.SqlClient;

namespace ONEZEROHOTEL.Helper
{
    public static class IncrementID
    {
        public static int GetNextId()
        {
            // Your database connection string
            string connectionString = "Data Source=DECAGON;Initial Catalog=StayCationDb;Integrated Security=True;TrustServerCertificate=True";



            // Your SQL query to get the current maximum ID
            string query = "SELECT MAX(Id) FROM Client";



            // Create a new connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();



                // Create a new command object with your query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get the result
                    object result = command.ExecuteScalar();



                    // If the result is null, return 1 as the next ID
                    if (result == null || result == DBNull.Value)
                    {
                        return 1;
                    }
                    else
                    {
                        // Otherwise, parse the result as an integer and add 1 to get the next ID
                        return (int)result + 1;
                    }
                }
            }

        }
    }
}
