using Microsoft.EntityFrameworkCore;
using NexBank.Domain.Login.Entities;
using NexBank.Domain.Login.Repositories;
using NexBank.Infrastructure.Login.DataAcess;

namespace NexBank.Infrastructure.Login.Repositories;

public class LoginRepository(DbLogin dbLogin) : ILoginRepository
{
    public async Task Commit() => await dbLogin.SaveChangesAsync();

    public void AddUser(LoginEnt login) => dbLogin.Tb_Login.AddAsync(login);

    public void DeleteUser(LoginEnt login) => dbLogin.Tb_Login.Update(login);

    public async Task<LoginEnt?> GetUserById(int id) => await dbLogin.Tb_Login.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id);

}
