using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Console_.NetGenericHost
{
    internal class Program
    {
        private static void Main(string[] args) 
        {
            var builder = new ConfigurationBuilder();

            builder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appSettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIROMENT") ?? "PRODUCTION"}.json", optional: true)
                .AddEnvironmentVariables();

            var host = Host.CreateDefaultBuilder (args)
                .ConfigureServices((hostContext,services) =>
                {
                    //services.AddTransient<IMyService,MyService>();
                    services.AddScoped<IMyService,MyService>();
                    //services.AddSingleton<IMyService,MyService>();
                })
                .Build ();


            var scope = host.Services.CreateScope();

            var service00 = scope.ServiceProvider.GetService<IMyService>();
            service00?.Run();
            var service01 = scope.ServiceProvider.GetService<IMyService>();
            service01?.Run();
            var service02 = scope.ServiceProvider.GetRequiredService<IMyService>();
            service02?.Run();

            Console.WriteLine("-------Out of Scope-------");
            var service03 = host.Services.GetService<IMyService>();
            service03?.Run();
            var service04 = host.Services.GetService<IMyService>();
            service04?.Run();

            Console.WriteLine("-------Scope n2-------");
            var scope2 = host.Services.CreateScope();

            var service05 = scope2.ServiceProvider.GetService<IMyService>();
            service00?.Run();
            var service06 = scope2.ServiceProvider.GetService<IMyService>();
            service01?.Run();
            var service07 = scope2.ServiceProvider.GetRequiredService<IMyService>();
            service02?.Run();

        }

    }
}
