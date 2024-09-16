using AutoMapper;
using NexBank.API.Domain.DTO;
using NexBank.API.Domain.Entities;
using NexBank.API.Domain.Repositories;
using NexBank.API.Domain.Utilities;

namespace NexBank.API.Domain.Services;

public class AccountServices(IAccountRepository repository, IMapper mapper) : IAccountServices
{
    public async Task<AccountDTO.AccountResponse?> CreateAccount(AccountDTO.CreateAccountRequest request)
    {
        var account = mapper.Map<AccountEnt>(request);

        account.AccountNumber = Generator.AccountNumber();
        account.AgencyNumber = Generator.AgencyNumber();

        var verifyAccount = await repository.VerifyAccount(account.AccountNumber, account.AgencyNumber);

        if (verifyAccount == null)
        {
            repository.AddAccount(account);

            await repository.Commit();

            return mapper.Map<AccountDTO.AccountResponse>(account);
        }

        return default;
    }

    public async Task<string?> DeleteAccount(int id)
    {
        var account = await repository.GetAccountById(id);
        if (account != null)
        {
            account.UpdatedAt = DateTime.Now;
            account.Status = AccountEnt.AccountStatus.Closed;
            repository.DeleteAccount(account);

            await repository.Commit();

            return "Conta Deletada";
        }
        return default;
    }

    public async Task<AccountDTO.AccountResponseList?> GetAccounts()
    {
        var accounts = await repository.GetAccounts();
        if (accounts.Count != 0)
            return new AccountDTO.AccountResponseList { Accounts = mapper.Map<List<AccountDTO.AccountResponse>>(accounts) };

        return default;
    }

    public async Task<AccountDTO.AccountResponse?> UpdateAccount(AccountDTO.UpdateAccountRequest request)
    {
       
        var verifyAccount = await repository.GetAccountById(request.Id);

        if (verifyAccount != null)
        {
            var account = mapper.Map(request, verifyAccount);
            account.UpdatedAt = DateTime.Now;

            repository.UpdateAccount(account);

            await repository.Commit();

            return mapper.Map<AccountDTO.AccountResponse>(account);
        }

        return default;
    }
}
