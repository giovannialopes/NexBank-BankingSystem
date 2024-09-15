using Microsoft.AspNetCore.Mvc;
using NexBank.API.Domain.DTO;
using NexBank.API.Domain.Services;

namespace NexBank.API.Account.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAccount(
        [FromServices] IAccountServices services,
        [FromBody] AccountDTO.CreateAccountRequest request)
    {
        var response = await services.CreateAccount(request);
        return Ok(response);
    }
}
