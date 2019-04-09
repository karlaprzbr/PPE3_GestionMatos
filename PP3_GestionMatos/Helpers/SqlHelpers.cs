namespace PP3_GestionMatos.Helpers
{
    using System.Data.SqlClient;

    public static  class SqlHelpers
    {
        private static string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = PPE3_GestionMatos; Integrated Security = True;";

        public static void ExecuteQuery(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
        }


    }
}
