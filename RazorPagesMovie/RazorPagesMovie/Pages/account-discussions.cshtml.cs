using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class account_discussions : PageModel
    {
        [BindProperty] public List<Discussion> discussions { get; set; }
        
        public void OnGet()
        {
            var connection = Connection.Open();
            var list = UsersDAO.GetMyDiscussions(login.LoginSession, connection);
            discussions = new List<Discussion>();
            if (list != null)
            {
                var str = list.Aggregate("", (current, e) => current + ($@"'{e}'" + ","));
                str = str.Remove(str.Length - 1);
                var reader =
                    Connection.GetDataFromDb(connection, $@"SELECT * FROM FORUM WHERE discussion_id in ({str})");
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        discussions.Add(ForumDAO.MadeNewDiscussionObject(reader, connection));
                    }
            }

            connection.Close();
        }
    }
}