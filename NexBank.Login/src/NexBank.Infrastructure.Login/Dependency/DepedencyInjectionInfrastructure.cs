using Microsoft.Extensions.DependencyInjection;
using NexBank.Domain.Login.Repositories;
using NexBank.Infrastructure.Login.Repositories;

namespace NexBank.Infrastructure.Login.Dependency;

public static class DepedencyInjectionInfrastructure
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        AddRepositories(services);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IEmailRepository, EmailRepository>();
        services.AddScoped<ILoginRepository, LoginRepository>();

    }
}
