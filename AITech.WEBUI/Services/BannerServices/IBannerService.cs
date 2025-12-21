using AITech.WEBUI.DTOs.BannerDtos;

namespace AITech.WEBUI.Services.BannerServices
{
    public interface IBannerService
    {
        Task MakeActiveAsync(int id);
        Task MakePassiveAsync(int id);
        Task<List<ResultBannerDto>> GetAllAsync();
        Task<UpdateBannerDto> GetByIdAsync(int id);
        Task CreateAsync(CreateBannerDto createBannerDto);
        Task UpdateAsync(UpdateBannerDto updateBannerDto );
        Task DeleteAsync(int id);
    }
}
