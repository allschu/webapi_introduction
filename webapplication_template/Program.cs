namespace webapplication_template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddControllers();
            
            var app = builder.Build();
            
            app.MapControllers();

            app.MapGet("/GetWeatherKinds", () =>
            {
                return Summaries;
            });

            app.Run();
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
