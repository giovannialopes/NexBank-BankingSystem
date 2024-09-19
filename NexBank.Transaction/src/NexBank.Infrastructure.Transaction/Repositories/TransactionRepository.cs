using Microsoft.EntityFrameworkCore;
using NexBank.Domain.Transaction.Entities;
using NexBank.Domain.Transaction.Repositories;
using NexBank.Infrastructure.Transaction.DataAcess;

namespace NexBank.Infrastructure.Transaction.Repositories;

public class TransactionRepository(DbTransaction dbTransaction) : ITransactionRepository
{
    public async Task Commit() => await dbTransaction.SaveChangesAsync();

    public void AddTransaction(TransactionEnt transaction) => dbTransaction.Tb_Transaction.AddAsync(transaction);

    public async Task<TransactionEnt?> GetTransactionById(int id) => await dbTransaction.Tb_Transaction.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id);

}
