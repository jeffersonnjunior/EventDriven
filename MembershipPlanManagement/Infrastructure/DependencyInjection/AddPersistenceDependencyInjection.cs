using Infrastructure.Persistence.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

public static class AddPersistenceDependencyInjection
{
    public static IServiceCollection PersistenceDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<MongoContext>(provider => new MongoContext(configuration));

        return services;
    }
}