using Domain.Objects.Entity;

namespace Domain.Interfaces;

public interface ITransactionRepository
{
    public Task Create(TransactionEntity transaction);
    public Task Delete(int id);
    public Task Get(int id);
    public Task Get();
    public Task GetAll(int accountId);
}
