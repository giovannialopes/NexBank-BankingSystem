using Microsoft.Extensions.DependencyInjection;
using NexBank.Domain.Account.AutoMapper;
using NexBank.Domain.Account.Services;

namespace NexBank.Domain.Account.Dependency;

public static class DependencyInjectionDomain
{
    public static void AddDomain(this IServiceCollection services)
    {
        AddServices(services);
        AutoMapper(services);
    }

    public static void AddServices(IServiceCollection services)
    {
        services.AddScoped<IAccountServices, AccountServices>();
    }

    private static void AutoMapper(IServiceCollection services) => services.AddAutoMapper(typeof(AutoMapping));
}
