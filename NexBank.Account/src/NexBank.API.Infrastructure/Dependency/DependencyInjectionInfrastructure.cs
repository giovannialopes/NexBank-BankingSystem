using Microsoft.Extensions.DependencyInjection;
using NexBank.Domain.Account.Repositories;
using NexBank.Infrastructure.Account.Repositories;

namespace NexBank.Infrastructure.Account.Dependency;

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
