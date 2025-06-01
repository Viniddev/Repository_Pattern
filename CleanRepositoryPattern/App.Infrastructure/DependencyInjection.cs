using App.Domain.Abstractions.Interfaces;
using App.Domain.Repositories;
using App.Infrastructure.Data.UnitOfWork;
using App.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace App.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services) 
    {
        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
