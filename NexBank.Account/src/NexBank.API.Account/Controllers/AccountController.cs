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
        return Created("", response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAccounts(
        [FromServices] IAccountServices services)
    {
        var response = await services.GetAccounts();
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAccount(
        [FromServices] IAccountServices services,
        [FromBody] AccountDTO.UpdateAccountRequest request)
    {
        var response = await services.UpdateAccount(request);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAccount(
        [FromServices] IAccountServices services,
        [FromHeader] int id)
    {
        var response = await services.DeleteAccount(id);
        return Ok(response);
    }
}
