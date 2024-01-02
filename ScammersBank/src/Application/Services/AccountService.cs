using Domain.Exceptions;
using Domain.Interfaces;
using Domain.Objects.DTO;
using Domain.Objects.Entity;
using System.Text.Json;

namespace Application.Services;

public class AccountService
{
    private readonly IAccountRepository _accountRepository;

    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<string> Create(CreateAccount account)
    {
        return JsonSerializer.Serialize(new { id = await _accountRepository.Create(new AccountEntity(account)) });
    }

    public async Task Update(UpdateAccount account)
    {
        await _accountRepository.Update(new AccountEntity(account));
    }

    public async Task Close(int id)
    {
        await _accountRepository.Close(id);
    }

    public async Task<Account> Get(int id)
    {
        AccountEntity entity = await _accountRepository.Get(id);
        if (entity.Id == default)
        {
            throw new AccountNotFoundException(id.ToString());
        }
        return new Account(await _accountRepository.Get(id));
    }

    public async Task<List<Account>> Get()
    {
        var ret = await _accountRepository.Get();
        return ret.Select(e => new Account(e)).ToList();
    }
}
