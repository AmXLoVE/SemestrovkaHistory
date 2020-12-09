using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;

namespace RazorPagesMovie.Model
{
    public class BooksDAO
    {
        public static List<Books> GetAllBooks(NpgsqlConnection connection)
        {
            var reader = connection.GetDataFromDb($@"SELECT * FROM BOOKS");
            var list = new List<Books>();
            while(reader.Read())
            {
                var str = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    str[i] = reader.GetValue(i).ToString();
                }

                var dateTime = str[3].Split('.', ' ', ':').Select(int.Parse).ToArray();
                var book = new Books(){Name = str[0], Author = str[1], Description = str[2], Url = str[4], WriteDate = new DateTime(dateTime[2], dateTime[1], dateTime[0])};
                list.Add(book);
            }

            return list;
        }
    }
}