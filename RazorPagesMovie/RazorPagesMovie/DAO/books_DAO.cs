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
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    str[i] = reader.GetValue(i).ToString();
                }
                
                try
                {
                    int.Parse(str[3]);
                }
                catch(InvalidCastException exception)
                {
                    continue;
                }
                
                var book = new Books(){Name = str[0], Author = str[1], Url = str[2], WriteDate = int.Parse(str[3])};
                list.Add(book);
            }

            return list;
        }
    }
}