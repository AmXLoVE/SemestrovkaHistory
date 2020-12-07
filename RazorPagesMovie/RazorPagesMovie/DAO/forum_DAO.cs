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
            return Connection.GetDataFromDb(connection, @"SELECT person_create_login, time_create, forum.name, description, discussion_id FROM FORUM");
        }

        public static Discussion MadeNewDiscussionObject(NpgsqlDataReader reader, NpgsqlConnection connection)
        {
            var newDiscussion = new Discussion();
            var a = new string[reader.FieldCount];
            for (var i = 0; i < reader.FieldCount; i++)
            {
                a[i] = reader.GetValue(i).ToString();
            }
            newDiscussion.PersonCreateLogin = a[0];
            var s = a[1].Split('.', ' ', ':');
            var d = s.Select(int.Parse).ToArray();
            newDiscussion.TimeCreate = new DateTime(d[2], d[1], d[0]);
            newDiscussion.Name = a[2];
            newDiscussion.Description = a[3];
            newDiscussion.DiscussionId = int.Parse(a[4]);

            return newDiscussion;
        }
    }
}