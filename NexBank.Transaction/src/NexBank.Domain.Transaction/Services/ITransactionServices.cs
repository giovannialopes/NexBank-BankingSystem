using NexBank.Domain.Transaction.DTO;

namespace NexBank.Domain.Transaction.Services;

public interface ITransactionServices
{
    Task<TransactionDTO.TransactionResponse?> RegisterTransaction(TransactionDTO.RegisterTransactionRequest request);

    Task<TransactionDTO.TransactionResponse?> GetTransactionById(int id);

}
