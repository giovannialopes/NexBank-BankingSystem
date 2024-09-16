using AutoMapper;
using NexBank.Domain.Login.DTO;
using NexBank.Domain.Login.Entities;
using NexBank.Domain.Login.Repositories;

namespace NexBank.Domain.Login.Services;

public class LoginServices(ILoginRepository repository,
    IEmailRepository emailRepository, IMapper mapper) : ILoginServices
{
    public async Task<string?> CreateLogin(LoginDTO.CreateLoginRequest request)
    {
        var User = mapper.Map<LoginEnt>(request);

        repository.AddUser(User);

        await repository.Commit();

        return "Usuário Criado";
    }

    public async Task<string?> DeleteLogin(int id)
    {
        var User = await repository.GetUserById(id);
        if (User != null)
        {
            User.IsActive = false;

            repository.DeleteUser(User);

            await repository.Commit();

            return "Usuário Deletado";
        }
        return default;
    }

    public async Task<LoginDTO.LoginResponse?> GetLogin(LoginDTO.LoginRequest request)
    {
        var User = await emailRepository.GetEmail(request.Email);
        if (User != null)
        {
            return new LoginDTO.LoginResponse { Token = "DASI(@ODJHIO1!%$5OI151JOI13!5*(!!$" };
        }
        return default;
    }
}
