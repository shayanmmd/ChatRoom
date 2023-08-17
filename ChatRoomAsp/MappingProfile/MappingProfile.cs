using AutoMapper;
using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoomAsp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GroupNameVM,GroupNameDto>().ReverseMap();
        }
    }
}
