using System;
using System.Configuration;
using System.Linq;
using Npgsql;

namespace RazorPagesMovie.Model
{
    public class ArticlesDAO
    {
        public static NpgsqlDataReader GetAllArticles(NpgsqlConnection connection)
        {
            return Connection.GetDataFromDb(connection, "SELECT * FROM ARTICLES ORDER BY DATE_CREATE");
        }

        public static Articles MadeNewArticleObject(NpgsqlDataReader reader)
        {
            var newArticles = new Articles();
            var str = "";
            for (var i = 0; i < reader.FieldCount; i++)
            {
                str += reader.GetValue(i) + ",";
            }

            str = str.Remove(str.Length - 1, 1);
            var a = str.Split(',');
            newArticles.Name = a[0];
            newArticles.Image = a[1];
            newArticles.Description = a[2];
            newArticles.Keywords = a[3];
            var s = a[4].Split('.', ' ', ':');
            var d = s.Select(int.Parse).ToArray();
            newArticles.DateCreate = new DateTime(d[2], d[1], d[0]);
            newArticles.Id = int.Parse(a[5]);
            newArticles.Text = a[6];
            return newArticles;
        }
    }
}