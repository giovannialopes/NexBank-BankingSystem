using Microsoft.EntityFrameworkCore;
using NexBank.Domain.Account.Entities;

namespace NexBank.Infrastructure.Account.DataAcess;

public class DbAccount : DbContext
{
    public DbAccount(DbContextOptions options) : base(options)
    {

    }

    public DbSet<AccountEnt> Tb_Account { get; set; }
}
