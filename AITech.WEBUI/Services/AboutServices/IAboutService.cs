using AITech.WEBUI.DTOs.AboutDtos;

namespace AITech.WEBUI.Services.AboutServices
{
    public interface IAboutService
    {
        Task<ResultAboutDto?> GetAsync();
        Task UpdateAsync(UpdateAboutDto updateDto);
        Task CreateAsync(CreateAboutDto createDto);
    }
}