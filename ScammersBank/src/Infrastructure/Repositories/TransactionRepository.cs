using Dapper;
using Domain.Exceptions;
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

    public async Task<int> Create(TransactionEntity transaction)
    {
        string sql = "INSERT INTO transactions (\"accountId\", type, amount, fees, notes) VALUES (@accountId, @type, @amount, @fees, @notes) RETURNING id";
        var query = new
        {
            accountId = transaction.AccountId,
            type = transaction.Type,
            amount = transaction.Amount,
            fees = transaction.Fees,
            notes = transaction.Notes
        };

        int objectId = await _connection.QuerySingleOrDefaultAsync<int>(sql, query);
        if (objectId == default)
        {
            throw new InvalidOperationException("TransactionRepository::Create unable to add transaction");
        }

        return objectId;
    }

    public async Task Delete(int id)
    {
        string sql = "UPDATE transactions SET \"isDeleted\" = TRUE WHERE id = @id AND \"isDeleted\" = FALSE";
        var query = new
        {
            id = id
        };

        if (await _connection.ExecuteAsync(sql, query) != 1)
        {
            throw new TransactionNotFoundException(id.ToString());
        }
    }

    public async Task<IEnumerable<TransactionEntity>> GetAllForAccount(int accountId, TransactionType type)
    {
        string sql = "SELECT * FROM transactions WHERE \"isDeleted\" = FALSE AND \"accountId\" = @accId";
        if (type < TransactionType.Any)
        {
            sql += " AND type = @type";
        }
        var query = new
        {
            accId = accountId,
            type = (int)type
        };

        return await _connection.QueryAsync<TransactionEntity>(sql, query);
    }

    public async Task<IEnumerable<TransactionEntity>> GetAllForUser(int userId, TransactionType type)
    {
        throw new NotImplementedException();
    }

    public async Task<TransactionEntity> Get(int id)
    {
        string sql = "SELECT * FROM transactions WHERE id = @id AND \"isDeleted\" = FALSE";
        var query = new
        {
            id = id,
            isDeleted = false
        };

        return await _connection.QuerySingleOrDefaultAsync<TransactionEntity>(sql, query) ?? throw new TransactionNotFoundException(id.ToString());
    }

    public async Task<IEnumerable<TransactionEntity>> Get()
    {
        string sql = "SELECT * FROM transactions WHERE \"isDeleted\" = FALSE";

        return await _connection.QueryAsync<TransactionEntity>(sql);
    }
}
