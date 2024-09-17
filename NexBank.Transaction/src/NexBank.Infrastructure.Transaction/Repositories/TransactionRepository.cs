using Microsoft.EntityFrameworkCore;
using NexBank.Domain.Transaction.Entities;
using NexBank.Domain.Transaction.Repositories;
using NexBank.Infrastructure.Transaction.DataAcess;

namespace NexBank.Infrastructure.Transaction.Repositories;

public class TransactionRepository(DbTransaction dbTransaction) : ITransactionRepository
{
    public async Task Commit() => await dbTransaction.SaveChangesAsync();

    public void AddUser(TransactionEnt login) => dbTransaction.Tb_Transaction.AddAsync(login);

    public void DeleteUser(TransactionEnt login) => dbTransaction.Tb_Transaction.Update(login);

    public async Task<TransactionEnt?> GetUserById(int id) => await dbTransaction.Tb_Transaction.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id);

}
