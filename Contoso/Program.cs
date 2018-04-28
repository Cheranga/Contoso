using System;
using Contoso.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Contoso
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                try
                {
                    var schoolContext = serviceProvider.GetService<SchoolContext>();
                    DataInitializer.Initialize(schoolContext);
                }
                catch (Exception exception)
                {
                    var logger = serviceProvider.GetService<ILogger<Program>>();
                    logger.LogError(exception, "Error occured when seeding the database");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}