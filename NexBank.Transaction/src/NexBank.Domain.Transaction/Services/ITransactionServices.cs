using NexBank.Domain.Transaction.DTO;

namespace NexBank.Domain.Transaction.Services;

public interface ITransactionServices
{
    Task<string?> CreateLogin(TransactionDTO.CreateTransactionRequest request);

    Task<TransactionDTO.TransactionResponse?> GetLogin(TransactionDTO.TransactionRequest request);

    Task<string?> DeleteLogin(int id);
}
