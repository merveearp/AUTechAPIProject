using AITech.WEBUI.DTOs.SocialDtos;
using AITech.WEBUI.DTOs.UserMessageDtos;

namespace AITech.WEBUI.Services.UserMessageServices
{
    public interface IUserMessageService
    {
        Task<List<ResultUserMessageDto>> GetAllAsync();
        Task<ResultUserMessageDto> GetByIdAsync(int id);
        Task CreateAsync(CreateUserMessageDto createDto);
        Task UpdateAsync(UpdateUserMessageDto updateDto);
        Task DeleteAsync(int id);
    }
}
