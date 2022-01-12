using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SumperShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // creating a new variable to store the configurations for our host
            var host = CreateHostBuilder(args).Build();
            // Before starting the project run the RunSeeding method
            RunSeeding(host);
            // Run App;
            host.Run();
        }
        /// <summary>
        /// Like a middleware SEED to automaticaly populate my DB
        /// </summary>
        /// <param name="host"></param>
        private static void RunSeeding(IHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
            using(var scope = scopeFactory.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetService<SeedDb>();
                seeder.SeedAsync().Wait();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
