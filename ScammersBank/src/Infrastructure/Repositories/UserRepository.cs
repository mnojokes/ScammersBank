using Domain.Interfaces;
using Domain.Objects.Entity;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    public Task<int> Create(UserEntity user)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserEntity>> Get()
    {
        throw new NotImplementedException();
    }

    public Task Update(UserEntity user)
    {
        throw new NotImplementedException();
    }
}
