using App.Domain.Services;
using App.Domain.ViewModel.UserInfo;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.V1;

public static class UserInformations
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/usuarios", RegisterAsync);
    }

    /// <summary>
    /// Handles user registration requests.
    /// </summary>
    /// <param name="userService">The user creation service.</param>
    /// <param name="registryInformation">The registration information.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the registration operation.</returns>
    private static async Task<IResult> RegisterAsync(
        [FromServices] ICreateUserService userService,
        [FromBody] RegisterInformation registryInformation,
        CancellationToken cancellationToken
    )
    {
        if (registryInformation == null)
            return Results.BadRequest("Registry informations cannot be null");

        var result = await userService.CreateUser(registryInformation, cancellationToken);
        return Results.Ok(result);
    }
}
