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
        [BindProperty] public string Message { get; set; }

        public void OnGet()
        {
            var connection = Connection.Open();
            try
            {
                Id = int.Parse(HttpContext.Request.Query["open"]);
            }
            catch
            {
                ReturnWithError();
                return;
            }
            var reader = connection.GetDataFromDb($@"SELECT * FROM FORUM WHERE discussion_id = '{Id}'");
            if (reader.Read())
                Discussion = ForumDAO.MadeNewDiscussionObject(reader, connection);
            reader.Close();
            if (Discussion == null || Discussion.Name == null || Discussion.Name.Length < 1)
            {
                ReturnWithError();
                return;
            }
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
            if (Comment == null || Comment.Trim().Length <= 0)
            {
                Message = "Пустой комментарий!";
                return;
            }

            if (Discussion.DiscussionId == -1)
            {
                Message = "Возникла ошибка при отправке комментария.";
                return;
            }
            var connection = Connection.Open();
            var messageTextParam = new NpgsqlParameter("@comment", Comment) {Direction = ParameterDirection.Input};
            var command =
                $@"INSERT INTO DISCUSSIONS VALUES (@comment, '{DateTime.Now:g}', '{Id}', '{login.Staticlogin}')";
            connection.SendCommandWithoutAnswer(command, new List<NpgsqlParameter>() {messageTextParam});
            Response.Redirect($@"/discussion?open={Id}");
        }

        private void ReturnWithError()
        {
            Discussion = new Discussion() {Description = "Nonexistent article", Name = "WARNING:", DiscussionId = -1, TimeCreate = DateTime.Now, PersonCreateLogin = "Error"};
            Comments = new List<Comments>();
            Message = "К сожалению, такого обсуждения не существеут.";
        }
    }
}