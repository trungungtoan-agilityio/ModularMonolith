
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Module.Catalog.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCatalogCore(this IServiceCollection services)
    {
        // services.AddMediatR(Assembly.GetExecutingAssembly()); // => MediatR version 11
        // using MediatR@12.0.1
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}