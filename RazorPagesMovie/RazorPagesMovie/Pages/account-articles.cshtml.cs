using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class account_articles : PageModel
    {
        [BindProperty] public List<Articles> selectedArticles { get; set; }

        public void OnGet()
        {
            var connection = Connection.Open();
            var reader = UsersDAO.GetSelectedArticles(login.LoginSession, connection);
            selectedArticles = new List<Articles>();
            if(reader != null)
                while(reader.Read())
                {
                    selectedArticles.Add(ArticlesDAO.MadeNewArticleObject(reader));
                }
            connection.Close();
        }
    }
}