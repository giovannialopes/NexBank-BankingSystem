using Microsoft.Extensions.DependencyInjection;

namespace NexBank.Infrastructure.Login.Dependency;

public static class DepedencyInjectionInfrastructure
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        AddRepositories(services);
    }

    private static void AddRepositories(IServiceCollection services)
    {

    }
}
