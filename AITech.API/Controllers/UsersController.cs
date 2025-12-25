using AITech.Business.Services.UserServices;
using AITech.DTO.UserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService _userService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserDto registerDto)
        {
            await _userService.CreateAsync(registerDto);
            return Ok("Kullanıcı Oluşturuldu");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto loginDto)
        {
            await _userService.LoginAsync(loginDto);
            return Ok("Giriş başarılı");
        }
    }
}
