using Microsoft.AspNetCore.Mvc;
using webapplication_template.DTO;

namespace webapplication_template.Controllers
{
    [ApiController]
    [Route("WeatherForecasts")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWeather(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult PostWeather(CreateWeatherRequest request, CancellationToken cancellationToken = default)
        {
            //Do any logic to store the weather request
            const int weatherId = 2; //Fake the id

            var location = this.Url.Action(nameof(GetWeather), new { id = weatherId }) ?? $"/{weatherId}";

            //return a HTTP 201 result
            return Created(location, weatherId);
        }

        #region private

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        #endregion
    }
}
