using AITech.WEBUI.DTOs.CategoryDtos;
using AITech.WEBUI.DTOs.FAQDtos;

namespace AITech.WEBUI.Services.FAOServices
{
    public interface IFAQService
    {
        Task<List<ResultFAQDto>> GetAllAsync();
        Task<UpdateFAQDto> GetByIdAsync(int id);
        Task CreateAsync(CreateFAQDto FAQDto);
        Task UpdateAsync(UpdateFAQDto FAQDto);
        Task DeleteAsync(int id);
    }
}
