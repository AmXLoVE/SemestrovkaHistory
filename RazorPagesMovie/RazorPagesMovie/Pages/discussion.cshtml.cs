using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class discussion : PageModel
    {
        public int Id { get; private set; }
        public Discussion Discussion;
        public List<Comments> Comments;
        [BindProperty] public string Comment { get; set; }

        public void OnGet()
        {
            var connection = Connection.Open();
            Id = int.Parse(HttpContext.Request.Query["open"]);
            var reader = Connection.GetDataFromDb(connection, $@"SELECT * FROM FORUM WHERE discussion_id = '{Id}'");
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

        public void OnPost()
        {
            OnGet();
            if (Comment == null || Comment.Length <= 0) return;
            var connection = Connection.Open();
            var messageTextParam = new NpgsqlParameter("@comment", Comment) {Direction = ParameterDirection.Input};
            var command =
                $@"INSERT INTO DISCUSSIONS VALUES (@comment, '{DateTime.Now:g}', '{Id}', '{login.Staticlogin}')";
            connection.SendCommandWithoutAnswer(command, new List<NpgsqlParameter>() {messageTextParam});
            Response.Redirect($@"/discussion?open={Id}");
        }
    }
}