using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Model;

namespace RazorPagesMovie.Pages
{
    public class account : PageModel
    {
        [BindProperty] public string Action { get; set; }
        [BindProperty] public string NewLogin { get; set; }
        [BindProperty] public string Password { get; set; }
        [BindProperty] public string NewPassword { get; set; }
        [BindProperty] public string ConfirmPassword { get; set; }
        [BindProperty] public static string Message { get; set; }
        
        public void OnGet()
        {
            Message = null;
        }

        public IActionResult OnPost()
        {
            if (!login.IsSession || !login.LoginEqualsLoginSession())
            {
                Response.Redirect("/login");
                login.Staticlogin = null;
                login.IsSession = false;
                return Page();
            }

            if (NewLogin == login.Staticlogin && login.IsSession && login.LoginEqualsLoginSession())
            {
                Message = "WARNING: Нельзя поменять логин на такой же";
                return Page();
            }

            switch (Action)
            {
                case "exit":
                    Response.Redirect("/login");
                    login.IsSession = false;
                    login.LoginSession = null;
                    break;
                case "changeLogin" when !CheckLogin():
                    Message = "WARNING: Логин не должен содержать цифр\nи иметь длину от 3 до 20 символов.";
                    return Page();
                case "changeLogin":
                {
                    var connection = Connection.Open();
                    var reader = Connection.GetDataFromDb(connection,
                        $@"SELECT users.password FROM USERS WHERE '{login.Staticlogin}' = users.login");
                    if (reader.Read())
                    {
                        var hashPasswordFromDb = reader.GetValue(0).ToString();
                        reader.Close();
                        var passwordAndSalt = new Tuple<string, string>(
                            hashPasswordFromDb.Substring(0, hashPasswordFromDb.Length - 6),
                            hashPasswordFromDb.Substring(hashPasswordFromDb.Length - 6, 6));
                        if (passwordAndSalt.Item1 == UsersDAO.Hashing(Password, passwordAndSalt.Item2))
                        {
                            ViewData["error"] = UsersDAO.ChangeLogin(connection, NewLogin);
                            Response.Redirect("/login");
                            login.IsSession = false;
                            login.Staticlogin = null;
                        }
                        else Message = "WARNING: Неверный пароль";
                    }

                    connection.Close();
                    break;
                }
                case "changeParol":
                {
                    if (Password == null || NewPassword == null || ConfirmPassword == null)
                    {
                        Message = "WARNING: Поля или одно из полей пустые";
                        return Page();
                    }
                    var connection = Connection.Open();
                    var reader = Connection.GetDataFromDb(connection,
                        $@"SELECT users.password FROM USERS WHERE '{login.Staticlogin}' = users.login");
                    if (reader.Read())
                    {
                        var hashPasswordFromDb = reader.GetValue(0).ToString();
                        reader.Close();
                        var passwordAndSalt = new Tuple<string, string>(
                            hashPasswordFromDb.Substring(0, hashPasswordFromDb.Length - 6),
                            hashPasswordFromDb.Substring(hashPasswordFromDb.Length - 6, 6));
                        if (passwordAndSalt.Item1 == UsersDAO.Hashing(Password, passwordAndSalt.Item2))
                        {
                            if (NewPassword == ConfirmPassword)
                            {
                                var (hashPassword, salt) = UsersDAO.FirstHashing(NewPassword);
                                UsersDAO.ChangePassword(connection, hashPassword + salt);
                                Response.Redirect("/login");
                                login.IsSession = false;
                                login.Staticlogin = null;
                            }
                            else
                            {
                                Message = "WARNING: Пароли не совпадают";
                                return Page();
                            }
                        }
                        else Message = "WARNING: Неверный пароль";
                    }
                    connection.Close();
                    break;
                }
            }

            return Page();
        }
        
        private bool CheckLogin()
        {
            return NewLogin != null && UsersDAO.CheckLogin(NewLogin);
        }
    }
}