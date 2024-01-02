using Domain.Interfaces;
using Domain.Objects.Entity;
using System.Data;

namespace Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly IDbConnection _connection;

    public AccountRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public Task<int> Create(AccountEntity account)
    {
        throw new NotImplementedException();
    }

    public Task Update(AccountEntity account)
    {
        throw new NotImplementedException();
    }

    public Task Close(int id)
    {
        throw new NotImplementedException();
    }

    public Task<AccountEntity> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AccountEntity>> Get()
    {
        throw new NotImplementedException();
    }
}
