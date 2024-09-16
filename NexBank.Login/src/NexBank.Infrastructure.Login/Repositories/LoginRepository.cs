using NexBank.Domain.Login.Repositories;
using NexBank.Infrastructure.Login.DataAcess;

namespace NexBank.Infrastructure.Login.Repositories;

public class LoginRepository(DbLogin dbLogin) : ILoginRepository
{
    public Task Commit() => dbLogin.SaveChangesAsync();

}
