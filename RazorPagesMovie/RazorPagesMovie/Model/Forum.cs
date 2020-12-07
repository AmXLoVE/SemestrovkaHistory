using System;
using Microsoft.AspNetCore.Mvc;
using RazorPagesMovie.Pages;

namespace RazorPagesMovie.Model
{
    public class Discussion
    {
        [BindProperty] public int DiscussionId { get; set; }
        [BindProperty] public DateTime TimeCreate { get; set; }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Description { get; set; }
        [BindProperty] public string PersonCreateLogin { get; set; }

        public Discussion()
        {
            
        }
    }
}