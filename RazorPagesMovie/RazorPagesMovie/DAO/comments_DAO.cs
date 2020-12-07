using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;

namespace RazorPagesMovie.Model
{
    public class CommentsDAO
    {
        public void NewMessage(string messageText, DateTime messageDate, int personId, int discussionId)
        {
            
        }

        public static NpgsqlDataReader GetAllComments(int id, NpgsqlConnection connection)
        {
            return Connection.GetDataFromDb(connection,
                $@"SELECT MESSAGE_TEXT, MESSAGE_DATE, DISCUSSION_ID, person_login FROM DISCUSSIONS WHERE DISCUSSION_ID = '{id}' ORDER BY MESSAGE_DATE");
        }

        public static Comments MadeNewCommentObject(NpgsqlDataReader reader, NpgsqlConnection connection)
        {
            var newComment = new Comments();
            var a = new string[reader.FieldCount];
            for (var i = 0; i < reader.FieldCount; i++)
            {
                a[i] = reader.GetValue(i).ToString();
            }
            
            newComment.MessageText = a[0];
            var s = a[1].Split('.', ' ', ':');
            var d = s.Select(int.Parse).ToArray();
            newComment.MessageDate = new DateTime(d[2], d[1], d[0], d[3], d[4], d[5]);
            newComment.DiscussionId = int.Parse(a[2]);
            newComment.PersonName = a[3];
            return newComment;
        }
    }
}