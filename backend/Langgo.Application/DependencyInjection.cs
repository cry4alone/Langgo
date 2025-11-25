using Langgo.Application.Common.Interfaces.Services;
using Langgo.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Langgo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        
        return services;
    }
}