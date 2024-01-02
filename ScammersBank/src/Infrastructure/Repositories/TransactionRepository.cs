using Domain.Interfaces;
using Domain.Objects.CustomTypes;
using Domain.Objects.Entity;
using System.Data;

namespace Infrastructure.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly IDbConnection _connection;

    public TransactionRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public Task<int> Create(TransactionEntity transaction)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TransactionEntity>> GetAllForAccount(int accountId, TransactionType type)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TransactionEntity>> GetAllForUser(int userId, TransactionType type)
    {
        throw new NotImplementedException();
    }

    Task<TransactionEntity> ITransactionRepository.Get(int id)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<TransactionEntity>> ITransactionRepository.Get()
    {
        throw new NotImplementedException();
    }
}
