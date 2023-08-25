using ChatRoom.Application.Models.Identity.Login;
using ChatRoom.Application.Models.Identity.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> LoginAsync(AuthRequest request);
        Task<RegisterationResponse> RegisterAsync(RegisterationRequest request);

    }
}
