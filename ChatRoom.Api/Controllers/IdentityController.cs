using ChatRoom.Application.Contracts.Identity;
using ChatRoom.Application.Models.Identity.Login;
using ChatRoom.Application.Models.Identity.Register;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoom.Api.Controllers
{

    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IAuthService _authService;

        public IdentityController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("/Identity/Register")]
        public async Task<RegisterationResponse> RegisterAsync([FromBody] RegisterationRequest request)
        {
            return await _authService.RegisterAsync(request);
        }

        [HttpPost]
        [Route("/Identity/Login")]
        public async Task<AuthResponse> LoginAsync([FromBody] AuthRequest request)
        {
            return await _authService.LoginAsync(request);
        }
    }
}
