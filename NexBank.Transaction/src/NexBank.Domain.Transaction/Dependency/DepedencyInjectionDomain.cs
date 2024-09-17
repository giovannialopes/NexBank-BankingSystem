using Microsoft.Extensions.DependencyInjection;
using NexBank.Domain.Transaction.AutoMapper;
using NexBank.Domain.Transaction.Services;

namespace NexBank.Domain.Transaction.Dependency;

public static class DepedencyInjectionDomain
{
    public static void AddDomain(this IServiceCollection services)
    {
        AddServices(services);
        AutoMapper(services);
    }

    private static void AddServices(IServiceCollection services)
    {
        services.AddScoped<ITransactionServices, TransactionServices>();
    }

    private static void AutoMapper(IServiceCollection services) => services.AddAutoMapper(typeof(AutoMapping));

}
