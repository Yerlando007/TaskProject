using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MediatR;
using FluentValidation;
using DataManager.Base;
using TaskProject.Interfaces;
using TaskProject.Services;

namespace TaskProject.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CategoryContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            //options.UseLazyLoadingProxies();
        });

        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
        {
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        }));

        services.AddScoped<Func<CategoryContext>>((provider) => () => provider.GetService<CategoryContext>()!);

        return services;
    }

    public static IServiceCollection ConfigureApplicationAssemblies(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddHttpClient<IApiClient, ApiClientService>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services
            .AddScoped<ICategory, CategoryServices>()
            .AddScoped<IGood, GoodServices>()
            .AddScoped<IApiClient, ApiClientService>();
    }
}