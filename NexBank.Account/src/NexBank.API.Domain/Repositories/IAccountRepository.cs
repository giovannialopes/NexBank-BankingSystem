using NexBank.API.Domain.Entities;

namespace NexBank.API.Domain.Repositories;

public interface IAccountRepository : ICommit
{
    void AddAccount(AccountEnt account);

    Task<AccountEnt?> VerifyAccount(string accountNumber, string agencyNumber);

    Task<List<AccountEnt>> GetAccounts();

    Task<AccountEnt?> GetAccountById(int id);

    void DeleteAccount(AccountEnt account);
    void UpdateAccount(AccountEnt account);
}
