using Microsoft.Extensions.DependencyInjection;
using TodoListCA.Application.Common.Interfaces.Authentication;
using TodoListCA.Infrastructure.Authentication;

namespace TodoListCA.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

        return services;
    }
}
