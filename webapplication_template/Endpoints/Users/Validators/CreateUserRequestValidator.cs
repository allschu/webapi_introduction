using FastEndpoints;
using FluentValidation;

namespace webapplication_template.Endpoints.Users.Validators
{
    public class CreateUserRequestValidator : Validator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("email address is required")
                .EmailAddress()
                .WithMessage("must contain a valid email address");
        }
    }
}
