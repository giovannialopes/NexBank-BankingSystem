using Microsoft.EntityFrameworkCore;
using NexBank.Domain.Account.Entities;
using NexBank.Domain.Account.Repositories;
using NexBank.Infrastructure.Account.DataAcess;

namespace NexBank.Infrastructure.Account.Repositories;

public class AccountRepository(DbAccount dbAccount) : IAccountRepository
{
    public async Task Commit() => await dbAccount.SaveChangesAsync();

    public void AddAccount(AccountEnt account) => dbAccount.Tb_Account.AddAsync(account);

    public async Task<AccountEnt?> VerifyAccount(string accountNumber, string agencyNumber) => await dbAccount.Tb_Account.
        AsNoTracking().
        FirstOrDefaultAsync(config => config.AccountNumber == accountNumber && config.AgencyNumber == agencyNumber);

    public async Task<List<AccountEnt>> GetAccounts() => await dbAccount.Tb_Account.AsNoTracking().Where(config => config.Status == AccountEnt.AccountStatus.Active).ToListAsync();

    public async Task<AccountEnt?> GetAccountById(int id) => await dbAccount.Tb_Account.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id);

    public void DeleteAccount(AccountEnt account) => dbAccount.Tb_Account.Update(account);

    public void UpdateAccount(AccountEnt account) => dbAccount.Tb_Account.Update(account);

}

