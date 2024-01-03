using Application.Services;
using Domain.Objects.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class TransactionController : ControllerBase
{
    private readonly TransactionService _transactionService;

    public TransactionController(TransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    [HttpPost("[controller]/Credit")]
    public async Task<IActionResult> Credit([FromBody] CreateTransaction transaction)
    {
        return Ok(await _transactionService.CreateCredit(transaction));
    }

    [HttpPost("[controller]/Debit")]
    public async Task<IActionResult> Debit([FromBody] CreateTransaction transaction)
    {
        return Ok(await _transactionService.CreateDebit(transaction));
    }

    [HttpPost("[controller]/[action]")]
    public async Task<IActionResult> Transfer([FromBody] CreateTransfer transfer)
    {
        await _transactionService.CreateTransfer(transfer);
        return NoContent();
    }

    [HttpGet("[controller]/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _transactionService.Get(id));
    }

    [HttpGet("User/[controller]/Type")]
    public async Task<IActionResult> GetForUser(int userId, string? type)
    {
        return Ok(await _transactionService.GetForUser(userId, type));
    }

    [HttpGet("Account/[controller]/Type")]
    public async Task<IActionResult> GetForAccount(int accountId, string? type)
    {
        return Ok(await _transactionService.GetForAccount(accountId, type));
    }

    [HttpGet("[controller]")]
    public async Task<IActionResult> Get()
    {
        return Ok(await _transactionService.Get());
    }
}
