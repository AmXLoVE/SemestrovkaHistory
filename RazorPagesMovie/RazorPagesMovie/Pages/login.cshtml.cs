using System;
using System.Configuration;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class login : PageModel
    {
        [BindProperty] public static string Staticlogin { get; set; }
        [BindProperty] public string Login { get => Staticlogin; set => Staticlogin = value; }
        [BindProperty] public string Password { get; set; }
        [BindProperty] public bool ZapomnitMenya { get; set; }
        [BindProperty] public static bool IsSession { get; set; }
        [BindProperty] public static string LoginSession { get; set; }
        [BindProperty] public string Message { get; set; }

        public void OnGet()
        {
            if (!Request.Cookies.ContainsKey("Login") || !Request.Cookies.ContainsKey("Password")) return;
            Staticlogin = Request.Cookies["Login"];
            Password = Request.Cookies["Password"];
        }

        public void OnPost()
        {
            if (!UsersDAO.CheckLogin(Login) || !UsersDAO.CheckPassword(Password))
            {
                Message = "Неверный логин или пароль";
                return;
            }
            var connection = Connection.Open();
            var reader = connection.GetDataFromDb($"SELECT users.password FROM USERS WHERE '{Staticlogin}' = users.login");
            if (reader.Read())
            {
                var hashPasswordFromDb = reader.GetValue(0).ToString();
                var passwordAndSalt = new Tuple<string, string>(
                    hashPasswordFromDb.Substring(0, hashPasswordFromDb.Length - 6),
                    hashPasswordFromDb.Substring(hashPasswordFromDb.Length - 6, 6));
                var hashPassword = UsersDAO.Hashing(Password, passwordAndSalt.Item2);
                if (hashPassword.Equals(passwordAndSalt.Item1))
                {
                    Response.Redirect("/account");
                    if (ZapomnitMenya)
                    {
                        if(Request.Cookies.ContainsKey("Login"))
                            Response.Cookies.Delete("Login");
                        if(Request.Cookies.ContainsKey("Password"))
                            Response.Cookies.Delete("Password");
                        Response.Cookies.Append("Login", Staticlogin);
                        Response.Cookies.Append("Password", Password);
                    }
                    IsSession = true;
                    LoginSession = Staticlogin;
                }
                else
                    Message = "Неверный логин или пароль";
            }
            else Message = "Неверный логин или пароль";
        }

        public static bool LoginEqualsLoginSession()
        {
            return LoginSession.Equals(Staticlogin);
        }
    }
}