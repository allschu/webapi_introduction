using System.ComponentModel.DataAnnotations;

namespace webapplication_template.DTO
{
    public class CreateWeatherRequest
    {
        public string Name { get;  }
        public string Description { get; }
    }
}
