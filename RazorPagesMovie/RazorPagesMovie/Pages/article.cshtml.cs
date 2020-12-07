using System;
using System.Configuration;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class article : PageModel
    {
        public int Id { get; set; }
        public Articles articles;
        public bool IsSelected { get; set; }

        public void OnGet()
        {
            var connection = Connection.Open();
            Id = int.Parse(HttpContext.Request.Query["open"]);
            var reader = Connection.GetDataFromDb(connection, "SELECT * FROM ARTICLES WHERE id = '" + Id + "'");
            if(reader.Read())
                articles = ArticlesDAO.MadeNewArticleObject(reader);
            reader.Close();
            var a = UsersDAO.GetSelectedArticles(login.LoginSession, connection);
            var str = SelectedArticlesToString(a);
            if(str.Length > 0)
                IsSelected = str.Split(',').Select(int.Parse).ToArray().Contains(Id);
            connection.Close();
        }

        public void OnPost()
        {
            OnGet();
            IsSelected = !IsSelected;
            var connection = Connection.Open();
            var reader = UsersDAO.GetSelectedArticles(login.Staticlogin, connection);
            var str = SelectedArticlesToString(reader);
            var array = str.Length > 0 ? str
                .Split(',')
                .Select(int.Parse)
                .ToArray(): Array.Empty<int>();
            if(str.Length > 0)
                str += ",";
            if (IsSelected && !array.Contains(Id))
            {
                str += $@"{Id},";
            }
            else if (IsSelected && array.Contains(Id))
            {
                return;
            }
            else if (!IsSelected && array.Contains(Id))
            {
                array = array.Where(x => x != Id).ToArray();
                str = array.Select(x => x).Aggregate("", (current, e) => current + (e + ","));
            }
            reader?.Close();
            connection.GetDataFromDb($@"UPDATE USERS SET SELECTED_ARTICLES_ID = '{str}' WHERE LOGIN = '{login.Staticlogin}'");
        }

        public string SelectedArticlesToString(NpgsqlDataReader reader)
        {
            var str = "";
            if (reader == null || !reader.Read() || reader.IsDBNull(0)) return str;
            str += reader.GetValue(5).ToString() + ",";
            while(reader.Read())
                str += reader.GetValue(5).ToString() + ",";
            str = str.Remove(str.Length - 1, 1);
            return str;
        }
    }
}