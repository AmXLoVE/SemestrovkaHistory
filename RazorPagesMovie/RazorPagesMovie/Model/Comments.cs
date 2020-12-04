using System;
using Microsoft.AspNetCore.Mvc;

namespace RazorPagesMovie.Model
{
    public class Comments
    {
        [BindProperty] public string MessageText { get; set; }
        [BindProperty] public DateTime MessageDate { get; set; }
        [BindProperty] public int PersonId { get; set; }
        [BindProperty] public int DiscussionId { get; set; }
        [BindProperty] public string PersonName { get; set; }
    }
}