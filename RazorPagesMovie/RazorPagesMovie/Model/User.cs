using System;
using Microsoft.AspNetCore.Mvc;

namespace RazorPagesMovie.Model
{
    public class User
    {
        [BindProperty] public string Login { get; set; }
        [BindProperty] public string Password { get; set; }
        [BindProperty] public string SelectedArticlesId { get; set; }
        [BindProperty] public string Name { get; set; }
    }
}