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
        public List<Articles> Articles;
        public List<string> Keywords;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var connection = Connection.Open();
            Articles = ArticlesDAO.GetAllArticles(connection);
            Keywords = ArticlesDAO.MakeNewListOfKeys(connection);
            connection.Close();
        }
    }
}