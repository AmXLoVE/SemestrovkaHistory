using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class library : PageModel
    {
        [BindProperty] public List<Books> books
        {
            get => BooksDAO.GetAllBooks(Connection.Open());
        }
        
        public void OnGet()
        {
            
        }
    }
}