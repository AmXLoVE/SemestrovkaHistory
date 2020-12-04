using System.Collections.Generic;
using System.Linq;
using Npgsql;

namespace RazorPagesMovie.Model
{
    public class UsersDAO
    {
        public void Registration(string login, string password, string name, int personId)
        {
            
        }

        public void Authorization(string login, string password)
        {
            
        }

        public NpgsqlDataReader GetSelectedArticles(string login, NpgsqlConnection connection)
        {
            var reader = Connection.GetDataFromDb(connection, ("SELECT USERS.selected_articles_id FROM USERS WHERE USERS.login = '" + login + "'"));
            List<int> list = new List<int>();
            if (reader.Read())
            {
                list = reader.GetString(0).Split(',').Select(int.Parse).ToList();
            }
            reader.Close();
            if (list.Count > 0)
            {
                var a = "";
                foreach (var e in list)
                {
                    a += e + ",";
                }

                a = a.Remove(a.Length - 1, 1);
                reader = Connection.GetDataFromDb(connection,
                    "SELECT * FROM ARTICLES WHERE ID IN (" + a + ")");
            }
            
            return reader;
        }
    }
}