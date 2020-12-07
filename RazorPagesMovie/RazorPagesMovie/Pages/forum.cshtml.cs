using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class forum : PageModel
    {
        public List<Discussion> _list;
        
        public void OnGet()
        {
            var connection = Connection.Open();
            var reader = ForumDAO.GetAllDiscussions(connection);
            _list = new List<Discussion>();
            while (reader.Read())
            {
                _list.Add(ForumDAO.MadeNewDiscussionObject(reader, connection));
            }
            connection.Close();
        }
    }
}