using App.Application.Usecases.UserInformation;
using App.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace App.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service) 
    {
        service.AddTransient<ICreateUserService, CreateUserService>();

        return service;
    }
}
