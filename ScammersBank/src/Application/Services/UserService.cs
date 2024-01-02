using AutoMapper;
using Domain.Interfaces;
using Domain.Objects.DTO;
using Domain.Objects.Entity;
using System.Text.Json;

namespace Application.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<string> Create(CreateUser user)
    {
        int ret = await _userRepository.Create(_mapper.Map<UserEntity>(user));
        return JsonSerializer.Serialize(new { id = ret.ToString() });
    }

    public async Task Update(UpdateUser user)
    {
        await _userRepository.Update(_mapper.Map<UserEntity>(user));
    }

    public async Task Delete(int id)
    {
        await _userRepository.Delete(id);
    }

    public async Task<User> Get(int id)
    {
        return _mapper.Map<User>(await _userRepository.Get(id));
    }

    public async Task<List<User>> Get()
    {
        var ret = await _userRepository.Get();
        return ret.Select(e => _mapper.Map<User>(e)).ToList();
    }
}
