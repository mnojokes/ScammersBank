using Domain.Interfaces;
using Domain.Objects.Entity;

namespace Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
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
