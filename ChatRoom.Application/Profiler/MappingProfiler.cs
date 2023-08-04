using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ChatRoom.Application.DTOs;
using ChatRoom.Application.DTOs.PersonDto;
using ChatRoom.Domain;

namespace ChatRoom.Application.Profiler
{
    class MappingProfiler : Profile
    {
        public MappingProfiler()
        {
            CreateMap<Person, PersonDto>().ReverseMap();
        }
    }
}
