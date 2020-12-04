using System;
using System.Configuration;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class article : PageModel
    {
        public static int Id { get; set; }
        public static Articles articles;

        public void OnGet()
        {
            var connection = Connection.Open();
            Id = int.Parse(HttpContext.Request.Query["open"]);
            var reader = Connection.GetDataFromDb(connection, "SELECT * FROM ARTICLES WHERE id = '" + Id + "'");
            if(reader.Read())
                articles = ArticlesDAO.MadeNewArticleObject(reader);
            connection.Close();
        }
    }
}