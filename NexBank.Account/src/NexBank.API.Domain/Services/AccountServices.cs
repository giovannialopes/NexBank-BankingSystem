using NexBank.API.Domain.DTO;

namespace NexBank.API.Domain.Services;

public class AccountServices : IAccountServices
{
    public Task<AccountDTO.CreateAccountResponse> CreateAccount(AccountDTO.CreateAccountRequest request)
    {
        throw new NotImplementedException();
    }
}
