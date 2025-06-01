using Microsoft.EntityFrameworkCore;
using RepositoryPatternPrj.Data;
using RepositoryPatternPrj.Repositories;
using RepositoryPatternPrj.Repositories.Abstractions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IProductRepository, ProductRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
