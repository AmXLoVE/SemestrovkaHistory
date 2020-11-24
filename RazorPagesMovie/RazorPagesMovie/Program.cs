using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Npgsql;

namespace RazorPagesMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connect = @"Server = 127.0.0.1;
                             Database = history;
                             Command Timeout = 0;
                             User Id = postgres;
                             Password = 085673AlAn";
            var connection = new NpgsqlConnection {ConnectionString = connect};
            connection.Open();
            Console.WriteLine("Open");
            Console.WriteLine(connection.Database);
            Console.WriteLine(connection.DataSource);
            Console.WriteLine(connection.Host);
            Console.WriteLine(connection.Port);
            Console.WriteLine(connection.State);
            Console.WriteLine(connection.ServerVersion);
            var command = new NpgsqlCommand("DELETE FROM USERS *", connection);
            command.ExecuteNonQuery();
            command = new NpgsqlCommand("INSERT INTO USERS VALUES ('LOGIN', 'PASSWORD', '', 'VASYA')", connection);
            command.ExecuteNonQuery();
            command = new NpgsqlCommand("INSERT INTO USERS VALUES ('LOGIN1', 'PASSWORD', '', 'VASYA')", connection);
            command.ExecuteNonQuery();
            command = new NpgsqlCommand("INSERT INTO USERS VALUES ('LOGIN2', 'PASSWORD', '', 'VASYA')", connection);
            command.ExecuteNonQuery();
            command = new NpgsqlCommand("INSERT INTO USERS VALUES ('LOGIN3', 'PASSWORD', '', 'VASYA')", connection);
            command.ExecuteNonQuery();
            command = new NpgsqlCommand("INSERT INTO USERS VALUES ('LOGIN4', 'PASSWORD', '', 'VASYA')", connection);
            command.ExecuteNonQuery();
            command = new NpgsqlCommand("DELETE FROM USERS *", connection);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}