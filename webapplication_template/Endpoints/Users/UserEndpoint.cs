using FastEndpoints;

namespace webapplication_template.Endpoints.Users
{
    /// <summary>
    /// Endpoint for user creation
    /// </summary>
    public class UserEndpoint : Endpoint<CreateUserRequest, CreateUserResponse>
    {
        /// <inheritdoc/>
        public override void Configure()
        {
            Post("/user/create");
            AllowAnonymous();
        }

        /// <inheritdoc/>
        public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
        {
            //simulate adding user
            await Task.Delay(400);

           await SendOkAsync(ct);
        }
    }
}
