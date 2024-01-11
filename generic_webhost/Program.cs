using generic_webhost.services;

namespace generic_webhost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var hostBuilder = Host.CreateDefaultBuilder()
                //Configure a WebHostBuilder which already has defaults
                .ConfigureWebHostDefaults(f =>
                {
                    //automatically configures internal kestrel webserver
                    f.Configure(config =>
                    {
                        //Extension point for new logging providers
                        f.ConfigureLogging(loggingBuilder => loggingBuilder.AddConsole());
                    });
                });

            hostBuilder.ConfigureServices(serviceCollection =>
            {
                //flavours of injection
                //Transient objects are always different.
                serviceCollection.AddTransient<IGreetingService, GreetingService>();

                //Scoped objects are the same for a given request but differ across each new request.
                //serviceCollection.AddScoped();

                //Singleton objects are the same for every request.
                //serviceCollection.AddSingleton();
            });

            var host = hostBuilder.Build();
            
            var logger = host.Services.GetService<ILogger<Program>>();
            var greetingService = host.Services.GetService<IGreetingService>();

            var greet = greetingService?.Greeting();
            Console.WriteLine(greet);


            host.Run();
        }
    }
}
