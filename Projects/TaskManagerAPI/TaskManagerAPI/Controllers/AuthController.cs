using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Interfaces;
using TaskManagerAPI.Models.DTOs;

namespace TaskManagerAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto dto)
        {
            return await _userService.Register(dto) ? Ok("User registered.") : BadRequest("Registration failed.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto dto)
        {
            var token = await _userService.Login(dto);
            return token == null ? Unauthorized("Invalid credentials.") : Ok(new { Token = token });
        }
    }
}
