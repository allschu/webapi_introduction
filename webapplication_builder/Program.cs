using Microsoft.AspNetCore.Mvc;

namespace webapplication_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            var host = builder.Build();

            host.MapGet("/hello", () => "world");

            host.Run();

        }
    }
}
