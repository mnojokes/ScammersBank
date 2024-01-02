using Domain.Objects.CustomTypes;
using Domain.Objects.Entity;

namespace Domain.Interfaces;

public interface ITransactionRepository
{
    public Task<int> Create(TransactionEntity transaction);
    public Task Delete(int id);
    public Task<TransactionEntity> Get(int id);
    public Task<IEnumerable<TransactionEntity>> Get();
    public Task<IEnumerable<TransactionEntity>> GetAllForUser(int userId, TransactionType type);
    public Task<IEnumerable<TransactionEntity>> GetAllForAccount(int accountId, TransactionType type);
}
