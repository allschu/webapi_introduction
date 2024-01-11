using FastEndpoints;
using webapplication_template.DTO;

namespace webapplication_template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllers();

            //OPTION 3
            //builder.Services.AddFastEndpoints();
            
            var app = builder.Build();

            //OPTION 1
            app.MapControllers();


            //OPTION 2
            app.MapGet("/weatherkinds", () =>
            {
                return Summaries;
            });

            app.MapPost("user/adduser", async (CreateUserRequest request) =>
            {
                //Logic to add user to datastore
                await Task.Delay(500);

                return 2;
            });
            

            app.Run();
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
