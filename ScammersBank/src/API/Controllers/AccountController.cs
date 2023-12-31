﻿using Application.Services;
using Domain.Objects.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    private readonly AccountService _accountService;

    public AccountController(AccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpPost("[controller]")]
    public async Task<IActionResult> Create([FromBody] CreateAccount account)
    {
        return Ok(await _accountService.Create(account));
    }

    [HttpPut("[controller]")]
    public async Task<IActionResult> Update([FromBody] UpdateAccount account)
    {
        await _accountService.Update(account);
        return NoContent();
    }

    [HttpDelete("[controller]/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _accountService.Close(id);
        return NoContent();
    }

    [HttpGet("[controller]/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _accountService.Get(id));
    }

    [HttpGet("[controller]")]
    public async Task<IActionResult> Get()
    {
        return Ok(await _accountService.Get());
    }
}
