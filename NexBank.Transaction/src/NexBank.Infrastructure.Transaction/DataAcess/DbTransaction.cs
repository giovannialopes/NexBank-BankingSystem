using Microsoft.EntityFrameworkCore;
using NexBank.Domain.Transaction.Entities;

namespace NexBank.Infrastructure.Transaction.DataAcess;

public class DbTransaction : DbContext
{
    public DbTransaction(DbContextOptions options) : base(options)
    {

    }

    public DbSet<TransactionEnt> Tb_Transaction { get; set; }
}
