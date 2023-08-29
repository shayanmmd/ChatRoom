using ChatRoom.Application.Contracts.Identity;
using ChatRoom.Application.Models.Identity;
using ChatRoom.Application.Models.Identity.Login;
using ChatRoom.Application.Models.Identity.Register;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace ChatRoom.Identity.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly IOptions<JwtSettings> _options;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
           // _options = options;
            _signInManager = signInManager;
        }

        public async Task<AuthResponse> LoginAsync(AuthRequest request)
        {
            var existingUser = _userManager.Users.SingleOrDefault(x => x.UserName == request.UserName && x.PhoneNumber == request.PhoneNumber);
            if (existingUser == null)
                throw new Exception("you are not registerd to login");
            var user = new IdentityUser
            {
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber
            };
            await _signInManager.SignInAsync(user, false);
            return new AuthResponse { Guid = Guid.Parse(user.Id), PhoneNumber = request.PhoneNumber, UserName = request.UserName };
        }

        public async Task<RegisterationResponse> RegisterAsync(RegisterationRequest request)
        {
            var existingUser = _userManager.Users.SingleOrDefault(x => x.UserName == request.UserName && x.PhoneNumber == request.PhoneNumber);
            if (existingUser != null)
                throw new Exception("user already registered");
            var user = new IdentityUser
            {
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                PhoneNumberConfirmed = true
            };
            var resutlt = await _userManager.CreateAsync(user, request.PhoneNumber);
            if (!resutlt.Succeeded)
                throw new Exception("task failed");
            await _userManager.AddToRoleAsync(user, "User");
            return new RegisterationResponse { Guid = Guid.Parse(user.Id) };
        }
    }
}
