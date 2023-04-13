using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthographics
{
    internal class DataBaseController
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OrthographicsDB.mdf;Integrated Security=True;Connect Timeout=30";
        private static SqlConnection connection = new SqlConnection(connectionString);

        public static bool Authorize(string login, string password)
        {
            string query = "SELECT * FROM [User] WHERE Login=@login AND Password=@password";
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("login", login);
            command.Parameters.AddWithValue("password", password);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                return true;
            connection.Close();
            return false;
        }

    }
}
