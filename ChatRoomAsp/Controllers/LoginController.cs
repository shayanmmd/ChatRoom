using ChatRoomAsp.Contracts;
using ChatRoomAsp.Models.Entities.Auth;
using ChatRoomAsp.Services.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var res = await _authService.LoginAsync(loginVM);

            return View("~/Views/Login/Login.cshtml", res.ErrorMessage);

        }

    }
}
