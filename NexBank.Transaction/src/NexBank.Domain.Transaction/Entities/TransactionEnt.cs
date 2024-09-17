namespace NexBank.Domain.Transaction.Entities;

public class TransactionEnt
{
    public int Id { get; set; }
    public int SourceAccountId { get; set; }
    public int DestinationAccountId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; } = DateTime.Now;
    public TransactionType TransactionType { get; set; }
    public TransactionStatus Status { get; set; } = TransactionStatus.Pending;
    public string Description { get; set; } = string.Empty;
}

public enum TransactionType
{
    TED,
    DOC,
    PIX,
    InternalTransfer
}

public enum TransactionStatus
{
    Pending,
    Processed,
    Cancelled
}

