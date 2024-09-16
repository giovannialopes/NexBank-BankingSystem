namespace NexBank.Domain.Login.DTO;

public class LoginDTO
{
    public class CreateLoginRequest()
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class LoginRequest()
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string CPFOrCNPJ { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }

    public class LoginResponse()
    {
        public string Token { get; set; } = string.Empty;
    }
}
