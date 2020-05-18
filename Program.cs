using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MiPrimerWebApi9.Contexts;

namespace MiPrimerWebApi9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = CreateHostBuilder(args).Build();

            // Segunda forma de realizar las migraciones en IIS. (O donde sea)
            // En Azure no necesitamos este código por lo explicado en el curso
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var applicationDbContext = services.GetService<ApplicationDbContext>();
                applicationDbContext.Database.Migrate();
            }

            webHost.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
