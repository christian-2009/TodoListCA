using Microsoft.Extensions.DependencyInjection;
using TodoListCA.Application.Services.Authentication;

namespace TodoListCA.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
