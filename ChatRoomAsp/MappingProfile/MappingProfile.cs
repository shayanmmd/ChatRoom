using AutoMapper;
using ChatRoomAsp.Models.Entities;
using ChatRoomAsp.Models.Entities.Auth;
using ChatRoomAsp.Services.Base;
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
            CreateMap<LoginVM, AuthRequest>().ReverseMap();
        }
    }
}
