using NexBank.Domain.Transaction.Entities;

namespace NexBank.Domain.Transaction.Repositories;

public interface ITransactionRepository : ICommit
{
    void AddTransaction(TransactionEnt transaction);

    Task<TransactionEnt?> GetTransactionById(int id);
}
