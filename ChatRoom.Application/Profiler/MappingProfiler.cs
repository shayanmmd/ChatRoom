using AutoMapper;
using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoom.Application.DTOs.PersonDto;
using ChatRoom.Domain;

namespace ChatRoom.Application.Profiler
{
    class MappingProfiler : Profile
    {
        public MappingProfiler()
        {
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<GroupName, GroupNameDto>().ReverseMap();
        }
    }
}
