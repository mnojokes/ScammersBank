using Domain.Interfaces;
using Domain.Objects.Entity;
using System.Data;
using Dapper;
using Domain.Exceptions;
using Domain.Objects.DTO;

namespace Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly IDbConnection _connection;

    public AccountRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<int> Create(AccountEntity account)
    {
        string sql = "INSERT INTO accounts (type, balance, \"holderId\") VALUES (@type, @balance, @holderId) RETURNING id";
        var query = new
        {
            type = account.Type,
            balance = account.Balance,
            holderId = account.HolderId
        };

        int objectId = await _connection.QuerySingleOrDefaultAsync<int>(sql, query);
        if (objectId == default)
        {
            throw new InvalidOperationException("AccountRepository::Create unable to add account");
        }

        return objectId;
    }

    public async Task Update(AccountEntity account)
    {
        string sql = "UPDATE accounts SET type = @type WHERE id = @id";
        var query = new
        {
            type = account.Type,
            id = account.Id
        };

        if (await _connection.ExecuteAsync(sql, query) != 1)
        {
            throw new AccountNotFoundException(account.Id.ToString());
        }
    }

    public async Task Close(int id)
    {
        string sql = "UPDATE accounts SET \"isClosed\" = @isClosed WHERE id = @id";
        var query = new
        {
            isClosed = true,
            id = id
        };

        if (await _connection.ExecuteAsync(sql, query) != 1)
        {
            throw new AccountNotFoundException(id.ToString());
        }
    }

    public async Task<AccountEntity> Get(int id)
    {
        string sql = "SELECT * FROM accounts WHERE id = @id";
        var query = new
        {
            id = id
        };

        return await _connection.QuerySingleOrDefaultAsync<AccountEntity>(sql, query) ?? throw new AccountNotFoundException(id.ToString());
    }

    public async Task<IEnumerable<AccountEntity>> Get()
    {
        string sql = "SELECT * FROM accounts";

        return await _connection.QueryAsync<AccountEntity>(sql);
    }
}
