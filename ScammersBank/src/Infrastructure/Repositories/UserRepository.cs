using Dapper;
using Domain.Exceptions;
using Domain.Interfaces;
using Domain.Objects.DTO;
using Domain.Objects.Entity;
using System.Data;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IDbConnection _connection;

    public UserRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<int> Create(UserEntity user)
    {
        string sql = "INSERT INTO users (name, address) VALUES (@name, @address) RETURNING id";
        var query = new
        {
            name = user.Name,
            address = user.Address
        };

        int objectId = await _connection.QuerySingleOrDefaultAsync<int>(sql, query);
        if (objectId == default)
        {
            throw new InvalidOperationException("UserRepository::Create unable to add user");
        }

        return objectId;
    }

    public async Task Update(UserEntity user)
    {
        string sql = "UPDATE users SET ";
        bool isContainsData = false;
        if (user.Name != string.Empty)
        {
            sql += "name = @name";
            isContainsData = true;
        }
        if (user.Address != string.Empty)
        {
            if (isContainsData)
            {
                sql += ", ";
            }
            isContainsData = true;
            sql += "address = @address ";
        }
        if (!isContainsData)
        {
            throw new InvalidOperationException("No values to update");
        }
        sql += "WHERE id = @id AND \"isDeleted\" = FALSE";

        var query = new
        {
            name = user.Name,
            address = user.Address,
            id = user.Id
        };

        if (await _connection.ExecuteAsync(sql, query) != 1)
        {
            throw new UserNotFoundException(user.Id.ToString());
        }
    }

    public async Task Delete(int id)
    {
        string sql = "UPDATE users SET \"isDeleted\" = TRUE WHERE id = @id AND \"isDeleted\" = FALSE";
        var query = new
        {
            id = id
        };

        if (await _connection.ExecuteAsync(sql, query) != 1)
        {
            throw new UserNotFoundException(id.ToString());
        }
    }

    public async Task<UserEntity> Get(int id)
    {
        string sql = "SELECT * FROM users WHERE id = @id AND \"isDeleted\" = FALSE";
        var query = new
        {
            id = id
        };

        return await _connection.QuerySingleOrDefaultAsync<UserEntity>(sql, query) ?? throw new UserNotFoundException(id.ToString());
    }

    public async Task<IEnumerable<UserEntity>> Get()
    {
        string sql = "SELECT * FROM users WHERE \"isDeleted\" = FALSE";

        return await _connection.QueryAsync<UserEntity>(sql);
    }
}
