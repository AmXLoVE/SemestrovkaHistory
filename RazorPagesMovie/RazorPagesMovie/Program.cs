using System;
using System.Configuration;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Npgsql;
using NpgsqlTypes;

namespace RazorPagesMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connection = new NpgsqlConnection {ConnectionString = ConfigurationManager.ConnectionStrings["history"].ConnectionString};
            connection.Open();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}