using NexBank.Domain.Transaction.Entities;

namespace NexBank.Domain.Transaction.DTO;

public class TransactionDTO
{
    public class RegisterTransactionRequest()
    {
        public int SourceAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus Status { get; set; } = TransactionStatus.Pending;
        public string Description { get; set; } = string.Empty;
    }

    public class TransactionResponse()
    {
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus Status { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
