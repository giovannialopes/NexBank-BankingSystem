using Microsoft.Extensions.DependencyInjection;
using NexBank.Domain.Login.AutoMapper;
using NexBank.Domain.Login.Services;

namespace NexBank.Domain.Login.Dependency;

public static class DepedencyInjectionDomain
{
    public static void AddDomain(this IServiceCollection services)
    {
        AddServices(services);
        AutoMapper(services);
    }

    private static void AddServices(IServiceCollection services)
    {
        services.AddScoped<ILoginServices, LoginServices>();
    }

    private static void AutoMapper(IServiceCollection services) => services.AddAutoMapper(typeof(AutoMapping));

}
