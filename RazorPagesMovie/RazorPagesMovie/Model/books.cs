﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace RazorPagesMovie.Model
{
    public class Books
    {
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Author { get; set; }
        [BindProperty] public string Url { get; set; }
        [BindProperty] public int WriteDate { get; set; }
        
    }
}