namespace webapplication_builder_startup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

            hostBuilder.Build().Run();
        }
    }
}
