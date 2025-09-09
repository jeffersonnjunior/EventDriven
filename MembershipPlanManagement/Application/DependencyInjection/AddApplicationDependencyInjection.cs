using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection;

public static class AddDependencyInjectionApplication
{
    public static void DependencyInjectionApplication(this IServiceCollection services, IConfiguration configuration)
    {
    services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddDependencyInjectionApplication).Assembly));
    services.AddTransient(typeof(MediatR.IPipelineBehavior<,>), typeof(Application.Behaviors.LoggingBehavior<,>));
    services.AddTransient(typeof(MediatR.IPipelineBehavior<,>), typeof(Application.Behaviors.PerformanceBehavior<,>));
    }
}
