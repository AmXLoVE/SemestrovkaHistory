using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using RazorPagesMovie.Model;
using Scrypt;

namespace RazorPagesMovie.Pages
{
    public class signup : PageModel
    {
        [BindProperty] public string Login { get; set; }
        [BindProperty] public string Password { get; set; }
        [BindProperty] public string ConfirmPassword { get; set; }
        
        public void OnGet()
        {
            login.IsSession = false;
            login.LoginSession = null;
        }

        public void OnPost()
        {
            if (!UsersDAO.CheckLogin(Login) || !UsersDAO.CheckPassword(Password))
            {
                ViewData["error"] = "Неверно заполненное поле или несколько полей.";
                return;
            }
            var connection = Connection.Open();
            if (Password.Equals(ConfirmPassword))
            {
                var a = new Tuple<string, string>(null, null);
                var (item1, item2) = UsersDAO.FirstHashing(Password);
                Password = item1 + item2;
                var loginParam = new NpgsqlParameter("@login", Login) 
                {
                    Direction = ParameterDirection.Input,
                };
                
                var passwordParam = new NpgsqlParameter("@Password", Password)
                {
                    Direction = ParameterDirection.Input,
                };
                var commandString = (@"INSERT INTO USERS VALUES (@login, @password, null)");
                connection.SendCommandWithoutAnswer(commandString, new List<NpgsqlParameter>(){loginParam, passwordParam});
                login.IsSession = true;
                login.LoginSession = Login;
                login.Staticlogin = Login;
                Response.Redirect("/account");
            }
            else ViewData["error"] = "Пароли не совпадают";
            connection.Close();
        }
    }
}