using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    [HttpPost]
    public async Task Credit() // account id amount
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task Debit() // account id amount
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task Transfer() // from account id to account id amount
    {
        throw new NotImplementedException();
    }
}
