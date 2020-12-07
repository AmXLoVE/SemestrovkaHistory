using System.Collections.Generic;
using System.Configuration;
using Npgsql;

namespace RazorPagesMovie
{
    /// <summary>
    /// Класс, куда встроены методы работы с PostgreSQL
    /// </summary>
    public static class Connection
    {
        public static NpgsqlConnection Open()
        {
            var connection = new NpgsqlConnection(){ConnectionString = ConfigurationManager.ConnectionStrings["history"].ConnectionString};
            connection.Open();
            return connection;
        }

        public static void Close(NpgsqlConnection connection)
        {
            connection.Close();
        }

        public static int SendCommandWithoutAnswer(this NpgsqlConnection connection, string command, List<NpgsqlParameter> list)
        {
            var c = new NpgsqlCommand(command, connection);
            foreach (var e in list)
            {
                c.Parameters.Add(e);
            }
            return c.ExecuteNonQuery();
        }

        public static NpgsqlDataReader GetDataFromDb(this NpgsqlConnection connection, string command)
        {
            var c = new NpgsqlCommand(command, connection);
            return c.ExecuteReader();
        }
    }
}