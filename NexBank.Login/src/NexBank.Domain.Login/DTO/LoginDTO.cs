using Newtonsoft.Json;

namespace NexBank.Domain.Login.DTO;

public class LoginDTO
{
    public class LoginRequest()
    {
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }

    public class CreateLoginRequest()
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string CPFOrCNPJ { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }

    public class LoginResponse()
    {
        public string Token { get; set; } = string.Empty;
    }
}
