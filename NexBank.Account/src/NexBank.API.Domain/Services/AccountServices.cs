using AutoMapper;
using NexBank.API.Domain.DTO;
using NexBank.API.Domain.Entities;
using NexBank.API.Domain.Repositories;
using NexBank.API.Domain.Utilities;

namespace NexBank.API.Domain.Services;

public class AccountServices(IAccountRepository repository, IMapper mapper) : IAccountServices
{
    public async Task<AccountDTO.CreateAccountResponse?> CreateAccount(AccountDTO.CreateAccountRequest? request)
    {
        var account = mapper.Map<AccountEnt>(request);

        account.AccountNumber = Generator.AccountNumber();
        account.AgencyNumber = Generator.AgencyNumber();

        var verifyAccount = await repository.VerifyAccount(account.AccountNumber, account.AgencyNumber);

        if (verifyAccount == null)
        {
            repository.AddAccount(account);

            await repository.Commit();

            return mapper.Map<AccountDTO.CreateAccountResponse>(account);
        }

        return default;
    }
}
