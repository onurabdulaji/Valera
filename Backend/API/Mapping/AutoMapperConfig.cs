using AutoMapper;
using DTO.ApplicationUserDTO;
using Entity.Models;

namespace API.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateUserRM,ApplicationUser>().ReverseMap();
        }
    }
}
