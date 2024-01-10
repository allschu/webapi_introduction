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

            var host = hostBuilder.Build();

            host.Run();
        }
    }
}
