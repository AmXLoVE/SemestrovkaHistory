using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;

namespace RazorPagesMovie.Pages
{
    public class new_discussion : PageModel
    {
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Description { get; set; }
        
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            MakeNewDiscussion();
            Response.Redirect("/forum");
        }

        private void MakeNewDiscussion()
        {
            var connection = Connection.Open();
            var nameParam = new NpgsqlParameter("@name", Name);
            nameParam.Direction = ParameterDirection.Input;
            var descriptionParam = new NpgsqlParameter("@description", Description);
            descriptionParam.Direction = ParameterDirection.Input;
            var command = String.Format(@"INSERT INTO FORUM VALUES ('{0}', '{1}', @name, @description)", login.Staticlogin,
                DateTime.Now.ToString("d"));
            connection.SendCommandWithoutAnswer(command, new List<NpgsqlParameter>() {nameParam, descriptionParam});
        }
    }
}