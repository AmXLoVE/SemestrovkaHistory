using System;
using System.Linq;
using Npgsql;

namespace RazorPagesMovie.Model
{
    public class ForumDAO
    {
        public static void NewDiscussion(int discussionId, DateTime timeCreate, int personCreateId)
        {
            
        }

        public static NpgsqlDataReader GetAllDiscussions(NpgsqlConnection connection)
        {
            return Connection.GetDataFromDb(connection, @"SELECT person_create_id, time_create, forum.name, description, discussion_id, users.name FROM FORUM inner JOIN users on
            forum.person_create_id = users.person_id ");
        }

        public static Discussion MadeNewDiscussionObject(NpgsqlDataReader reader, NpgsqlConnection connection)
        {
            var newDiscussion = new Discussion();
            var str = "";
            for (var i = 0; i < reader.FieldCount; i++)
            {
                str += reader.GetValue(i) + ",";
            }

            str = str.Remove(str.Length - 1, 1);
            var a = str.Split(',');
            newDiscussion.PersonCreateId = int.Parse(a[0]);
            var s = a[1].Split('.', ' ', ':');
            var d = s.Select(int.Parse).ToArray();
            newDiscussion.TimeCreate = new DateTime(d[2], d[1], d[0]);
            newDiscussion.Name = a[2];
            newDiscussion.Description = a[3];
            newDiscussion.DiscussionId = int.Parse(a[4]);
            newDiscussion.PersonCreateName = a[5];
            
            return newDiscussion;
        }
    }
}