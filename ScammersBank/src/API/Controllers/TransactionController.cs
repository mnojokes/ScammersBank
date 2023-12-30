using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class TransactionController : ControllerBase
{
    [HttpPost("[action]/{id}")]
    public async Task Credit(int id) // account id amount
    {
        throw new NotImplementedException();
    }

    [HttpPost("[action]/{id}")]
    public async Task Debit(int id) // account id amount
    {
        throw new NotImplementedException();
    }

    [HttpPost("[action]")]
    public async Task Transfer() // from account id to account id amount
    {
        throw new NotImplementedException();
    }
}
