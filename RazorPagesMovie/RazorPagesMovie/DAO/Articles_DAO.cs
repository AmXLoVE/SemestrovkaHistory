using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Npgsql;

namespace RazorPagesMovie.Model
{
    public class ArticlesDAO
    {
        public static List<Articles> GetAllArticles(NpgsqlConnection connection)
        {
            var reader = connection.GetDataFromDb($@"SELECT * FROM ARTICLES ORDER BY DATE_CREATE");
            var articles = new List<Articles>();
            while(reader.Read())
            {
                articles.Add(ArticlesDAO.MadeNewArticleObject(reader));
            }
            reader.Close();
            return articles;
        }

        public static Articles MadeNewArticleObject(NpgsqlDataReader reader)
        {
            var newArticles = new Articles();
            var a = new string[reader.FieldCount];
            for (var i = 0; i < reader.FieldCount; i++)
            {
                a[i] = reader.GetValue(i).ToString();
            }
            newArticles.Name = a[0];
            newArticles.Image = a[1];
            var keywords = new List<string>();
            foreach (var key in a[2].Split(';'))
            {
                if (key.Length <= 0) continue;
                var newKey = key;
                while (newKey[0] == ' ')
                {
                    newKey = newKey.Remove(0, 1);
                }

                while (newKey[^1] == ' ')
                {
                    newKey = newKey.Remove(newKey.Length - 1, 1);
                }
                keywords.Add(newKey);
            }
            newArticles.Keywords = keywords;
            var s = a[3].Split('.', ' ', ':');
            var d = s.Select(int.Parse).ToArray();
            newArticles.DateCreate = new DateTime(d[2], d[1], d[0]);
            newArticles.Id = int.Parse(a[4]);
            newArticles.Text = a[5];
            return newArticles;
        }

        public static List<string> MakeNewListOfKeys(NpgsqlConnection connection)
        {
            var list = new List<string>();
            var command = $@"SELECT KEYWORDS FROM ARTICLES";
            var reader = connection.GetDataFromDb(command);
            while (reader.Read())
            {
                var str = reader.GetString(0);
                foreach (var key in str.Split(';'))
                {
                    if (key.Length <= 0) continue;
                    var newKey = key;
                    while (newKey[0] == ' ')
                    {
                        newKey = newKey.Remove(0, 1);
                    }

                    while (newKey[^1] == ' ')
                    {
                        newKey = newKey.Remove(newKey.Length - 1, 1);
                    }

                    if (IsKeyContainInList(list, newKey) && newKey.Length > 0)
                        list.Add(newKey);
                }
            }
            
            return list.OrderBy(x => x).ToList();
        }

        private static bool IsKeyContainInList(IEnumerable<string> list, string key)
        {
            return list.All(e => !e.Equals(key));
        }

        public static Articles GetArticleFromDb(NpgsqlConnection connection, int id)
        {
            var reader = connection.GetDataFromDb($@"SELECT * FROM ARTICLES WHERE id = '{id}'");
            var articles = new Articles();
            if(reader.Read())
                articles = ArticlesDAO.MadeNewArticleObject(reader);
            reader.Close();
            return articles;
        }
    }
}