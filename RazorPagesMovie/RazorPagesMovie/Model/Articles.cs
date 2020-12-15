using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RazorPagesMovie.Pages;

namespace RazorPagesMovie.Model
{
    public class Articles
    {
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Image { get; set; }
        [BindProperty] public List<string> Keywords { get; set; }
        [BindProperty] public DateTime DateCreate { get; set; }
        [BindProperty] public int Id { get; set; }
        [BindProperty] public string Text { get; set; }

        public Articles(string name, string image, List<string> keywords, DateTime dateCreate, string text, int id)
        {
            Name = name;
            Image = image;
            Keywords = keywords;
            DateCreate = dateCreate;
            Text = text;
            Id = id;
        }

        public Articles()
        {
            
        }

        public string KeywordsToString()
        {
            var str = "";
            foreach (var e in Keywords)
            {
                if (e.Length <= 0) continue;
                var newKey = e;
                while (newKey[0] == ' ')
                {
                    newKey = newKey.Remove(0, 1);
                }

                while (newKey[^1] == ' ')
                {
                    newKey = newKey.Remove(newKey.Length - 1, 1);
                }

                str += newKey + ";";
            }
            str = str.Remove(str.Length - 1, 1);
            return str;
        }
    }
}