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
                "SELECT DISCUSSIONS.PERSON_ID, MESSAGE_TEXT, MESSAGE_DATE, DISCUSSION_ID, USERS.LOGIN FROM DISCUSSIONS INNER JOIN USERS ON DISCUSSIONS.PERSON_ID = USERS.PERSON_ID WHERE DISCUSSION_ID = '" +
                id + "'");
        }

        public static Comments MadeNewCommentObject(NpgsqlDataReader reader, NpgsqlConnection connection)
        {
            var newComment = new Comments();
            var str = "";
            for (var i = 0; i < reader.FieldCount; i++)
            {
                str += reader.GetValue(i) + ",";
            }

            str = str.Remove(str.Length - 1, 1);
            var a = str.Split(',');
            newComment.PersonId = int.Parse(a[0]);
            newComment.MessageText = a[1];
            var s = a[2].Split('.', ' ', ':');
            var d = s.Select(int.Parse).ToArray();
            newComment.MessageDate = new DateTime(d[2], d[1], d[0], d[3], d[4], d[5]);
            newComment.DiscussionId = int.Parse(a[3]);
            newComment.PersonName = a[4];
            return newComment;
        }
    }
}