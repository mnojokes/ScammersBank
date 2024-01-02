using Application.Services;
using Domain.Objects.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost("[controller]")]
    public async Task<IActionResult> Create([FromBody] CreateUser user)
    {
        return Ok(await _userService.Create(user));
    }

    [HttpPut("[controller]")]
    public async Task<IActionResult> Update([FromBody] UpdateUser user)
    {
        await _userService.Update(user);
        return Ok();
    }

    [HttpDelete("[controller]/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _userService.Delete(id);
        return Ok();
    }

    [HttpGet("[controller]/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _userService.Get(id));
    }

    [HttpGet("[controller]")]
    public async Task<IActionResult> Get()
    {
        return Ok(await _userService.Get());
    }
}
