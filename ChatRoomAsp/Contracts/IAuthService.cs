using ChatRoomAsp.Models.Entities.Auth;
using ChatRoomAsp.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.Contracts
{
    public interface IAuthService
    {
        public Task<AuthResponse> LoginAsync(LoginVM request);
    }
}
