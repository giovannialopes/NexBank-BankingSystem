using NexBank.Domain.Login.Entities;

namespace NexBank.Domain.Login.Repositories;

public interface IEmailRepository : ICommit
{
    Task<LoginEnt?> GetEmail(string email);
}
