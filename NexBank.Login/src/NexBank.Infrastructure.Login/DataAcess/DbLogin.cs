using Microsoft.EntityFrameworkCore;
using NexBank.Domain.Login.Entities;

namespace NexBank.Infrastructure.Login.DataAcess;

public class DbLogin : DbContext
{
    public DbLogin(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<LoginEnt> Tb_Login { get; set; }
}
