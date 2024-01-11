using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace generic_host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A Host is an object that encapsulates an app's resources and lifetime functionality, such as:
            // 
            // Dependency injection (DI)
            // Logging
            // Configuration
            // App shutdown
            // IHostedService implementations

            //using the .NET Generic Host in ASP.NET Core.
            var hostBuilder = Host.CreateDefaultBuilder();
            
            //using the default container services, and add default logging capabilities
            hostBuilder.ConfigureServices(f => f.AddLogging());

            hostBuilder.ConfigureAppConfiguration(hostConfig =>
            {
                hostConfig.SetBasePath(Directory.GetCurrentDirectory());
                hostConfig.AddJsonFile("hostsettings.json"); //See that custom hostettingsfile is being read
                hostConfig.AddEnvironmentVariables(prefix: "PREFIX_");
            });

            var host = hostBuilder.Build();

            //use the logger
            var logger = host.Services.GetService<ILogger<Program>>();

            logger?.LogInformation("Is started");

            host.Run();
        }
    }
}
