using NexBank.Domain.Login.Entities;

namespace NexBank.Domain.Login.Repositories;

public interface ILoginRepository : ICommit
{
    void AddUser(LoginEnt login);

    void DeleteUser(LoginEnt login);

    Task<LoginEnt?> GetUserById(int id);
}
