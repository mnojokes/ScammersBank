using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    [HttpPost]
    public async Task<int> Create() // userid + account type
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    public async Task Update()
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public async Task Delete() // account id
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public async Task Get(int id)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public async Task Get()
    {
        throw new NotImplementedException();
    }
}
