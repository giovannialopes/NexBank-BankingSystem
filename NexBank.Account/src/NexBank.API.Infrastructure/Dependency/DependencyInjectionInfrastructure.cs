using Microsoft.Extensions.DependencyInjection;
using NexBank.API.Domain.Repositories;
using NexBank.API.Infrastructure.Repositories;

namespace NexBank.API.Infrastructure.Dependency;

public static class DependencyInjectionInfrastructure
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        AddRepositories(services);
    }

    public static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();
    }

}
