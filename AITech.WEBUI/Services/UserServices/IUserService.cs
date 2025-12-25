using AITech.WEBUI.DTOs.TokenDtos;
using AITech.WEBUI.DTOs.UserDtos;

namespace AITech.WEBUI.Services.UserServices
{
    public interface IUserService
    {
        Task CreateAsync(RegisterUserDto registerDto);
        Task<LoginResponseDto> LoginAsync(LoginUserDto loginDto);
    }
}
