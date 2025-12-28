using AITech.DTO.TokenDtos;
using AITech.DTO.UserDtos;


namespace AITech.Business.Services.UserServices
{
    public interface IUserService
    {
        Task CreateAsync(RegisterUserDto registerDto);
        Task<LoginResponseDto> LoginAsync(LoginUserDto userDto);

    }
}
