﻿using App.Domain.Repository;
using App.Domain.Services;
using App.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace App.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service) 
    {
        service.AddTransient<IUnitOfWork, UnitOfWork>();
        service.AddTransient<IUserInformationsRepository, UserInformationsRepository>();

        return service;
    }
}
