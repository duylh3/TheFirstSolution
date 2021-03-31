using AppData;
using AppDTO;
using AutoMapper;

namespace AppServices.Mapper
{
    public class MappingProfile : Profile       
    {
        public MappingProfile()
        {
            CreateMap<UserInfo, UserInfoDTO>().ReverseMap();
        }
    }
}
