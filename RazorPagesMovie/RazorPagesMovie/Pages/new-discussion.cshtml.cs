using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;

namespace RazorPagesMovie.Pages
{
    public class new_discussion : PageModel
    {
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Description { get; set; }
        [BindProperty] public string Message { get; set; }
        
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            MakeNewDiscussion();
        }

        private void MakeNewDiscussion()
        {
            var connection = Connection.Open();
            if (Name == null || Description == null)
            {
                Message = "Некоторые из полей остались пустыми";
                return;
            }
            var nameParam = new NpgsqlParameter("@name", Name.Trim()) {Direction = ParameterDirection.Input};
            var descriptionParam = new NpgsqlParameter("@description", Description.Trim()) {Direction = ParameterDirection.Input};
            var command = $@"INSERT INTO FORUM VALUES ('{login.Staticlogin}', '{DateTime.Now:d}', @name, @description)";
            connection.SendCommandWithoutAnswer(command, new List<NpgsqlParameter>() {nameParam, descriptionParam});
            Response.Redirect("/forum");
        }
    }
}