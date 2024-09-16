using NexBank.API.Domain.DTO;

namespace NexBank.API.Domain.Services;

public interface IAccountServices
{
    Task<AccountDTO.AccountResponse?> CreateAccount(AccountDTO.CreateAccountRequest request);
    Task<AccountDTO.AccountResponseList?> GetAccounts();
    Task<string?> DeleteAccount(int id);
    Task<AccountDTO.AccountResponse?> UpdateAccount(AccountDTO.UpdateAccountRequest request);
}
