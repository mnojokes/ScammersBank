using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    [HttpPost("[controller]")]
    public async Task<string> Create()
    {
        throw new NotImplementedException();
    }

    [HttpPut("[controller]")]
    public async Task Update()
    {
        throw new NotImplementedException();
    }

    [HttpDelete("[controller]")]
    public async Task Delete()
    {
        throw new NotImplementedException();
    }

    [HttpGet("[controller]/{id}")]
    public async Task Get(int id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("[controller]")]
    public async Task Get()
    {
        throw new NotImplementedException();
    }

    // TODO: add transaction getting endpoints (by id, account id (and type?), all)
}
