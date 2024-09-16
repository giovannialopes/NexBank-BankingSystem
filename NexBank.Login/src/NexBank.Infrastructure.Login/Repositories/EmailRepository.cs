using Microsoft.EntityFrameworkCore;
using NexBank.Domain.Login.Entities;
using NexBank.Domain.Login.Repositories;
using NexBank.Infrastructure.Login.DataAcess;

namespace NexBank.Infrastructure.Login.Repositories;

public class EmailRepository(DbLogin dbLogin) : IEmailRepository
{
    public Task Commit() => dbLogin.SaveChangesAsync();
    public async Task<LoginEnt?> GetEmail(string email) => await dbLogin.Tb_Login.AsNoTracking().
        FirstOrDefaultAsync(config => config.Email == email && config.IsActive == true);

}
