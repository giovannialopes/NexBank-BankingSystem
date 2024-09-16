using NexBank.Domain.Login.DTO;

namespace NexBank.Domain.Login.Services;

public interface ILoginServices
{
    Task<string?> CreateLogin(LoginDTO.CreateLoginRequest request);

    Task<LoginDTO.LoginResponse?> GetLogin(LoginDTO.LoginRequest request);

    Task<string?> DeleteLogin(int id);
}
