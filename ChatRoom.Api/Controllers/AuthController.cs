using ChatRoom.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Api.Controllers
{
  
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("Auth/GenerateJwt")]
        public IActionResult GenerateJwt([FromBody] Login login)
        {
            if (!ModelState.IsValid)
                return BadRequest("The Model Is Not valid");
            if (login.UserName != "shayan" || login.Password != "371382sH371382")
                return Unauthorized();
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Our Valid Token Will Be Used In This"));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokenOptions = new JwtSecurityToken(
                issuer: _configuration.GetSection("ValidServer").Value,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signingCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return Ok(new { token = tokenString });
        }
    }
}
