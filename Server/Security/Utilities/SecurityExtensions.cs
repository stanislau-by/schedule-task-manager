using Microsoft.Extensions.DependencyInjection;

namespace Security.Utilities;

public static class SecurityExtensions
{
    public static IServiceCollection AddSecurityServices(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);



        return services;
    }
}
