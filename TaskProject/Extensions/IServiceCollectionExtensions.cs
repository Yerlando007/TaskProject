using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MediatR;
using FluentValidation;
using DataManager.Base;
using TestMediatorApi.Services;
using TaskProject.Interfaces;

namespace TaskProject.Extensions;

public static class IServiceCollectionExtensions
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
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services.AddScoped<ICategoryAdd, CategoryAddServices>();
    }
}