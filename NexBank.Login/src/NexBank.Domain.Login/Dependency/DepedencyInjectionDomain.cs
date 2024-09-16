using Microsoft.Extensions.DependencyInjection;

namespace NexBank.Domain.Login.Dependency;

public static class DepedencyInjectionDomain
{
    public static void AddDomain(this IServiceCollection services)
    {
        AddServices(services);
    }

    private static void AddServices(IServiceCollection services)
    {

    }
}
