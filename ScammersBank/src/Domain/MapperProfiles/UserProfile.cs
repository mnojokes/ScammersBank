using AutoMapper;
using Domain.Objects.DTO;
using Domain.Objects.Entity;

namespace Domain.MapperProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserEntity, User>().ReverseMap();
        CreateMap<CreateUser, UserEntity>();
        CreateMap<UpdateUser, UserEntity>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name ?? string.Empty))
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address ?? string.Empty));
    }
}
