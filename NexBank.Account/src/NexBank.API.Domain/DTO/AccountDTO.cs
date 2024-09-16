using static NexBank.Domain.Account.Entities.AccountEnt;

namespace NexBank.Domain.Account.DTO;

public class AccountDTO
{
    public class CreateAccountRequest
    {
        public AccountType Type { get; set; }
    }

    public class AccountResponse
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public string AgencyNumber { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }

    public class UpdateAccountRequest
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }

    public class AccountResponseList
    {
        public List<AccountResponse> Accounts { get; set; } = new List<AccountResponse>();
    }

}
