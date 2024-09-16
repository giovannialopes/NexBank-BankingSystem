using Microsoft.AspNetCore.Mvc;
using NexBank.Domain.Login.DTO;
using NexBank.Domain.Login.Services;

namespace NexBank.API.Login.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{

    [HttpPost]
    [Route("CreateLogin")]
    public async Task<IActionResult> CreateLogin(
        [FromServices] ILoginServices services,
        [FromBody] LoginDTO.CreateLoginRequest request)
    {
        var response = await services.CreateLogin(request);
        return Ok(response);
    }

    [HttpPost]
    [Route("GetLogin")]
    public async Task<IActionResult> GetLogin(
        [FromServices] ILoginServices services,
        [FromBody] LoginDTO.LoginRequest request)
    {
        var response = await services.GetLogin(request);
        return Ok(response);
    }

    [HttpDelete]
    [Route("DeleteLogin")]
    public async Task<IActionResult> DeleteLogin(
        [FromServices] ILoginServices services,
        [FromHeader] int id)
    {
        var response = await services.DeleteLogin(id);
        return Ok(response);
    }
}
