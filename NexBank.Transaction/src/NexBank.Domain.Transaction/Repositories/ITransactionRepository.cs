using NexBank.Domain.Transaction.Entities;

namespace NexBank.Domain.Transaction.Repositories;

public interface ITransactionRepository : ICommit
{
    void AddUser(TransactionEnt login);

    void DeleteUser(TransactionEnt login);

    Task<TransactionEnt?> GetUserById(int id);
}
