using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Business.Abstract.Services;
using E_Commerce.Business.Concrete.AutoMapper.Dtos.Auth;
using E_Commerce.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace E_Commerce.WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;
        public AuthController(IAuthService authService, IConfiguration configuration)
        {
            _authService = authService;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult UserList()
        {
            var users = _authService.UsersList();
            return Ok(users);
        }

       [HttpPost("register")]
       public async Task<IActionResult> Register([FromBody]RegisterUserForDto userRegisterForDto)
        {
          if(await _authService.UserExists(userRegisterForDto.Username))
            {
                return BadRequest("Username already exists");
            }

            var userToCreate = new User
            {
                UserName = userRegisterForDto.Username.ToLower()
            };

            var createdUser = await _authService.Register(userToCreate, userRegisterForDto.Password);

            return StatusCode(201);
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]UserLoginForDto userForLoginDto)
        {
            var userFromDb = await _authService.Login(userForLoginDto.Username, userForLoginDto.Password);

            if(userFromDb == null)
            {
                return Unauthorized();
            }

            var claims = new[]
            {
                new  Claim(ClaimTypes.NameIdentifier, userFromDb.Id.ToString()),
                new Claim(ClaimTypes.Name, userFromDb.UserName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new { token = tokenHandler.WriteToken(token) });
        }
    }
}