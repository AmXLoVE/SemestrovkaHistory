using System;
using Microsoft.AspNetCore.Mvc;

namespace RazorPagesMovie.Model
{
    public class Articles
    {
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Image { get; set; }
        [BindProperty] public string Description { get; set; }
        [BindProperty] public string Keywords { get; set; }
        [BindProperty] public DateTime DateCreate { get; set; }
        [BindProperty] public int Id { get; set; }
        [BindProperty] public string Text { get; set; }

        public Articles(string name, string image, string description, string keywords, DateTime dateCreate, string text, int id)
        {
            Name = name;
            Image = image;
            Description = description;
            Keywords = keywords;
            DateCreate = dateCreate;
            Text = text;
            Id = id;
        }

        public Articles()
        {
            
        }
    }
}