using AutoMapperInterface.Application;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMapperInterface.Infrastructure;

public static class InfrastructureServiceCollection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services.AddApplication();
    }
}