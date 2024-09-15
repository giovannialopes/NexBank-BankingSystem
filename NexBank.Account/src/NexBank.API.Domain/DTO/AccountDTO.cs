using System.ComponentModel.DataAnnotations;
using static NexBank.API.Domain.Entities.AccountEnt;

namespace NexBank.API.Domain.DTO;

public class AccountDTO
{
    public class CreateAccountRequest 
    {
        public AccountType Type { get; set; }
    }
  
    public class CreateAccountResponse 
    {
        public string AccountNumber { get; set; } = string.Empty;
        public string AgencyNumber { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public AccountType Type { get; set; }
        public AccountStatus Status { get; set; }
    }
    
    public class UpdateAccountRequest 
    {
    }

}
       