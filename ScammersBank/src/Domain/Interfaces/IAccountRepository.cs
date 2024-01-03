using Domain.Objects.Entity;

namespace Domain.Interfaces;

public interface IAccountRepository
{
    public Task<int> Create(AccountEntity account);
    public Task Update(AccountEntity account);
    public Task Close(int id);
    public Task<AccountEntity> Get(int id);
    public Task<IEnumerable<AccountEntity>> Get();
    public Task AdjustBalance(int id, decimal change);
}
