using System.ComponentModel.DataAnnotations;

namespace webapplication_template.DTO
{
    public class CreateUserRequest
    {
        [Required]
        [StringLength(255, ErrorMessage = "The username is not valid")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "This is not valid email address")]
        public string Email { get; set; }
    }
}
