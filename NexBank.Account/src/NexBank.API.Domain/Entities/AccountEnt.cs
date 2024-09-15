namespace NexBank.API.Domain.Entities;

public class AccountEnt
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string AccountNumber { get; set; } = string.Empty;
    public string AgencyNumber { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public AccountType Type { get; set; }
    public AccountStatus Status { get; set; } = AccountStatus.Active;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public enum AccountType
    {
        Current,
        Savings,
        Business
    }

    public enum AccountStatus
    {
        Active,
        Inactive,
        Closed,
        Blocked
    }

}
