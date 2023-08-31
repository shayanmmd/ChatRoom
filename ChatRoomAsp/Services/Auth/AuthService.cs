using AutoMapper;
using ChatRoomAsp.Contracts;
using ChatRoomAsp.Models.Entities.Auth;
using ChatRoomAsp.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IClient _client;
        private readonly IMapper _mapper;

        public AuthService(IClient client, IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        public async Task<AuthResponse> LoginAsync(LoginVM request)
        {
            var authRequest = _mapper.Map<AuthRequest>(request);
            return await _client.LoginAsync(authRequest);
        }
    }
}
