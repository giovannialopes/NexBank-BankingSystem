using NexBank.API.Domain.DTO;

namespace NexBank.API.Domain.Services;

public interface IAccountServices
{
    Task<AccountDTO.CreateAccountResponse> CreateAccount(AccountDTO.CreateAccountRequest request);
}
