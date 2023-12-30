using Domain.Objects.Entity;

namespace Domain.Interfaces;

public interface IUserRepository
{
    public Task Create(UserEntity user);
    public Task Update(UserEntity user);
    public Task Delete(int id);
    public Task<UserEntity> Get(int id);
    public Task<IEnumerable<UserEntity>> Get();
}
