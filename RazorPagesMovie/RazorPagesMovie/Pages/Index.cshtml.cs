using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class IndexModel : PageModel
    {
        public List<Articles> _list;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var connection = Connection.Open();
            var reader = ArticlesDAO.GetAllArticles(connection);
            _list = new List<Articles>();
            while(reader.Read())
            {
                _list.Add(ArticlesDAO.MadeNewArticleObject(reader));
            }
            connection.Close();
        }
    }
}