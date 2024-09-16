using Microsoft.EntityFrameworkCore;
using NexBank.API.Domain.DTO;
using NexBank.API.Domain.Entities;
using NexBank.API.Domain.Repositories;
using NexBank.API.Infrastructure.DataAcess;

namespace NexBank.API.Infrastructure.Repositories;

public class AccountRepository(DbAccount dbAccount) : IAccountRepository
{
    public Task Commit() => dbAccount.SaveChangesAsync();

    public void AddAccount(AccountEnt account) => dbAccount.Tb_Account.AddAsync(account);

    public Task<AccountEnt?> VerifyAccount(string accountNumber, string agencyNumber) => dbAccount.Tb_Account.
        AsNoTracking().
        FirstOrDefaultAsync(config => config.AccountNumber == accountNumber && config.AgencyNumber == agencyNumber);

}
