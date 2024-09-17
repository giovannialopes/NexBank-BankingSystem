using Microsoft.AspNetCore.Mvc;
using NexBank.Domain.Transaction.DTO;
using NexBank.Domain.Transaction.Services;

namespace NexBank.API.Transaction.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> RegisterTransaction(
        [FromServices] ITransactionServices services,
        [FromBody] TransactionDTO.RegisterTransactionRequest request)
    {
        var response = await services.RegisterTransaction(request);
        return Ok(response);
    }
}
