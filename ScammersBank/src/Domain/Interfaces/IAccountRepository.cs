using Domain.Objects.Entity;

namespace Domain.Interfaces;

public interface IAccountRepository
{
    public Task Create(AccountEntity account);
    public Task Close(int id);
}
