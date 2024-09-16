using Microsoft.AspNetCore.Mvc;
using NexBank.Domain.Login.DTO;
using NexBank.Domain.Login.Services;

namespace NexBank.API.Login.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> CreateLogin(
        [FromServices] ILoginServices services ,
        [FromBody] LoginDTO.CreateLoginRequest request) 
    {
    }
}
