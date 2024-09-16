using NexBank.Domain.Account.DTO;

namespace NexBank.Domain.Account.Services;

public interface IAccountServices
{
    Task<AccountDTO.AccountResponse?> CreateAccount(AccountDTO.CreateAccountRequest request);
    Task<AccountDTO.AccountResponseList?> GetAccounts();
    Task<string?> DeleteAccount(int id);
    Task<AccountDTO.AccountResponse?> UpdateAccount(AccountDTO.UpdateAccountRequest request);
}
