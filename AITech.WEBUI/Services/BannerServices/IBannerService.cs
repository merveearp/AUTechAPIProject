using AITech.WEBUI.DTOs.AboutDtos;
using AITech.WEBUI.DTOs.BannerDtos;

namespace AITech.WEBUI.Services.BannerServices
{
    public interface IBannerService
    {
        Task<ResultBannerDto?> GetAsync();
        Task CreateAsync(CreateBannerDto createBannerDto);
        Task UpdateAsync(UpdateBannerDto updateBannerDto );

    }
}
