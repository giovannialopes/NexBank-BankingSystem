using Microsoft.Extensions.DependencyInjection;
using NexBank.Domain.Transaction.Repositories;
using NexBank.Infrastructure.Transaction.Repositories;

namespace NexBank.Infrastructure.Login.Dependency;

public static class DepedencyInjectionInfrastructure
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        AddRepositories(services);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<ITransactionRepository, TransactionRepository>();

    }
}
