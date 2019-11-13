using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Business.Abstract.Services;
using E_Commerce.Entities.Concrete;
using E_Commerce.WebApiCore.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult UserList()
        {
            var users = _authService.UsersList();
            return Ok(users);
        }

        [HttpPost]

        public async Task<IActionResult> Register([FromBody] UserRegisterForDto userRegisterForDto)
        {
            if (await _authService.UserExists(userRegisterForDto.Username))
            {
                ModelState.AddModelError("Username", "Username already exist");
            }

            if (await _authService.EmailExist(userRegisterForDto.Email))
            {
                ModelState.AddModelError("Email", "Email already exist");
            }

            var userToCreate = new ApplicationUser
            {
                Email = userRegisterForDto.Email,
                UserName = userRegisterForDto.Username
            };

            var createdUser = _authService.Register(userToCreate, userRegisterForDto.Password);
            return StatusCode(201, createdUser);
        }
    }
}