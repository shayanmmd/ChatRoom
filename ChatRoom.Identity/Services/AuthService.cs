using ChatRoom.Application.Contracts.Identity;
using ChatRoom.Application.Models.Identity;
using ChatRoom.Application.Models.Identity.Login;
using ChatRoom.Application.Models.Identity.Register;
using ChatRoom.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace ChatRoom.Identity.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IOptions<JwtSettings> _options;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthService(UserManager<ApplicationUser> userManager, IOptions<JwtSettings> options, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _options = options;
            _signInManager = signInManager;
        }

        public Task<AuthResponse> LoginAsync(AuthRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<RegisterationResponse> RegisterAsync(RegisterationRequest request)
        {
            var existingUser = _userManager.Users.SingleOrDefault();
            if (existingUser == null)
                throw new Exception("user already registered");
            var user = new ApplicationUser
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
            };
            var resutlt = await _userManager.CreateAsync(user, request.PhoneNumber);
            if (!resutlt.Succeeded)
                throw new Exception("task failed");
            await _userManager.AddToRoleAsync(user, "User");
            return new RegisterationResponse { Guid = Guid.Parse(user.Id) };
        }
    }
}
