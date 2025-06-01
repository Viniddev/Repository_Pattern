using App.Application;
using App.Infrastructure;
using App.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("App.Api")
    );
});

builder.Services.AddInfrastructure();
builder.Services.AddApplication();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
