using AutoMapper;
using MagicShilla_Utility.Entity;
using MagicShilla_Utility.Dto;

namespace MagicShilla_Utility
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Shilla, ShillaDto>().ReverseMap();
            CreateMap<Shilla, CreateShillaDto>().ReverseMap();
            CreateMap<Shilla, UpdateShillaDto>().ReverseMap();
            CreateMap<ShillaNumber, ShillaNumberDto>().ReverseMap();
            CreateMap<ShillaNumber, ShillaNumberCreateDto>().ReverseMap();
            CreateMap<ShillaNumber, ShillaNumberUpdateDto>().ReverseMap();
            CreateMap<ApplicationUser,LocalUserDto>().ReverseMap();
        }
    }
}
