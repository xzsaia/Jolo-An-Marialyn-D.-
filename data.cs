using Act01;
using System.Data.SqlClient;

namespace cmd
{
    internal class Data
    {
        static string connectionString
        = "Data Source =DESKTOP-AVQ005L\\MSSQLSERVER02; Initial Catalog = petnames; Integrated Security = True;"; //Local Connection
        //= "Server=tcp:4.193.106.92,1433;Database=PUPHubPoints;User Id=sa;Password=PUPHUB123!;"; //Server Connection
        static SqlConnection sqlConnection;


        public Data()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<petnames> Getpetnamess() 
        {
            var selectStatement = "SELECT * FROM petnamess";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var petnamess = new List<petnames>();

            while (reader.Read())
            {
                petnamess.Add(new petnames
                {
                    pOwner = reader["pOwner"].ToString(),
                    pnames = reader["pnames"].ToString(),
                    pGender = reader["pGender"].ToString(),

                });
            }

            sqlConnection.Close();
            return petnamess;
        }
    }
}
