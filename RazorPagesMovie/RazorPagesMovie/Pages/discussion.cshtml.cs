using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class discussion : PageModel
    {
        public static int Id { get; set; }
        public static Discussion Discussion;
        public static List<Comments> Comments;
        
        public void OnGet()
        {
            var connection = Connection.Open();
            Id = int.Parse(HttpContext.Request.Query["open"]);
            var reader = Connection.GetDataFromDb(connection, @"SELECT person_create_id, time_create,
 forum.name, description, discussion_id, users.name FROM FORUM inner JOIN users on
            forum.person_create_id = users.person_id WHERE discussion_id = '" + Id + "'");
            if (reader.Read())
                Discussion = ForumDAO.MadeNewDiscussionObject(reader, connection);
            reader.Close();
            reader = CommentsDAO.GetAllComments(Id, connection);
            Comments = new List<Comments>();
            while (reader.Read())
            {
                Comments.Add(CommentsDAO.MadeNewCommentObject(reader, connection));
            }
            connection.Close();
        }
    }
}