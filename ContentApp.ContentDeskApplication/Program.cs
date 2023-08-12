using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

            var builder = Host.CreateDefaultBuilder();

            builder.ConfigureServices((hostContext, services) =>
            {
                services.AddTransient<Form1>();
            });

            using var host = builder.Build();
            using var serviceScope = host.Services.CreateScope();
            var services = serviceScope.ServiceProvider;

            var form = services.GetRequiredService<Form1>();

            Application.Run(form);
        }
       
    }
}