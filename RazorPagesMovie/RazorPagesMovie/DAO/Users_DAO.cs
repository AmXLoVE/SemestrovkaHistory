using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CryptSharp.Utility;
using Microsoft.Win32.SafeHandles;
using Npgsql;
using RazorPagesMovie.Pages;
using Scrypt;

namespace RazorPagesMovie.Model
{
    public class UsersDAO
    {
        public static NpgsqlDataReader GetSelectedArticles(string login, NpgsqlConnection connection)
        {
            var reader = Connection.GetDataFromDb(connection, ($@"SELECT USERS.selected_articles_id FROM USERS WHERE USERS.login = '{login}'"));
            var list = new List<int>();
            if (reader.Read())
            {
                if(reader.GetValue(0).ToString().Length > 0)
                    list = reader.GetValue(0).ToString().Remove(reader.GetValue(0).ToString().Length - 1, 1).Split(',').Select(int.Parse).ToList();
            }
            reader.Close();
            if (list.Count <= 0) return null;
            var a = list.Aggregate("", (current, e) => current + ("'" + e + "',"));
            a = a.Remove(a.Length - 1);
            reader = connection.GetDataFromDb($@"SELECT * FROM ARTICLES WHERE ID IN ({a})");
            return reader;
        }

        public static Tuple<string, int> FirstHashing(string password)
        {
            var passBytes = Encoding.UTF8.GetBytes(password);
            var salt = GetSalt();
            var saltBytes = Encoding.UTF8.GetBytes(salt.ToString());
            var cost = 262144;
            var blockSize = 8;
            var parallel = 1;
            var maxThreads = (int?) null;
            var derivedKeyLength = 128;
            var res = SCrypt.ComputeDerivedKey(passBytes, saltBytes, cost, blockSize, parallel, maxThreads, derivedKeyLength);
            return new Tuple<string, int>(Convert.ToBase64String(res), salt);
        }

        public static string Hashing(string password, string salt)
        {
            var passBytes = Encoding.UTF8.GetBytes(password);
            var saltBytes = Encoding.UTF8.GetBytes(salt);
            var cost = 262144;
            var blockSize = 8;
            var parallel = 1;
            var maxThreads = (int?) null;
            var derivedKeyLength = 128;
            var res = SCrypt.ComputeDerivedKey(passBytes, saltBytes, cost, blockSize, parallel, maxThreads, derivedKeyLength);
            return Convert.ToBase64String(res);
        }

        private static int GetSalt()
        {
            var random = new Random();
            return random.Next(100000, 999999);
        }

        public static List<int> GetMyDiscussions(string login, NpgsqlConnection connection)
        {
            var reader = Connection.GetDataFromDb(connection,
                $@"SELECT distinct forum.discussion_id from forum where person_create_login = '{login}' "
                );
            var myDiscussionsList = new List<int>();
            while (reader.Read())
            {
                myDiscussionsList.Add(int.Parse(reader.GetValue(0).ToString()));
            }
            reader.Close();
            var myCommentsInDiscussionsList = new List<int>();
            reader = Connection.GetDataFromDb(connection,
                $@"SELECT discussions.discussion_id from discussions where person_login = '{login}' ");
            while (reader.Read())
            {
                myCommentsInDiscussionsList.Add(int.Parse(reader.GetValue(0).ToString()));
            }
            reader.Close();
            if (myDiscussionsList.Count <= 0 && myCommentsInDiscussionsList.Count <= 0) return null;
            myDiscussionsList.AddRange(myCommentsInDiscussionsList);
            return myDiscussionsList.Distinct().ToList();
        }

        public static bool CheckLogin(string login)
        {
            return login != null && new Regex(@"^[a-zA-Zа-яА-ЯёЁ]{3,20}$").IsMatch(login);
        }

        public static bool CheckPassword(string password)
        {
            return password != null && new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}$").IsMatch(password);
        }

        public static string ChangeLogin(NpgsqlConnection connection, string newLogin)
        {
            var reader = connection.GetDataFromDb($@"SELECT USERS.LOGIN FROM USERS WHERE USERS.LOGIN = '{newLogin}'");
            if (reader.HasRows) return "Пользователь с таким логином уже существует";
            else
            {
                var loginParam = new NpgsqlParameter("@newLogin", newLogin) {Direction = ParameterDirection.Input};
                reader.Close();
                connection.SendCommandWithoutAnswer(
                    $@"UPDATE USERS SET LOGIN = @newLogin WHERE LOGIN = '{login.Staticlogin}'", new List<NpgsqlParameter>(){loginParam});
                return null;
            }
        }

        public static void ChangePassword(NpgsqlConnection connection, string newPassword)
        {
            var passwordParam = new NpgsqlParameter("@newPassword", newPassword) {Direction = ParameterDirection.Input};
            connection.SendCommandWithoutAnswer(
                $@"UPDATE USERS SET PASSWORD = @newPassword WHERE LOGIN = '{login.Staticlogin}'", new List<NpgsqlParameter>(){passwordParam});
        }
    }
}