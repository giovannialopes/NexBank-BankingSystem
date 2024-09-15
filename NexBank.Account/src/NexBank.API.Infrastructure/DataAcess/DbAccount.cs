using Microsoft.EntityFrameworkCore;
using NexBank.API.Domain.Entities;

namespace NexBank.API.Infrastructure.DataAcess
{
    public class DbAccount : DbContext
    {
        public DbAccount(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AccountEnt> Tb_Account { get; set; }
    }
}
