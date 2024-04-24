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

            #region Scope A
            if (args.Length != 0 && args[0] == "AB")
            {
                var scope_A = host.Services.CreateScope();

                var service00 = scope_A.ServiceProvider.GetService<IMyService>();
                service00?.Run();
                var service01 = scope_A.ServiceProvider.GetService<IMyService>();
                service01?.Run();
                var service02 = scope_A.ServiceProvider.GetRequiredService<IMyService>();
                service02?.Run();

                #endregion

                #region Scope B
                Console.WriteLine("-------Scope n2-------");
                var scope_B = host.Services.CreateScope();

                var service05 = scope_B.ServiceProvider.GetService<IMyService>();
                service05?.Run();
                var service06 = scope_B.ServiceProvider.GetService<IMyService>();
                service06?.Run();
                var service07 = scope_B.ServiceProvider.GetRequiredService<IMyService>();
                service07?.Run();
            }
            #endregion 

            #region No Scope 
            Console.WriteLine("-------Out of Scope-------");
            var service03 = host.Services.GetService<IMyService>();
            service03?.Run();
            var service04 = host.Services.GetService<IMyService>();
            service04?.Run();
            #endregion

        }

    }
}
