using Microsoft.Extensions.DependencyInjection;

namespace AutoMapperInterface.Application;

public static class ApplicationServiceCollection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}