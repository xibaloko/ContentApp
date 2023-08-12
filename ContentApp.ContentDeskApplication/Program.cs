using ContentApp.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Configuration;
using System.Drawing;

namespace ContentApp.ContentDeskApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            //string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

            //string con = @"Data Source=localhost\\SQLEXPRESS;Initial Catalog=dbcontent;User ID=sa;Password=Militao01++;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var builder = Host.CreateDefaultBuilder();

            builder.ConfigureServices((hostContext, services) =>
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer("Data Source = localhost\\SQLEXPRESS; Initial Catalog = dbcontent; User ID = sa; Password = Militao01++; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"));

                services.AddTransient<FrmMain>();
            });

            using var host = builder.Build();
            using var serviceScope = host.Services.CreateScope();
            var services = serviceScope.ServiceProvider;

            var form = services.GetRequiredService<FrmMain>();

            Application.Run(form);
        }

    }
}