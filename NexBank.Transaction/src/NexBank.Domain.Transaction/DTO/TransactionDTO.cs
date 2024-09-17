namespace NexBank.Domain.Transaction.DTO;

public class TransactionDTO
{
    public class TransactionRequest()
    {
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }

    public class CreateTransactionRequest()
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string CPFOrCNPJ { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }

    public class TransactionResponse()
    {
        public string Token { get; set; } = string.Empty;
    }
}
