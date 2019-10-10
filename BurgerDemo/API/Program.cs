using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BurgerDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var host = BuildWebHost(args);
            var config = host.Services.GetService<IConfiguration>();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var serviceProvider = services.GetRequiredService<IServiceProvider>();

                    //Uncomment to seed the initial users and roles
                    //SampleData.Initialize(serviceProvider).GetAwaiter().GetResult();

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message, "An error occurred while creating roles");
                }
            }
            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>().Build();
    }
}
