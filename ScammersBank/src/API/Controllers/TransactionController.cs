using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class TransactionController : ControllerBase
{
    [HttpPost("[controller]/[action]/{accountId}")]
    public async Task<IActionResult> Credit(int accountId) // account id amount
    {
        throw new NotImplementedException();
    }

    [HttpPost("[controller]/[action]/{accountId}")]
    public async Task<IActionResult> Debit(int accountId) // account id amount
    {
        throw new NotImplementedException();
    }

    [HttpPost("[controller]/[action]")]
    public async Task<IActionResult> Transfer() // from account id to account id amount
    {
        throw new NotImplementedException();
    }

    [HttpGet("[controller]/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{userId}/[controller]/{type}")]
    public async Task<IActionResult> GetUser(int userId, string? type)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{accountId}/[controller]/{type}")]
    public async Task<IActionResult> GetAccount(int accountId, string? type)
    {
        throw new NotImplementedException();
    }

    [HttpGet("[controller]")]
    public async Task<IActionResult> Get()
    {
        throw new NotImplementedException();
    }

}
