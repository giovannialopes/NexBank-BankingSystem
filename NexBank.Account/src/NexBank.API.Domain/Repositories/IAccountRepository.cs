using NexBank.Domain.Account.Entities;

namespace NexBank.Domain.Account.Repositories;

public interface IAccountRepository : ICommit
{
    void AddAccount(AccountEnt account);

    Task<AccountEnt?> VerifyAccount(string accountNumber, string agencyNumber);

    Task<List<AccountEnt>> GetAccounts();

    Task<AccountEnt?> GetAccountById(int id);

    void DeleteAccount(AccountEnt account);
    void UpdateAccount(AccountEnt account);
}
