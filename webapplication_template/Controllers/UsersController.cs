using Microsoft.AspNetCore.Mvc;
using webapplication_template.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapplication_template.Controllers
{
    /// <summary>
    /// API for accessing user resources
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Returns the user based on the given id
        /// </summary>
        /// <param name="id">The userid</param>
        /// <returns></returns>
        [HttpGet("{id}", Name = nameof(GetUser))]
        public IActionResult GetUser(string id)
        {
            if (!int.TryParse(id, out var userId))
                return BadRequest();

            return Ok(new UserDTO()
            {
                Id = userId,
                Email = "user@metrohm.com",
                Name = "Eugene user",
                Username = "user1"
            });
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post(CreateUserRequest createUserRequest, CancellationToken cancellationToken = default)
        {
            const int userId = 2; //Fake the id

            var location = this.Url.Action(nameof(Get), new { id = userId }) ?? $"/{userId}";
            
            return Created(location, userId);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
