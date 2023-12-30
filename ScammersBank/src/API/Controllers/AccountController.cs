using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace API.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    [HttpPost("[controller]")]
    public async Task<int> Create() // userid + account type
    {
        throw new NotImplementedException();
    }

    [HttpPut("[controller]")]
    public async Task Update()
    {
        throw new NotImplementedException();
    }

    [HttpDelete("[controller]")]
    public async Task Delete() // account id
    {
        throw new NotImplementedException();
    }

    [HttpGet("[controller]/{id}")]
    public async Task Gets(int id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("[controller]")]
    public async Task Get()
    {
        throw new NotImplementedException();
    }
}
