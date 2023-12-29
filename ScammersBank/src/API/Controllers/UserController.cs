using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]
    public async Task<string> Create()
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    public async Task Update()
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public async Task Delete()
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
